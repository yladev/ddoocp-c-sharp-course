namespace WindowsFormsApplication1
{
    partial class frmCourse
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
            this.gbxCourseDetailInfo = new System.Windows.Forms.GroupBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxCourseDetailInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourseDetailInfo
            // 
            this.gbxCourseDetailInfo.Controls.Add(this.txtDuration);
            this.gbxCourseDetailInfo.Controls.Add(this.txtFees);
            this.gbxCourseDetailInfo.Controls.Add(this.txtCourseName);
            this.gbxCourseDetailInfo.Controls.Add(this.txtCourseID);
            this.gbxCourseDetailInfo.Controls.Add(this.lblDuration);
            this.gbxCourseDetailInfo.Controls.Add(this.lblFees);
            this.gbxCourseDetailInfo.Controls.Add(this.lblCourseName);
            this.gbxCourseDetailInfo.Controls.Add(this.lblCourseID);
            this.gbxCourseDetailInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxCourseDetailInfo.Name = "gbxCourseDetailInfo";
            this.gbxCourseDetailInfo.Size = new System.Drawing.Size(446, 293);
            this.gbxCourseDetailInfo.TabIndex = 2;
            this.gbxCourseDetailInfo.TabStop = false;
            this.gbxCourseDetailInfo.Text = "Course Detail Info";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(19, 52);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(70, 17);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "Course ID";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(19, 108);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(94, 17);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(19, 161);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(39, 17);
            this.lblFees.TabIndex = 2;
            this.lblFees.Text = "Fees";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(19, 223);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(62, 17);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(193, 52);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(209, 22);
            this.txtCourseID.TabIndex = 4;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(193, 105);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(209, 22);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(193, 161);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(209, 22);
            this.txtFees.TabIndex = 6;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(193, 223);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(209, 22);
            this.txtDuration.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Location = new System.Drawing.Point(12, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(22, 26);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 54);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(175, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(327, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 474);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxCourseDetailInfo);
            this.Name = "frmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbxCourseDetailInfo.ResumeLayout(false);
            this.gbxCourseDetailInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourseDetailInfo;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}