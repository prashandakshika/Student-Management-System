
namespace Student_Management_System
{
    partial class registrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
            this.lblRegFormTheme = new System.Windows.Forms.Label();
            this.gbStdDetails = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.datetimepickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbContactDetails = new System.Windows.Forms.GroupBox();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.txtProvince = new System.Windows.Forms.ComboBox();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNO = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblContactNO = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.lnkLogOut = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegclear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRegExit = new System.Windows.Forms.LinkLabel();
            this.lblStdID = new System.Windows.Forms.Label();
            this.combStdID = new System.Windows.Forms.ComboBox();
            this.gbFullRegForm = new System.Windows.Forms.GroupBox();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.gbStdDetails.SuspendLayout();
            this.gbContactDetails.SuspendLayout();
            this.gbParentDetails.SuspendLayout();
            this.gbFullRegForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegFormTheme
            // 
            this.lblRegFormTheme.AutoSize = true;
            this.lblRegFormTheme.Font = new System.Drawing.Font("Play", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegFormTheme.ForeColor = System.Drawing.Color.White;
            this.lblRegFormTheme.Location = new System.Drawing.Point(339, 15);
            this.lblRegFormTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegFormTheme.Name = "lblRegFormTheme";
            this.lblRegFormTheme.Size = new System.Drawing.Size(430, 62);
            this.lblRegFormTheme.TabIndex = 0;
            this.lblRegFormTheme.Text = "Skills International";
            // 
            // gbStdDetails
            // 
            this.gbStdDetails.Controls.Add(this.rbtnFemale);
            this.gbStdDetails.Controls.Add(this.rbtnMale);
            this.gbStdDetails.Controls.Add(this.datetimepickerDOB);
            this.gbStdDetails.Controls.Add(this.txtLastName);
            this.gbStdDetails.Controls.Add(this.txtFirstName);
            this.gbStdDetails.Controls.Add(this.lblGender);
            this.gbStdDetails.Controls.Add(this.lblDOB);
            this.gbStdDetails.Controls.Add(this.lblLastName);
            this.gbStdDetails.Controls.Add(this.lblFirstName);
            this.gbStdDetails.Font = new System.Drawing.Font("Play", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStdDetails.ForeColor = System.Drawing.Color.White;
            this.gbStdDetails.Location = new System.Drawing.Point(22, 102);
            this.gbStdDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbStdDetails.Name = "gbStdDetails";
            this.gbStdDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbStdDetails.Size = new System.Drawing.Size(939, 180);
            this.gbStdDetails.TabIndex = 1;
            this.gbStdDetails.TabStop = false;
            this.gbStdDetails.Text = "Basic Details";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(310, 140);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(99, 31);
            this.rbtnFemale.TabIndex = 8;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(216, 140);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(75, 31);
            this.rbtnMale.TabIndex = 7;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // datetimepickerDOB
            // 
            this.datetimepickerDOB.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepickerDOB.Location = new System.Drawing.Point(217, 104);
            this.datetimepickerDOB.Margin = new System.Windows.Forms.Padding(2);
            this.datetimepickerDOB.Name = "datetimepickerDOB";
            this.datetimepickerDOB.Size = new System.Drawing.Size(400, 32);
            this.datetimepickerDOB.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(217, 68);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(700, 32);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(217, 32);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(700, 32);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(23, 142);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 27);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(22, 109);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(133, 27);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(22, 71);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(113, 27);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(22, 35);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(115, 27);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // gbContactDetails
            // 
            this.gbContactDetails.Controls.Add(this.txtCity);
            this.gbContactDetails.Controls.Add(this.txtProvince);
            this.gbContactDetails.Controls.Add(this.txtHP);
            this.gbContactDetails.Controls.Add(this.txtMP);
            this.gbContactDetails.Controls.Add(this.txtEmail);
            this.gbContactDetails.Controls.Add(this.txtAddress);
            this.gbContactDetails.Controls.Add(this.lblProvince);
            this.gbContactDetails.Controls.Add(this.lblDistrict);
            this.gbContactDetails.Controls.Add(this.lblHP);
            this.gbContactDetails.Controls.Add(this.lblMP);
            this.gbContactDetails.Controls.Add(this.lblEmail);
            this.gbContactDetails.Controls.Add(this.lblAddress);
            this.gbContactDetails.Font = new System.Drawing.Font("Play", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactDetails.ForeColor = System.Drawing.Color.White;
            this.gbContactDetails.Location = new System.Drawing.Point(22, 299);
            this.gbContactDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbContactDetails.Name = "gbContactDetails";
            this.gbContactDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbContactDetails.Size = new System.Drawing.Size(939, 231);
            this.gbContactDetails.TabIndex = 2;
            this.gbContactDetails.TabStop = false;
            this.gbContactDetails.Text = "Contact Details";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Items.AddRange(new object[] {
            "Ampara",
            "Anuradhapura",
            "Badulla",
            "Batticaloa",
            "Colombo",
            "Galle",
            "Gampaha",
            "Hambantota",
            "Jaffna",
            "Kaluthara",
            "Kandy",
            "Kegalle",
            "Kilinochchi",
            "Kurunegala",
            "Mannar",
            "Matale",
            "Matara",
            "Monaragala",
            "Mullaitivu",
            "Nuwara Eliya",
            "Polonnaruwa",
            "Puttalam",
            "Rathnapura",
            "Trincomalee",
            "Vavuniya"});
            this.txtCity.Location = new System.Drawing.Point(217, 182);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(263, 35);
            this.txtCity.Sorted = true;
            this.txtCity.TabIndex = 12;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.FormattingEnabled = true;
            this.txtProvince.Items.AddRange(new object[] {
            "Central",
            "Eastern",
            "North Central",
            "North Western",
            "Nothern",
            "Sabaragamuwa",
            "Southern",
            "Uva",
            "Western"});
            this.txtProvince.Location = new System.Drawing.Point(653, 182);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(2);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(263, 35);
            this.txtProvince.Sorted = true;
            this.txtProvince.TabIndex = 12;
            // 
            // txtHP
            // 
            this.txtHP.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHP.Location = new System.Drawing.Point(653, 146);
            this.txtHP.Margin = new System.Windows.Forms.Padding(2);
            this.txtHP.MaxLength = 10;
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(264, 32);
            this.txtHP.TabIndex = 9;
            this.txtHP.TextChanged += new System.EventHandler(this.txtHP_TextChanged);
            // 
            // txtMP
            // 
            this.txtMP.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP.Location = new System.Drawing.Point(217, 146);
            this.txtMP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMP.MaxLength = 10;
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(264, 32);
            this.txtMP.TabIndex = 8;
            this.txtMP.TextChanged += new System.EventHandler(this.txtMP_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(217, 110);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(700, 32);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(217, 31);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(700, 75);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(500, 185);
            this.lblProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(91, 27);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(22, 185);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(79, 27);
            this.lblDistrict.TabIndex = 4;
            this.lblDistrict.Text = "District";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.Location = new System.Drawing.Point(500, 149);
            this.lblHP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(133, 27);
            this.lblHP.TabIndex = 3;
            this.lblHP.Text = "Home Phone";
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMP.Location = new System.Drawing.Point(23, 149);
            this.lblMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(139, 27);
            this.lblMP.TabIndex = 2;
            this.lblMP.Text = "Mobile Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(22, 113);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 27);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(25, 41);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 27);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // gbParentDetails
            // 
            this.gbParentDetails.Controls.Add(this.txtContactNO);
            this.gbParentDetails.Controls.Add(this.txtNIC);
            this.gbParentDetails.Controls.Add(this.txtParentName);
            this.gbParentDetails.Controls.Add(this.lblContactNO);
            this.gbParentDetails.Controls.Add(this.lblNIC);
            this.gbParentDetails.Controls.Add(this.lblParentName);
            this.gbParentDetails.Font = new System.Drawing.Font("Play", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParentDetails.ForeColor = System.Drawing.Color.White;
            this.gbParentDetails.Location = new System.Drawing.Point(22, 545);
            this.gbParentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbParentDetails.Name = "gbParentDetails";
            this.gbParentDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbParentDetails.Size = new System.Drawing.Size(939, 157);
            this.gbParentDetails.TabIndex = 3;
            this.gbParentDetails.TabStop = false;
            this.gbParentDetails.Text = "Parent Details";
            // 
            // txtContactNO
            // 
            this.txtContactNO.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNO.Location = new System.Drawing.Point(216, 111);
            this.txtContactNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactNO.MaxLength = 10;
            this.txtContactNO.Name = "txtContactNO";
            this.txtContactNO.Size = new System.Drawing.Size(263, 32);
            this.txtContactNO.TabIndex = 5;
            this.txtContactNO.TextChanged += new System.EventHandler(this.txtContactNO_TextChanged);
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(216, 75);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNIC.MaxLength = 12;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(264, 32);
            this.txtNIC.TabIndex = 4;
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentName.Location = new System.Drawing.Point(216, 39);
            this.txtParentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(699, 32);
            this.txtParentName.TabIndex = 3;
            // 
            // lblContactNO
            // 
            this.lblContactNO.AutoSize = true;
            this.lblContactNO.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNO.Location = new System.Drawing.Point(24, 114);
            this.lblContactNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNO.Name = "lblContactNO";
            this.lblContactNO.Size = new System.Drawing.Size(166, 27);
            this.lblContactNO.TabIndex = 2;
            this.lblContactNO.Text = "Contact Number";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.Location = new System.Drawing.Point(24, 78);
            this.lblNIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(45, 27);
            this.lblNIC.TabIndex = 1;
            this.lblNIC.Text = "NIC";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentName.Location = new System.Drawing.Point(23, 42);
            this.lblParentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(134, 27);
            this.lblParentName.TabIndex = 0;
            this.lblParentName.Text = "Parent Name";
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.AutoSize = true;
            this.lnkLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkLogOut.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLogOut.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lnkLogOut.Location = new System.Drawing.Point(15, 896);
            this.lnkLogOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(88, 27);
            this.lnkLogOut.TabIndex = 4;
            this.lnkLogOut.TabStop = true;
            this.lnkLogOut.Text = "Log out";
            this.lnkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogOut_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(22, 723);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 37);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(189, 723);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 37);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegclear
            // 
            this.btnRegclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegclear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegclear.FlatAppearance.BorderSize = 2;
            this.btnRegclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegclear.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegclear.ForeColor = System.Drawing.Color.White;
            this.btnRegclear.Location = new System.Drawing.Point(642, 723);
            this.btnRegclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegclear.Name = "btnRegclear";
            this.btnRegclear.Size = new System.Drawing.Size(149, 37);
            this.btnRegclear.TabIndex = 7;
            this.btnRegclear.Text = "Clear";
            this.btnRegclear.UseVisualStyleBackColor = true;
            this.btnRegclear.Click += new System.EventHandler(this.btnRegclear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(812, 723);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRegExit
            // 
            this.btnRegExit.AutoSize = true;
            this.btnRegExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegExit.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegExit.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegExit.Location = new System.Drawing.Point(954, 896);
            this.btnRegExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnRegExit.Name = "btnRegExit";
            this.btnRegExit.Size = new System.Drawing.Size(52, 27);
            this.btnRegExit.TabIndex = 9;
            this.btnRegExit.TabStop = true;
            this.btnRegExit.Text = "Exit";
            this.btnRegExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnRegExit_LinkClicked);
            // 
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdID.ForeColor = System.Drawing.Color.White;
            this.lblStdID.Location = new System.Drawing.Point(47, 56);
            this.lblStdID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(112, 27);
            this.lblStdID.TabIndex = 10;
            this.lblStdID.Text = "Student ID";
            // 
            // combStdID
            // 
            this.combStdID.Font = new System.Drawing.Font("Play", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combStdID.FormattingEnabled = true;
            this.combStdID.Location = new System.Drawing.Point(239, 53);
            this.combStdID.Margin = new System.Windows.Forms.Padding(2);
            this.combStdID.Name = "combStdID";
            this.combStdID.Size = new System.Drawing.Size(263, 35);
            this.combStdID.TabIndex = 11;
            this.combStdID.SelectedIndexChanged += new System.EventHandler(this.combStdID_SelectedIndexChanged);
            // 
            // gbFullRegForm
            // 
            this.gbFullRegForm.Controls.Add(this.combStdID);
            this.gbFullRegForm.Controls.Add(this.lblStdID);
            this.gbFullRegForm.Controls.Add(this.btnDelete);
            this.gbFullRegForm.Controls.Add(this.btnRegclear);
            this.gbFullRegForm.Controls.Add(this.btnUpdate);
            this.gbFullRegForm.Controls.Add(this.btnRegister);
            this.gbFullRegForm.Controls.Add(this.gbParentDetails);
            this.gbFullRegForm.Controls.Add(this.gbContactDetails);
            this.gbFullRegForm.Controls.Add(this.gbStdDetails);
            this.gbFullRegForm.Font = new System.Drawing.Font("Play", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFullRegForm.ForeColor = System.Drawing.Color.White;
            this.gbFullRegForm.Location = new System.Drawing.Point(20, 95);
            this.gbFullRegForm.Margin = new System.Windows.Forms.Padding(2);
            this.gbFullRegForm.Name = "gbFullRegForm";
            this.gbFullRegForm.Padding = new System.Windows.Forms.Padding(2);
            this.gbFullRegForm.Size = new System.Drawing.Size(986, 783);
            this.gbFullRegForm.TabIndex = 12;
            this.gbFullRegForm.TabStop = false;
            this.gbFullRegForm.Text = "Student Registration";
            // 
            // picboxLogo
            // 
            this.picboxLogo.Image = global::Student_Management_System.Properties.Resources.SystemMS_Prashan;
            this.picboxLogo.Location = new System.Drawing.Point(261, 15);
            this.picboxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(74, 62);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 13;
            this.picboxLogo.TabStop = false;
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(45)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(1028, 933);
            this.Controls.Add(this.picboxLogo);
            this.Controls.Add(this.gbFullRegForm);
            this.Controls.Add(this.btnRegExit);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.lblRegFormTheme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.registrationForm_Load);
            this.gbStdDetails.ResumeLayout(false);
            this.gbStdDetails.PerformLayout();
            this.gbContactDetails.ResumeLayout(false);
            this.gbContactDetails.PerformLayout();
            this.gbParentDetails.ResumeLayout(false);
            this.gbParentDetails.PerformLayout();
            this.gbFullRegForm.ResumeLayout(false);
            this.gbFullRegForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegFormTheme;
        private System.Windows.Forms.GroupBox gbStdDetails;
        private System.Windows.Forms.GroupBox gbContactDetails;
        private System.Windows.Forms.GroupBox gbParentDetails;
        private System.Windows.Forms.LinkLabel lnkLogOut;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegclear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel btnRegExit;
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.ComboBox combStdID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.DateTimePicker datetimepickerDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblMP;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNO;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblContactNO;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.GroupBox gbFullRegForm;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.ComboBox txtProvince;
        private System.Windows.Forms.ComboBox txtCity;
    }
}