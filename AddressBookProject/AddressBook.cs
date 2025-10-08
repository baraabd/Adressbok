using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    public class AddressBook
    {
        //List to hold contacts
        public List<Contact> ContactsList { get; set; }

        // Constructor: initialize the list and add some test contacts
        public AddressBook()
        {
            // Initialize the contact list
            ContactsList = new List<Contact>();

            // Adding test contacts directly when the AddressBook is created
            ContactsList.Add(new Contact
            {
                Name = "Anna Andersson",
                StreetAddress = "Storgatan 1",
                PostalCode = "11122",
                City = "Stockholm",
                Phone = "0701234567",
                Email = "anna@example.com"
            });

            ContactsList.Add(new Contact
            {
                Name = "Björn Svensson",
                StreetAddress = "Lillgatan 5",
                PostalCode = "22233",
                City = "Göteborg",
                Phone = "0737654321",
                Email = "bjorn@example.com"
            });

            ContactsList.Add(new Contact
            {
                Name = "Clara Nilsson",
                StreetAddress = "Högvägen 10",
                PostalCode = "33344",
                City = "Malmö",
                Phone = "0721112233",
                Email = "clara@example.com"
            });
        }

        public List<Contact> SearchContact(string searchtext)
        {
            List<Contact> resultat = new List<Contact>();

            resultat = ContactsList.Where(k => k.Name.ToLower().Contains(searchtext.ToLower()) || k.City.ToLower().Contains(searchtext.ToLower())).ToList();

            return resultat;

        }
    }

}


