
using System;
using blog.Interfaces;
using blog.Models;

namespace blog.Implementers{
    public class ContactContext : IContact
    {
        private readonly DatabaseContext databaseContext;
        public ContactContext(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public void AddConctactMessage(string contactFullName, string contactMail, string contactMessage)
        {
            DateTime contactDate = DateTime.Now;
            Contact contactData = new Contact{
                ContactFullName = contactFullName,
                ContactMail = contactMail,
                ContactMessage = contactMessage,
                ContactDate = contactDate,
                ContactCheck = false
            };
            databaseContext.Contacts.Add(contactData);
            databaseContext.SaveChanges();
        }
    }
}