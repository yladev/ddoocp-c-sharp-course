namespace WindowsFormsApplication1
{
    partial class NumberIncrement
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
            this.lblDis = new System.Windows.Forms.Label();
            this.btnDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDis
            // 
            this.lblDis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDis.Location = new System.Drawing.Point(307, 33);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(329, 467);
            this.lblDis.TabIndex = 0;
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(444, 530);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(75, 46);
            this.btnDis.TabIndex = 1;
            this.btnDis.Text = "Display";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // NumberIncrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 619);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.lblDis);
            this.Name = "NumberIncrement";
            this.Text = "NumberIncrement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Button btnDis;
    }
}