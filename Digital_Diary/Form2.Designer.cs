namespace Digital_Diary
{
    partial class Form2
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
            this.SignUpGroupBox = new System.Windows.Forms.GroupBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BloodGroupLabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SignUpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignUpGroupBox
            // 
            this.SignUpGroupBox.Controls.Add(this.SignUpButton);
            this.SignUpGroupBox.Controls.Add(this.checkBox1);
            this.SignUpGroupBox.Controls.Add(this.comboBox1);
            this.SignUpGroupBox.Controls.Add(this.BloodGroupLabel);
            this.SignUpGroupBox.Controls.Add(this.radioButton2);
            this.SignUpGroupBox.Controls.Add(this.radioButton1);
            this.SignUpGroupBox.Controls.Add(this.GenderLabel);
            this.SignUpGroupBox.Controls.Add(this.dateTimePicker1);
            this.SignUpGroupBox.Controls.Add(this.DateOfBirthLabel);
            this.SignUpGroupBox.Controls.Add(this.EmailTextBox);
            this.SignUpGroupBox.Controls.Add(this.EmailLabel);
            this.SignUpGroupBox.Controls.Add(this.ConfirmPasswordTextBox);
            this.SignUpGroupBox.Controls.Add(this.ConfirmPasswordLabel);
            this.SignUpGroupBox.Controls.Add(this.PasswordTextBox);
            this.SignUpGroupBox.Controls.Add(this.PasswordLabel);
            this.SignUpGroupBox.Controls.Add(this.NameTextBox);
            this.SignUpGroupBox.Controls.Add(this.NameLabel);
            this.SignUpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpGroupBox.Location = new System.Drawing.Point(27, 12);
            this.SignUpGroupBox.Name = "SignUpGroupBox";
            this.SignUpGroupBox.Size = new System.Drawing.Size(734, 418);
            this.SignUpGroupBox.TabIndex = 0;
            this.SignUpGroupBox.TabStop = false;
            this.SignUpGroupBox.Text = "SIGN UP";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(432, 370);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(107, 40);
            this.SignUpButton.TabIndex = 16;
            this.SignUpButton.Text = "SIGN UP";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(34, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(337, 24);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "I agree to all the terms and conditions.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-"});
            this.comboBox1.Location = new System.Drawing.Point(188, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 14;
            // 
            // BloodGroupLabel
            // 
            this.BloodGroupLabel.AutoSize = true;
            this.BloodGroupLabel.Location = new System.Drawing.Point(30, 323);
            this.BloodGroupLabel.Name = "BloodGroupLabel";
            this.BloodGroupLabel.Size = new System.Drawing.Size(110, 20);
            this.BloodGroupLabel.TabIndex = 13;
            this.BloodGroupLabel.Text = "Blood Group";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(291, 286);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 24);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(172, 286);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 24);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(71, 284);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(69, 20);
            this.GenderLabel.TabIndex = 10;
            this.GenderLabel.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 232);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(18, 238);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(112, 20);
            this.DateOfBirthLabel.TabIndex = 8;
            this.DateOfBirthLabel.Text = "Date of Birth";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(152, 193);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(188, 26);
            this.EmailTextBox.TabIndex = 7;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(75, 199);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(53, 20);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(152, 148);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(188, 26);
            this.ConfirmPasswordTextBox.TabIndex = 5;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(-4, 154);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(153, 20);
            this.ConfirmPasswordLabel.TabIndex = 4;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(153, 105);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(188, 26);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(44, 111);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(153, 68);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(188, 26);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(75, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpGroupBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.SignUpGroupBox.ResumeLayout(false);
            this.SignUpGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SignUpGroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label BloodGroupLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}