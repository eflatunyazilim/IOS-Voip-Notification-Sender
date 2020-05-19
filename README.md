# IOS-Voip-Notification-Sender
Apns Voip Push Notification Sender for IOS


## How to use?
- Place your push certificate under bin/debug or bin/release folder.
- Run
- Type your voip-push Pushkit token and payload
- Click the "Send" button.

## What is Dev or Prod mode?
There are 2 different Apns address.

**Development server:** api.sandbox.push.apple.com:443

**Production server:** api.push.apple.com:443

If you installed the app from appstore, You should use prod. Otherwise you should use deployment server.

More Information:
[Sending Notification Requests to APNs](https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/sending_notification_requests_to_apns)
