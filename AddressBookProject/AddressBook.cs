using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Behövs för MessageBox

namespace AddressBookProject
{
    public class AddressBook
    {
        // Lista som håller alla kontakter
        public List<Contact> ContactsList { get; set; }

        // Konstruktor: initierar listan och lägger till några testkontakter
        public AddressBook()
        {
            ContactsList = new List<Contact>();

            // Lägger till hårdkodade kontakter (för testning)
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

        // -------------------------
        // Metod: DeleteContact
        // Tar bort en kontakt baserat på namn
        // -------------------------
        public void DeleteContact(string name)
        {
            // Försök hitta en kontakt i listan som matchar det angivna namnet (ignorerar stora/små bokstäver)
            var contactToRemove = ContactsList
                .FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            // Om kontakten hittades, ta bort den
            if (contactToRemove != null)
            {
                ContactsList.Remove(contactToRemove);
                MessageBox.Show($"Kontakten '{name}' har tagits bort.");
            }
            else
            {
                // Om ingen kontakt hittades, visa ett felmeddelande
                MessageBox.Show($"Ingen kontakt med namnet '{name}' hittades.");
            }
        }
    }
}
