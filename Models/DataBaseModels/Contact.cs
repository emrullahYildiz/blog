using System;

namespace blog.Models{
    public class Contact{
        public int ContactID { get; set; }
        public string ContactFullName { get; set; }
        public string ContactMail { get; set; }
        public string ContactMessage { get; set; }
        public DateTime ContactDate { get; set; }
        public bool ContactCheck { get; set; }
    }
}