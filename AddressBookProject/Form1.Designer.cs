namespace AddressBookProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // ListBox to show contacts
        private System.Windows.Forms.ListBox listBoxContacts;

        // Button to delete selected contact
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 15;
            this.listBoxContacts.Location = new System.Drawing.Point(12, 12);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(300, 199);
            this.listBoxContacts.TabIndex = 0;

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(300, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Ta bort kontakt";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(330, 270);
            this.Controls.Add(this.listBoxContacts);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.Text = "Adressbok";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
