using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class ContactsDB
    {
        public int id;
        public string username;
        public string avarta;
        public string email;
        public List<string> phonenumber;
    }

    public class Contacts
    {
        public int id;
        public string username;
        public byte[] avarta;
        public string email;
        public List<string> phonenumber;

        public Contacts(ContactsDB contact)
        {
            id = contact.id; 
            username = contact.username;   
            email = contact.email;
            
            using (var ms = new MemoryStream())
            {
                Image imageIn = Image.FromFile("Database/" + contact.avarta);
                imageIn.Save(ms, imageIn.RawFormat);
                avarta = ms.ToArray();
            }

            phonenumber = contact.phonenumber;
        }
    }
}
