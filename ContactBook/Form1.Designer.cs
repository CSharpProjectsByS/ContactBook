namespace ContactBook
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContactList = new System.Windows.Forms.ListBox();
            this.NameEdit = new System.Windows.Forms.TextBox();
            this.SurnameEdit = new System.Windows.Forms.TextBox();
            this.PhoneEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NameAdd = new System.Windows.Forms.TextBox();
            this.SurnameAdd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DayOfBornEdit = new System.Windows.Forms.TextBox();
            this.MonthOfBornEdit = new System.Windows.Forms.TextBox();
            this.YearOfBornEdit = new System.Windows.Forms.TextBox();
            this.DayOfBornAdd = new System.Windows.Forms.TextBox();
            this.MonthOfBornAdd = new System.Windows.Forms.TextBox();
            this.YearOfBornAdd = new System.Windows.Forms.TextBox();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktualna Lista";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(272, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktualnie wybrany: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(577, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dodaj osobe:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ContactList
            // 
            this.ContactList.FormattingEnabled = true;
            this.ContactList.ItemHeight = 16;
            this.ContactList.Location = new System.Drawing.Point(35, 49);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(209, 212);
            this.ContactList.TabIndex = 3;
            this.ContactList.Tag = "";
            this.ContactList.Click += new System.EventHandler(this.ContactList_Click);
            // 
            // NameEdit
            // 
            this.NameEdit.Location = new System.Drawing.Point(389, 63);
            this.NameEdit.Name = "NameEdit";
            this.NameEdit.Size = new System.Drawing.Size(100, 22);
            this.NameEdit.TabIndex = 100;
            // 
            // SurnameEdit
            // 
            this.SurnameEdit.Location = new System.Drawing.Point(389, 91);
            this.SurnameEdit.Name = "SurnameEdit";
            this.SurnameEdit.Size = new System.Drawing.Size(100, 22);
            this.SurnameEdit.TabIndex = 101;
            // 
            // PhoneEdit
            // 
            this.PhoneEdit.Location = new System.Drawing.Point(389, 119);
            this.PhoneEdit.Name = "PhoneEdit";
            this.PhoneEdit.Size = new System.Drawing.Size(100, 22);
            this.PhoneEdit.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Imię";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nazwisko";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nr Telefonu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data Urodzenia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Imię";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nazwisko";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(577, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Data Urodzenia";
            // 
            // NameAdd
            // 
            this.NameAdd.Location = new System.Drawing.Point(691, 63);
            this.NameAdd.Name = "NameAdd";
            this.NameAdd.Size = new System.Drawing.Size(100, 22);
            this.NameAdd.TabIndex = 106;
            // 
            // SurnameAdd
            // 
            this.SurnameAdd.Location = new System.Drawing.Point(692, 94);
            this.SurnameAdd.Name = "SurnameAdd";
            this.SurnameAdd.Size = new System.Drawing.Size(100, 22);
            this.SurnameAdd.TabIndex = 107;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Dzień";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(329, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Miesiąć";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(329, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "Rok";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(639, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 24;
            this.label17.Text = "Dzień";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(629, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "Miesiąc";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(639, 240);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "Rok";
            // 
            // DayOfBornEdit
            // 
            this.DayOfBornEdit.Enabled = false;
            this.DayOfBornEdit.Location = new System.Drawing.Point(389, 174);
            this.DayOfBornEdit.Name = "DayOfBornEdit";
            this.DayOfBornEdit.Size = new System.Drawing.Size(100, 22);
            this.DayOfBornEdit.TabIndex = 103;
            // 
            // MonthOfBornEdit
            // 
            this.MonthOfBornEdit.Enabled = false;
            this.MonthOfBornEdit.Location = new System.Drawing.Point(390, 209);
            this.MonthOfBornEdit.Name = "MonthOfBornEdit";
            this.MonthOfBornEdit.Size = new System.Drawing.Size(100, 22);
            this.MonthOfBornEdit.TabIndex = 104;
            // 
            // YearOfBornEdit
            // 
            this.YearOfBornEdit.Enabled = false;
            this.YearOfBornEdit.Location = new System.Drawing.Point(389, 240);
            this.YearOfBornEdit.Name = "YearOfBornEdit";
            this.YearOfBornEdit.Size = new System.Drawing.Size(100, 22);
            this.YearOfBornEdit.TabIndex = 105;
            // 
            // DayOfBornAdd
            // 
            this.DayOfBornAdd.Location = new System.Drawing.Point(691, 179);
            this.DayOfBornAdd.Name = "DayOfBornAdd";
            this.DayOfBornAdd.Size = new System.Drawing.Size(100, 22);
            this.DayOfBornAdd.TabIndex = 108;
            // 
            // MonthOfBornAdd
            // 
            this.MonthOfBornAdd.Location = new System.Drawing.Point(691, 212);
            this.MonthOfBornAdd.Name = "MonthOfBornAdd";
            this.MonthOfBornAdd.Size = new System.Drawing.Size(100, 22);
            this.MonthOfBornAdd.TabIndex = 109;
            // 
            // YearOfBornAdd
            // 
            this.YearOfBornAdd.Location = new System.Drawing.Point(691, 240);
            this.YearOfBornAdd.Name = "YearOfBornAdd";
            this.YearOfBornAdd.Size = new System.Drawing.Size(101, 22);
            this.YearOfBornAdd.TabIndex = 110;
            // 
            // EditContactButton
            // 
            this.EditContactButton.Location = new System.Drawing.Point(307, 282);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(183, 45);
            this.EditContactButton.TabIndex = 33;
            this.EditContactButton.Text = "Zmień";
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Location = new System.Drawing.Point(595, 282);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(196, 45);
            this.AddContactButton.TabIndex = 34;
            this.AddContactButton.Text = "Dodaj";
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(35, 282);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(209, 45);
            this.DeleteButton.TabIndex = 111;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 354);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddContactButton);
            this.Controls.Add(this.EditContactButton);
            this.Controls.Add(this.YearOfBornAdd);
            this.Controls.Add(this.MonthOfBornAdd);
            this.Controls.Add(this.DayOfBornAdd);
            this.Controls.Add(this.YearOfBornEdit);
            this.Controls.Add(this.MonthOfBornEdit);
            this.Controls.Add(this.DayOfBornEdit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SurnameAdd);
            this.Controls.Add(this.NameAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneEdit);
            this.Controls.Add(this.SurnameEdit);
            this.Controls.Add(this.NameEdit);
            this.Controls.Add(this.ContactList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kontatky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ContactList;
        private System.Windows.Forms.TextBox NameEdit;
        private System.Windows.Forms.TextBox SurnameEdit;
        private System.Windows.Forms.TextBox PhoneEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NameAdd;
        private System.Windows.Forms.TextBox SurnameAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox DayOfBornEdit;
        private System.Windows.Forms.TextBox MonthOfBornEdit;
        private System.Windows.Forms.TextBox YearOfBornEdit;
        private System.Windows.Forms.TextBox DayOfBornAdd;
        private System.Windows.Forms.TextBox MonthOfBornAdd;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.TextBox YearOfBornAdd;
        private System.Windows.Forms.Button DeleteButton;
    }
}

