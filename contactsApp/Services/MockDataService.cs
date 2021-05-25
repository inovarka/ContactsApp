using contactsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactsApp.Services
{
    public class MockDataService : IContactDataService
    {
        private IEnumerable<Contact> _contacts;

        public MockDataService()
        {
            _contacts = new List<Contact>()
            {
                new Contact
                {
                    FirstName = "Pavlo Tymofeienko",
                    PhoneNumbers = new string[]
                    {
                        "555-555-111-1111",
                        "555-555-222-2222"
                    },
                    Emails = new string[]
                    {
                        "paveltimofeenko@gmail.com",
                        "myemail@dota.com"
                    },
                    Locations = new string[]
                    {
                        "55 Yangelya St.",
                        "Rivne, Solomiyi Kr. 62a"
                    },
                },
                new Contact
                {
                    FirstName = "Eugene Lepeico",
                    PhoneNumbers = new string[]
                    {
                        "555-555-333-3333",
                        "555-555-444-4444"
                    },
                    Emails = new string[]
                    {
                        "jnlp@gmail.com"
                    },
                    Locations = new string[]
                    {
                        "Hobota Street",
                        "Meme Lords 22a"
                    },
                },
            };
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contacts;
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            _contacts = contacts;
        }
    }
}
