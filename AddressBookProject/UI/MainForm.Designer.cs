using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AddressBookProject.UI
{
    public partial class MainForm : Form
    {
        private DataGridView grid;
        private TextBox txtName, txtStreet, txtPostal, txtCity, txtPhone, txtEmail, txtSearch;
        private Button btnAdd, btnUpdate, btnDelete, btnLoad, btnSave, btnSearch;
        private Label lName, lStreet, lPostal, lCity, lPhone, lEmail;

        public MainForm()
        {
            InitializeComponent();   
        }

        private void InitializeComponent()
        {
            grid = new DataGridView();
            txtName = new TextBox();  txtStreet = new TextBox();  txtPostal = new TextBox();
            txtCity = new TextBox();  txtPhone = new TextBox();   txtEmail = new TextBox();
            txtSearch = new TextBox();

            btnAdd = new Button(); btnUpdate = new Button(); btnDelete = new Button();
            btnLoad = new Button(); btnSave = new Button(); btnSearch = new Button();

            lName = new Label(); lStreet = new Label(); lPostal = new Label();
            lCity = new Label(); lPhone = new Label(); lEmail = new Label();

            SuspendLayout();
            Text = "AddressBook";
            Width = 1000; Height = 600;

            grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grid.Location = new Point(10, 10);
            grid.Size = new Size(960, 320);
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.MultiSelect = false;
            grid.CellClick += Grid_CellClick;

            int y = 340;
            lName.Text = "Namn";   lName.SetBounds(10, y + 3, 100, 20);
            txtName.SetBounds(120, y, 220, 23);

            y += 30; lStreet.Text = "GatuAdress"; lStreet.SetBounds(10, y + 3, 100, 20);
            txtStreet.SetBounds(120, y, 220, 23);

            y += 30; lPostal.Text = "GatoNummer"; lPostal.SetBounds(10, y + 3, 100, 20);
            txtPostal.SetBounds(120, y, 220, 23);

            y += 30; lCity.Text = "Stad";   lCity.SetBounds(10, y + 3, 100, 20);
            txtCity.SetBounds(120, y, 220, 23);

            y += 30; lPhone.Text = "PhonNummer"; lPhone.SetBounds(10, y + 3, 100, 20);
            txtPhone.SetBounds(120, y, 220, 23);

            y += 30; lEmail.Text = "EpostAddress"; lEmail.SetBounds(10, y + 3, 100, 20);
            txtEmail.SetBounds(120, y, 220, 23);

            btnAdd.Text = "Addera";       btnAdd.SetBounds(380, 340, 80, 27); btnAdd.Click += (s,e)=>AddClicked();
            btnUpdate.Text = "Uppdatera"; btnUpdate.SetBounds(470, 340, 80, 27); btnUpdate.Click += (s,e)=>UpdateClicked();
            btnDelete.Text = "Ta Bort"; btnDelete.SetBounds(560, 340, 80, 27); btnDelete.Click += (s,e)=>DeleteClicked();
            btnSave.Text = "Spara"; btnSave.SetBounds(740, 340, 90, 27); btnSave.Click += (s,e)=>SaveAllClicked();

            txtSearch.SetBounds(380, 380, 240, 23);
            btnSearch.Text = "Söka"; btnSearch.SetBounds(630, 378, 80, 27); btnSearch.Click += (s,e)=>SearchClicked();

            Controls.AddRange(new Control[] {
                grid, lName, txtName, lStreet, txtStreet, lPostal, txtPostal,
                lCity, txtCity, lPhone, txtPhone, lEmail, txtEmail,
                btnAdd, btnUpdate, btnDelete, btnLoad, btnSave, txtSearch, btnSearch
            });

            ResumeLayout(false);
        }

        private void Grid_CellClick(object? sender, DataGridViewCellEventArgs e) { /* fill editors if needed */ }
        private void AddClicked()    { /* TODO */ }
        private void UpdateClicked() { /* TODO */ }
        private void DeleteClicked() { /* TODO */ }
        private void SaveAllClicked(){ /* TODO */ }
        private void SearchClicked() { /* TODO */ }
    }
}
