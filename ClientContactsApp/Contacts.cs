using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientContactsApp
{
    public class Contacts
    {
        public int id;
        public string username;
        public byte[] avarta;
        public string email;
        public List<string> phonenumber;

        public Contacts()
        {
            id = 0;
            username = null;
            avarta = null;
            email = null;
            phonenumber = new List<string>();
        }
    }
}
