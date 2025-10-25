namespace StudentRegistrationForm
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            IbIEmail = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblGender = new Label();
            lblColor = new Label();
            lblBirthday = new Label();
            lblCountry = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            grpGender = new GroupBox();
            rdoOther = new RadioButton();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            btnPickColor = new Button();
            lblSelectedColor = new Label();
            dtpBirthdate = new DateTimePicker();
            cmbCountry = new ComboBox();
            btnSubmit = new Button();
            btnReset = new Button();
            picStudent = new PictureBox();
            btnUpload = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            lblResult = new TextBox();
            grpGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(30, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            lblName.Click += IbIName_Click;
            // 
            // IbIEmail
            // 
            IbIEmail.Font = new Font("Segoe UI", 12F);
            IbIEmail.Location = new Point(113, 96);
            IbIEmail.Name = "IbIEmail";
            IbIEmail.Size = new Size(0, 0);
            IbIEmail.TabIndex = 8;
            IbIEmail.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(30, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 29);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(30, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 30);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password:";
            // 
            // lblGender
            // 
            lblGender.Font = new Font("Segoe UI", 12F);
            lblGender.Location = new Point(30, 150);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(83, 31);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender:";
            lblGender.Click += lblGender_Click;
            // 
            // lblColor
            // 
            lblColor.Font = new Font("Segoe UI", 12F);
            lblColor.Location = new Point(30, 190);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(115, 30);
            lblColor.TabIndex = 12;
            lblColor.Text = "Favorite Color:";
            lblColor.Click += lblColor_Click;
            // 
            // lblBirthday
            // 
            lblBirthday.Font = new Font("Segoe UI", 12F);
            lblBirthday.Location = new Point(30, 230);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(83, 30);
            lblBirthday.TabIndex = 13;
            lblBirthday.Text = "Birthdate:";
            // 
            // lblCountry
            // 
            lblCountry.Font = new Font("Segoe UI", 12F);
            lblCountry.Location = new Point(30, 270);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(122, 23);
            lblCountry.TabIndex = 14;
            lblCountry.Text = "Select Country:";
            lblCountry.Click += lblCountry_Click;
            // 
            // txtName
            // 
            txtName.AutoCompleteMode = AutoCompleteMode.Append;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(150, 30);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 25);
            txtName.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.AutoCompleteMode = AutoCompleteMode.Append;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(150, 70);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 25);
            txtEmail.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.AutoCompleteMode = AutoCompleteMode.Append;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(150, 110);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 25);
            txtPassword.TabIndex = 19;
            // 
            // grpGender
            // 
            grpGender.Controls.Add(rdoOther);
            grpGender.Controls.Add(rdoFemale);
            grpGender.Controls.Add(rdoMale);
            grpGender.Location = new Point(150, 140);
            grpGender.Name = "grpGender";
            grpGender.Size = new Size(200, 50);
            grpGender.TabIndex = 20;
            grpGender.TabStop = false;
            grpGender.Text = "Gender";
            // 
            // rdoOther
            // 
            rdoOther.AutoSize = true;
            rdoOther.Location = new Point(140, 20);
            rdoOther.Name = "rdoOther";
            rdoOther.Size = new Size(55, 19);
            rdoOther.TabIndex = 2;
            rdoOther.TabStop = true;
            rdoOther.Text = "Other";
            rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(70, 20);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(63, 19);
            rdoFemale.TabIndex = 1;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(10, 20);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(51, 19);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // btnPickColor
            // 
            btnPickColor.BackColor = SystemColors.Window;
            btnPickColor.Location = new Point(150, 190);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(130, 25);
            btnPickColor.TabIndex = 21;
            btnPickColor.Text = "Choose Color";
            btnPickColor.UseVisualStyleBackColor = false;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // lblSelectedColor
            // 
            lblSelectedColor.AutoSize = true;
            lblSelectedColor.Location = new Point(300, 190);
            lblSelectedColor.Name = "lblSelectedColor";
            lblSelectedColor.Size = new Size(102, 15);
            lblSelectedColor.TabIndex = 22;
            lblSelectedColor.Text = "No Color Selected";
            lblSelectedColor.Click += lblSelectedColor_Click;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Format = DateTimePickerFormat.Short;
            dtpBirthdate.Location = new Point(150, 230);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(200, 23);
            dtpBirthdate.TabIndex = 23;
            // 
            // cmbCountry
            // 
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(150, 270);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(154, 23);
            cmbCountry.TabIndex = 24;
            cmbCountry.SelectedIndexChanged += cmbCountry_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(150, 320);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Register";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(355, 320);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 30);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Location = new Point(400, 30);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(120, 120);
            picStudent.SizeMode = PictureBoxSizeMode.StretchImage;
            picStudent.TabIndex = 27;
            picStudent.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(400, 160);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(120, 30);
            btnUpload.TabIndex = 28;
            btnUpload.Text = "Upload Picture";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(80, 360);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save Data";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(420, 360);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 30);
            btnLoad.TabIndex = 30;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(22, 399);
            lblResult.Multiline = true;
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(550, 50);
            lblResult.TabIndex = 31;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(584, 461);
            Controls.Add(lblResult);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnUpload);
            Controls.Add(picStudent);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(cmbCountry);
            Controls.Add(dtpBirthdate);
            Controls.Add(lblSelectedColor);
            Controls.Add(btnPickColor);
            Controls.Add(grpGender);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblCountry);
            Controls.Add(lblBirthday);
            Controls.Add(lblColor);
            Controls.Add(lblGender);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(IbIEmail);
            Controls.Add(lblName);
            Name = "frmRegistration";
            Text = "Student Registration Form";
            Load += frmRegistration_Load;
            grpGender.ResumeLayout(false);
            grpGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label IbIEmail;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblGender;
        private Label lblColor;
        private Label lblBirthday;
        private Label lblCountry;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private GroupBox grpGender;
        private RadioButton rdoOther;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Button btnPickColor;
        private Label lblSelectedColor;
        private DateTimePicker dtpBirthdate;
        private ComboBox cmbCountry;
        private Button btnSubmit;
        private Button btnReset;
        private PictureBox picStudent;
        private Button btnUpload;
        private Button btnSave;
        private Button btnLoad;
        private TextBox lblResult;
    }
}
