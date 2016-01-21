using EnigmaticEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Sms;

namespace EnigmaticEvents.Utils
{
    public static class SmsUtils
    {
        public static async void SendSmsAsync(string message, List<object> recipients)
        {
            var contacts = recipients.Cast<EventContact>();
            foreach(var contact in contacts)
            {
                var sms = new SmsTextMessage2();
                sms.To = contact.PhoneNumber;
                sms.Body = message;
                var result = await SmsDevice2.GetDefault().SendMessageAndGetResultAsync(sms);
            }
        }
    }
}
