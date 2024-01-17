namespace WindowsFormsApplication1
{
    partial class frmSubjects
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
            this.gbxSubjectDetailInformation = new System.Windows.Forms.GroupBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtTopics = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.cbxCourseName = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblTopics = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxSubjectDetailInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSubjectDetailInformation
            // 
            this.gbxSubjectDetailInformation.Controls.Add(this.txtSubjectName);
            this.gbxSubjectDetailInformation.Controls.Add(this.txtTopics);
            this.gbxSubjectDetailInformation.Controls.Add(this.txtDuration);
            this.gbxSubjectDetailInformation.Controls.Add(this.cbxCourseName);
            this.gbxSubjectDetailInformation.Controls.Add(this.lblCourseName);
            this.gbxSubjectDetailInformation.Controls.Add(this.lblSubjectName);
            this.gbxSubjectDetailInformation.Controls.Add(this.lblDuration);
            this.gbxSubjectDetailInformation.Controls.Add(this.lblTopics);
            this.gbxSubjectDetailInformation.Location = new System.Drawing.Point(12, 12);
            this.gbxSubjectDetailInformation.Name = "gbxSubjectDetailInformation";
            this.gbxSubjectDetailInformation.Size = new System.Drawing.Size(511, 342);
            this.gbxSubjectDetailInformation.TabIndex = 0;
            this.gbxSubjectDetailInformation.TabStop = false;
            this.gbxSubjectDetailInformation.Text = "Subjects Detail Information";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(261, 130);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(205, 22);
            this.txtSubjectName.TabIndex = 9;
            // 
            // txtTopics
            // 
            this.txtTopics.Location = new System.Drawing.Point(261, 282);
            this.txtTopics.Name = "txtTopics";
            this.txtTopics.Size = new System.Drawing.Size(205, 22);
            this.txtTopics.TabIndex = 8;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(261, 198);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(205, 22);
            this.txtDuration.TabIndex = 7;
            // 
            // cbxCourseName
            // 
            this.cbxCourseName.FormattingEnabled = true;
            this.cbxCourseName.Items.AddRange(new object[] {
            "L3DC",
            "L4DC",
            "L4DC BM",
            "L5DC",
            "L5DC BM",
            "BSc (Hons) Computing Degree"});
            this.cbxCourseName.Location = new System.Drawing.Point(261, 61);
            this.cbxCourseName.Name = "cbxCourseName";
            this.cbxCourseName.Size = new System.Drawing.Size(205, 24);
            this.cbxCourseName.TabIndex = 5;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(32, 61);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(90, 17);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "CourseName";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(32, 130);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(96, 17);
            this.lblSubjectName.TabIndex = 2;
            this.lblSubjectName.Text = "Subject Name";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(32, 203);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(62, 17);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration";
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.Location = new System.Drawing.Point(32, 287);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(50, 17);
            this.lblTopics.TabIndex = 4;
            this.lblTopics.Text = "Topics";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(12, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(381, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 52);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "C&lose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 52);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 52);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 541);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxSubjectDetailInformation);
            this.Name = "frmSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxSubjectDetailInformation.ResumeLayout(false);
            this.gbxSubjectDetailInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSubjectDetailInformation;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.ComboBox cbxCourseName;
        private System.Windows.Forms.TextBox txtTopics;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSubjectName;
    }
}