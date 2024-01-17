namespace WindowsFormsApplication1
{
    partial class frmLecturer
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
            this.grbLecturerInformation = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtLecturerName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.cbxPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbEditLecturer = new System.Windows.Forms.GroupBox();
            this.lblLD = new System.Windows.Forms.Label();
            this.txtLD = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbLecturerInformation.SuspendLayout();
            this.grbGender.SuspendLayout();
            this.grbEditLecturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLecturerInformation
            // 
            this.grbLecturerInformation.Controls.Add(this.btnClose);
            this.grbLecturerInformation.Controls.Add(this.txtPhoneNumber);
            this.grbLecturerInformation.Controls.Add(this.txtEmailAddress);
            this.grbLecturerInformation.Controls.Add(this.label6);
            this.grbLecturerInformation.Controls.Add(this.label4);
            this.grbLecturerInformation.Controls.Add(this.grbGender);
            this.grbLecturerInformation.Controls.Add(this.btnUpdate);
            this.grbLecturerInformation.Controls.Add(this.btnSave);
            this.grbLecturerInformation.Controls.Add(this.txtLecturerName);
            this.grbLecturerInformation.Controls.Add(this.txtLecturerID);
            this.grbLecturerInformation.Controls.Add(this.txtQualification);
            this.grbLecturerInformation.Controls.Add(this.cbxPosition);
            this.grbLecturerInformation.Controls.Add(this.label5);
            this.grbLecturerInformation.Controls.Add(this.label3);
            this.grbLecturerInformation.Controls.Add(this.label2);
            this.grbLecturerInformation.Controls.Add(this.label1);
            this.grbLecturerInformation.Location = new System.Drawing.Point(12, 12);
            this.grbLecturerInformation.Name = "grbLecturerInformation";
            this.grbLecturerInformation.Size = new System.Drawing.Size(523, 565);
            this.grbLecturerInformation.TabIndex = 0;
            this.grbLecturerInformation.TabStop = false;
            this.grbLecturerInformation.Text = "Lecturer Information";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(256, 385);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(145, 22);
            this.txtPhoneNumber.TabIndex = 17;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(256, 326);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(145, 22);
            this.txtEmailAddress.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email Address";
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdoFemale);
            this.grbGender.Controls.Add(this.rdoMale);
            this.grbGender.Location = new System.Drawing.Point(18, 232);
            this.grbGender.Name = "grbGender";
            this.grbGender.Size = new System.Drawing.Size(397, 54);
            this.grbGender.TabIndex = 13;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(308, 21);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(75, 21);
            this.rdoFemale.TabIndex = 14;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(238, 21);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(59, 21);
            this.rdoMale.TabIndex = 14;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 464);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 58);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 58);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.Location = new System.Drawing.Point(256, 76);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.Size = new System.Drawing.Size(145, 22);
            this.txtLecturerName.TabIndex = 9;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(256, 31);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(145, 22);
            this.txtLecturerID.TabIndex = 8;
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(256, 127);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(145, 22);
            this.txtQualification.TabIndex = 7;
            // 
            // cbxPosition
            // 
            this.cbxPosition.FormattingEnabled = true;
            this.cbxPosition.Items.AddRange(new object[] {
            "Principle",
            "Training Manager",
            "Senior Lecturer",
            "Junior Lecturer",
            "Instructor"});
            this.cbxPosition.Location = new System.Drawing.Point(256, 178);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Size = new System.Drawing.Size(145, 24);
            this.cbxPosition.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lecturer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qualification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer Name";
            // 
            // grbEditLecturer
            // 
            this.grbEditLecturer.Controls.Add(this.lblLD);
            this.grbEditLecturer.Controls.Add(this.txtLD);
            this.grbEditLecturer.Controls.Add(this.btnEdit);
            this.grbEditLecturer.Location = new System.Drawing.Point(595, 338);
            this.grbEditLecturer.Name = "grbEditLecturer";
            this.grbEditLecturer.Size = new System.Drawing.Size(523, 239);
            this.grbEditLecturer.TabIndex = 1;
            this.grbEditLecturer.TabStop = false;
            this.grbEditLecturer.Text = "Edit Lecturer";
            // 
            // lblLD
            // 
            this.lblLD.AutoSize = true;
            this.lblLD.Location = new System.Drawing.Point(19, 59);
            this.lblLD.Name = "lblLD";
            this.lblLD.Size = new System.Drawing.Size(78, 17);
            this.lblLD.TabIndex = 2;
            this.lblLD.Text = "Lecturer ID";
            // 
            // txtLD
            // 
            this.txtLD.Location = new System.Drawing.Point(260, 59);
            this.txtLD.Name = "txtLD";
            this.txtLD.Size = new System.Drawing.Size(145, 22);
            this.txtLD.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(260, 138);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 58);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(315, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 58);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 622);
            this.Controls.Add(this.grbEditLecturer);
            this.Controls.Add(this.grbLecturerInformation);
            this.Name = "frmLecturer";
            this.Text = "Lecturer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbLecturerInformation.ResumeLayout(false);
            this.grbLecturerInformation.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.grbEditLecturer.ResumeLayout(false);
            this.grbEditLecturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLecturerInformation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPosition;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLecturerName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.GroupBox grbEditLecturer;
        private System.Windows.Forms.Label lblLD;
        private System.Windows.Forms.TextBox txtLD;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
    }
}