namespace WindowsFormsApplication1
{
    partial class NumberDecrement
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
            this.lblDSL = new System.Windows.Forms.Label();
            this.btnDSL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDSL
            // 
            this.lblDSL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDSL.Location = new System.Drawing.Point(325, 28);
            this.lblDSL.Name = "lblDSL";
            this.lblDSL.Size = new System.Drawing.Size(372, 504);
            this.lblDSL.TabIndex = 0;
            // 
            // btnDSL
            // 
            this.btnDSL.Location = new System.Drawing.Point(465, 564);
            this.btnDSL.Name = "btnDSL";
            this.btnDSL.Size = new System.Drawing.Size(96, 55);
            this.btnDSL.TabIndex = 1;
            this.btnDSL.Text = "Display";
            this.btnDSL.UseVisualStyleBackColor = true;
            this.btnDSL.Click += new System.EventHandler(this.btnDSL_Click);
            // 
            // NumberDecrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 676);
            this.Controls.Add(this.btnDSL);
            this.Controls.Add(this.lblDSL);
            this.Name = "NumberDecrement";
            this.Text = "NumberDecrement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDSL;
        private System.Windows.Forms.Button btnDSL;
    }
}