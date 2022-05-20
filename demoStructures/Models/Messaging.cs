using System;

namespace demoStructures.Models
{
    public struct Contact
    {
        public string LastName, FirstName, MailAddress, Pseudo;
    }

    public struct Message
    {
        public string Object, Content;
        public Contact Recipient, Sender;
        public DateTime SendHours;
        public bool Receipt;
    }
}
