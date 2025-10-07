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
        //FromString - Läser ut objektet från en rad i txt-filen

    }
}
