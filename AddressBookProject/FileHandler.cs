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
        //ToText - Gör om data så det kan skrivas på en rad i txt-filen
        public static string ToText(Contact contact)
        {
            return $"{contact.Name},{contact.StreetAddress},{contact.PostalCode},{contact.City},{contact.Phone},{contact.Email}";
        }

        //WriteToFile - StreamWriter
        public static void WriteToFile(Contact contact)
        {
            using (StreamWriter writer = new StreamWriter("contacts.txt", append: true))
            {
                writer.WriteLine(FileHandler.ToText(contact));
            }
        }

        //ReadFromFile - StreamReader
        public static void ReadFromFile()
        {
            using (StreamReader reader = new StreamReader("contacts.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //FromText - Läser ut objektet från en rad i txt-filen
        public static Contact FromText(string line)
        {
            string[] parts = line.Split(',');
            return new Contact
            {
                Name = parts[0],
                StreetAddress = parts[1],
                PostalCode = parts[2],
                City = parts[3],
                Phone = parts[4],
                Email = parts[5]
            };
        }
    }
}
