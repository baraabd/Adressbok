using System;
using System.Windows.Forms;

namespace AddressBookProject.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // wire events HERE, not in Designer
            grid.CellClick += Grid_CellClick;
            btnAdd.Click   += (s,e) => AddClicked();
            btnUpdate.Click+= (s,e) => UpdateClicked();
            btnDelete.Click+= (s,e) => DeleteClicked();
            btnSave.Click  += (s,e) => SaveAllClicked();
            btnSearch.Click+= (s,e) => SearchClicked();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void AddClicked()    { }
        private void UpdateClicked() { }
        private void DeleteClicked() { }
        private void SaveAllClicked(){ }
        private void SearchClicked() { }
    }
}
