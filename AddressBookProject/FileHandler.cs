using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AddressBookProject
{
    internal class FileHandler
    {
        //ToString - Gör om data så det kan skrivas på en rad i txt-filen
        public string ToString(Contact contact)
        {
            return $"{contact.Name},{contact.StreetAddress},{contact.PostalCode},{contact.City},{contact.Phone},{contact.Email}";
        }

        //WriteToFile - StreamWriter
        public static void WriteToFile(Contact contact)
        {
            using (StreamWriter writer = new StreamWriter("contacts.txt", append: true))
            {
                writer.WriteLine(contact.ToString());
            }
        }

        //ReadFromFile - StreamReader
        //FromString - Läser ut objektet från en rad i txt-filen

    }
}
