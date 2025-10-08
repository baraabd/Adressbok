#nullable disable
using System.Drawing;
using System.Windows.Forms;

namespace AddressBookProject.UI
{
    public partial class MainForm : Form
    {
        private DataGridView grid;
        private TextBox txtName, txtStreet, txtPostal, txtCity, txtPhone, txtEmail, txtSearch;
        private Button btnAdd, btnUpdate, btnDelete, btnSave, btnSearch;
        private Label lName, lStreet, lPostal, lCity, lPhone, lEmail;

        private void InitializeComponent()
        {
            grid = new DataGridView();
            txtName = new TextBox();
            txtStreet = new TextBox();
            txtPostal = new TextBox();
            txtCity = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            lName = new Label();
            lStreet = new Label();
            lPostal = new Label();
            lCity = new Label();
            lPhone = new Label();
            lEmail = new Label();
            dataGridView1 = new DataGridView();
            AddButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            panel1 = new Panel();
            SearchButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Email = new ListBox();
            PhoneNumber = new ListBox();
            City = new ListBox();
            StreatNumber = new ListBox();
            StreatName = new ListBox();
            PersonName = new ListBox();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grid
            // 
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeight = 40;
            grid.Dock = DockStyle.Top;
            grid.Location = new Point(0, 0);
            grid.MultiSelect = false;
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.RowHeadersWidth = 72;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.Size = new Size(240, 420);
            grid.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(0, 0);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 35);
            txtName.TabIndex = 0;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(0, 0);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(100, 35);
            txtStreet.TabIndex = 0;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(0, 0);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(100, 35);
            txtPostal.TabIndex = 0;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(0, 0);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 35);
            txtCity.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(0, 0);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 35);
            txtPhone.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 0);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 35);
            txtEmail.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(0, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 35);
            txtSearch.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(0, 0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(0, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(0, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            // 
            // lName
            // 
            lName.Location = new Point(0, 0);
            lName.Name = "lName";
            lName.Size = new Size(100, 23);
            lName.TabIndex = 0;
            // 
            // lStreet
            // 
            lStreet.Location = new Point(0, 0);
            lStreet.Name = "lStreet";
            lStreet.Size = new Size(100, 23);
            lStreet.TabIndex = 0;
            // 
            // lPostal
            // 
            lPostal.Location = new Point(0, 0);
            lPostal.Name = "lPostal";
            lPostal.Size = new Size(100, 23);
            lPostal.TabIndex = 0;
            // 
            // lCity
            // 
            lCity.Location = new Point(0, 0);
            lCity.Name = "lCity";
            lCity.Size = new Size(100, 23);
            lCity.TabIndex = 0;
            // 
            // lPhone
            // 
            lPhone.Location = new Point(0, 0);
            lPhone.Name = "lPhone";
            lPhone.Size = new Size(100, 23);
            lPhone.TabIndex = 0;
            // 
            // lEmail
            // 
            lEmail.Location = new Point(0, 0);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(100, 23);
            lEmail.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1540, 609);
            dataGridView1.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(74, 349);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(131, 40);
            AddButton.TabIndex = 1;
            AddButton.Text = "Addera";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(211, 349);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(131, 40);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Ta bort";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(348, 349);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(131, 40);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Justera";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(PhoneNumber);
            panel1.Controls.Add(City);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(StreatNumber);
            panel1.Controls.Add(StreatName);
            panel1.Controls.Add(PersonName);
            panel1.Location = new Point(27, 644);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 410);
            panel1.TabIndex = 5;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(485, 349);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(131, 40);
            SearchButton.TabIndex = 12;
            SearchButton.Text = "Sök";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 245);
            label6.Name = "label6";
            label6.Size = new Size(93, 36);
            label6.TabIndex = 11;
            label6.Text = "E-Post:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 203);
            label5.Name = "label5";
            label5.Size = new Size(203, 36);
            label5.TabIndex = 10;
            label5.Text = "Phone Nummer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 157);
            label4.Name = "label4";
            label4.Size = new Size(71, 36);
            label4.TabIndex = 9;
            label4.Text = "Stad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 111);
            label3.Name = "label3";
            label3.Size = new Size(184, 36);
            label3.TabIndex = 8;
            label3.Text = "Gatu Nummer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(160, 36);
            label2.TabIndex = 7;
            label2.Text = "Gatu Adress:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 36);
            label1.TabIndex = 6;
            label1.Text = "Namn:";
            // 
            // Email
            // 
            Email.FormattingEnabled = true;
            Email.ItemHeight = 36;
            Email.Location = new Point(235, 245);
            Email.Name = "Email";
            Email.Size = new Size(439, 40);
            Email.TabIndex = 5;
            // 
            // PhoneNumber
            // 
            PhoneNumber.FormattingEnabled = true;
            PhoneNumber.ItemHeight = 36;
            PhoneNumber.Location = new Point(235, 199);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(439, 40);
            PhoneNumber.TabIndex = 4;
            // 
            // City
            // 
            City.FormattingEnabled = true;
            City.ItemHeight = 36;
            City.Location = new Point(235, 153);
            City.Name = "City";
            City.Size = new Size(439, 40);
            City.TabIndex = 3;
            // 
            // StreatNumber
            // 
            StreatNumber.FormattingEnabled = true;
            StreatNumber.ItemHeight = 36;
            StreatNumber.Location = new Point(235, 107);
            StreatNumber.Name = "StreatNumber";
            StreatNumber.Size = new Size(439, 40);
            StreatNumber.TabIndex = 2;
            // 
            // StreatName
            // 
            StreatName.FormattingEnabled = true;
            StreatName.ItemHeight = 36;
            StreatName.Location = new Point(235, 61);
            StreatName.Name = "StreatName";
            StreatName.Size = new Size(439, 40);
            StreatName.TabIndex = 1;
            // 
            // PersonName
            // 
            PersonName.FormattingEnabled = true;
            PersonName.ItemHeight = 36;
            PersonName.Location = new Point(235, 15);
            PersonName.Name = "PersonName";
            PersonName.Size = new Size(439, 40);
            PersonName.TabIndex = 0;
            // 
            // MainForm
            // 
            ClientSize = new Size(1593, 1066);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 11F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddressBook";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);


        }
        private DataGridView dataGridView1;
        private Button AddButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox Email;
        private ListBox PhoneNumber;
        private ListBox City;
        private ListBox StreatNumber;
        private ListBox StreatName;
        private ListBox PersonName;
        private Button SearchButton;
    }
}
