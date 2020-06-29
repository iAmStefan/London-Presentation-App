namespace WindowsFormsApplication4
{
    partial class Informatii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informatii));
            this.close = new System.Windows.Forms.Label();
            this.information = new AxAcroPDFLib.AxAcroPDF();
            this.visitingTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.information)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(813, -3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // information
            // 
            this.information.Enabled = true;
            this.information.Location = new System.Drawing.Point(30, 33);
            this.information.Name = "information";
            this.information.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("information.OcxState")));
            this.information.Size = new System.Drawing.Size(775, 430);
            this.information.TabIndex = 1;
            // 
            // visitingTime
            // 
            this.visitingTime.AutoSize = true;
            this.visitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitingTime.Location = new System.Drawing.Point(313, 501);
            this.visitingTime.Name = "visitingTime";
            this.visitingTime.Size = new System.Drawing.Size(0, 18);
            this.visitingTime.TabIndex = 2;
            // 
            // Informatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 495);
            this.Controls.Add(this.visitingTime);
            this.Controls.Add(this.information);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informatii";
            this.Text = "Informatii";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Informatii_FormClosed);
            this.Load += new System.EventHandler(this.Informatii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private AxAcroPDFLib.AxAcroPDF information;
        private System.Windows.Forms.Label visitingTime;
    }
}