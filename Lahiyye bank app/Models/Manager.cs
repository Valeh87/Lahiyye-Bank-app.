using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Lahiyye_bank_app_.Models
{
    public class Manager:BaseEntity 
    {
        public string Surname { get; set; }
        public string Username { get; set; }
        public int Userpassword { get; set; }
        public Manager()
        {
            Username = "Valeh";
            Userpassword = 6969;
        }

    }
}
