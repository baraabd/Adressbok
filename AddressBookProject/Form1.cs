using System;
using System.Windows.Forms;

namespace AddressBookProject
{
    public partial class Form1 : Form
    {
        private AddressBook addressBook;

        public Form1()
        {
            InitializeComponent();

            // Skapar AddressBook och laddar hårdkodade kontakter
            addressBook = new AddressBook();

            // Uppdatera ListBox med kontakter
            UpdateContactList();
        }

        // Uppdatera ListBox med aktuella kontakter
        private void UpdateContactList()
        {
            listBoxContacts.Items.Clear();
            foreach (var c in addressBook.ContactsList)
            {
                listBoxContacts.Items.Add(c.Name);
            }
        }

        // Delete-knapp klick
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxContacts.SelectedItem != null)
            {
                string nameToDelete = listBoxContacts.SelectedItem.ToString();

                // Anropar DeleteContact i AddressBook
                addressBook.DeleteContact(nameToDelete);

                // Uppdatera ListBox efter radering
                UpdateContactList();
            }
            else
            {
                MessageBox.Show("Välj en kontakt först.");
            }
        }
    }
}
