using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SmartWatch.ProPlatform.Notifications
{
    public class PushNotification
    {


        public static bool MakePushNotication(string to, string title, string message)
        {
            bool result = false;
            try
            {

                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";

                var data = new
                {
                    to = to,
                    notification = new
                    {
                        body = message,
                        title = title
                    }
                };

                var json = JsonConvert.SerializeObject(data, Formatting.Indented);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}",
                "AAAAAQBMYdU:APA91bHaC421YQVnOfWGTAlpyijqKVivUXVFckUStKcBQK_HEw2uqnPqyHflxF7iiIQBmxWDXxboZgCUlemEihorsJbmzgENZSM8muGzHxXHcj-8FkdjwC281I4Wpu2dg1WNKSUgEMxp"));
                tRequest.Headers.Add(string.Format("Sender: id={0}",
                    "4299973077"));
                tRequest.ContentLength = byteArray.Length;


                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);

                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                string str = sResponseFromServer;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                string str = ex.Message;
                return result;
            }
            result = true;
            return result;

        }
    }

}

