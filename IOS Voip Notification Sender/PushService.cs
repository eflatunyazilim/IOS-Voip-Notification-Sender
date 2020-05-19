using Newtonsoft.Json.Linq;
using PushSharp.Apple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOS_Voip_Notification_Sender
{
    public class PushService
    {
        public enum RunMode { Prod, Dev}
        public ApnsServiceBroker apnsBroker { get; set; }
        public PushService(RunMode mode)
        {
            // Configuration (NOTE: .pfx can also be used here)
            var config = new ApnsConfiguration(ApnsConfiguration.ApnsServerEnvironment.Production, "push-cert.p12", "", false);

            if(mode == RunMode.Dev)
                config = new ApnsConfiguration(ApnsConfiguration.ApnsServerEnvironment.Sandbox, "push-cert.p12", "", false);

            // Create a new broker
            apnsBroker = new ApnsServiceBroker(config);

            // Wire up events
            apnsBroker.OnNotificationFailed += (notification, aggregateEx) => {

                aggregateEx.Handle(ex => {

                    // See what kind of exception it was to further diagnose
                    if (ex is ApnsNotificationException notificationException)
                    {

                        // Deal with the failed notification
                        var apnsNotification = notificationException.Notification;
                        var statusCode = notificationException.ErrorStatusCode;

                        Console.WriteLine($"Apple Notification Failed: ID={apnsNotification.Identifier}, Code={statusCode}");
                    }
                    else
                    {
                        // Inner exception might hold more useful information like an ApnsConnectionException			
                        Console.WriteLine($"Apple Notification Failed for some unknown reason : {ex.InnerException}");
                    }

                    // Mark it as handled
                    return true;
                });
            };

            apnsBroker.OnNotificationSucceeded += (notification) => {
                Console.WriteLine("Apple Notification Sent!");
            };
        }

        public void SendVoipNotificationOnce(string deviceToken, JObject payload)
        {
            // Start the broker
            apnsBroker.Start();
            
            apnsBroker.QueueNotification(new ApnsNotification
            {
                DeviceToken = deviceToken,
                Payload = payload
            });

            apnsBroker.Stop();
        }

        public void SendVoipNotification(string deviceToken, JObject payload)
        {
            apnsBroker.QueueNotification(new ApnsNotification
            {
                DeviceToken = deviceToken,
                Payload = payload
            });
        }
    }
}
