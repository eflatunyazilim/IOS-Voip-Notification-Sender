using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOS_Voip_Notification_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //Push Servis Oluşturuluyor
            var pushService = new PushService(PushService.RunMode.Prod);

            //Push Servisi Başlat
            pushService.apnsBroker.Start();

            //payload {"exam":{"id":1,"refStatus":1}}

            //Voip notification gönder
            JObject payload = JObject.Parse(txtPayload.Text);
            pushService.SendVoipNotification(txtToken.Text, payload);

            //Push Servisi Durdur
            pushService.apnsBroker.Stop();
        }
    }
}
