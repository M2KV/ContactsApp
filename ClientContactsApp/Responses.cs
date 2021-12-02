using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClientContactsApp
{
    internal class Responses
    {
        public string action;
        public string message;

        public Responses(byte[] buffers, int bytes)
        {
            action = null;
            message = null;

            byte[] req = new byte[bytes];
            Array.Copy(buffers, req, bytes);

            string json = Encoding.UTF8.GetString(req);
            try
            {
                Requests newRequest = JsonConvert.DeserializeObject<Requests>(json);

                action = newRequest.action;
                message = newRequest.message;
            }
            catch (JsonException) { }
        }
    }
}
