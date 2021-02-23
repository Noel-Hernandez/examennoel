using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_08_01_2021.Models.Domain
{
    public class Contact
    {
        private int idContact;
        private string nameContact;
        private string emailContact;
        private string informationContact;

        public Contact()
        {
        }

        public Contact(int idContact, string nameContact, string emailContact, string informationContact)
        {
            this.IdContact = idContact;
            this.NameContact = nameContact;
            this.EmailContact = emailContact;
            this.InformationContact = informationContact;
        }

        public int IdContact { get => idContact; set => idContact = value; }
        public string NameContact { get => nameContact; set => nameContact = value; }
        public string EmailContact { get => emailContact; set => emailContact = value; }
        public string InformationContact { get => informationContact; set => informationContact = value; }
    }
}
