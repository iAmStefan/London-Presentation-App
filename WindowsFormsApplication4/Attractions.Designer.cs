namespace WindowsFormsApplication4
{
    partial class Attractions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attractions));
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.informatii = new AxAcroPDFLib.AxAcroPDF();
            this.visitingTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.informatii)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(846, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(806, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 5;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // informatii
            // 
            this.informatii.Enabled = true;
            this.informatii.Location = new System.Drawing.Point(339, 199);
            this.informatii.Name = "informatii";
            this.informatii.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("informatii.OcxState")));
            this.informatii.Size = new System.Drawing.Size(192, 192);
            this.informatii.TabIndex = 25;
            this.informatii.Visible = false;
            // 
            // visitingTime
            // 
            this.visitingTime.AutoSize = true;
            this.visitingTime.Location = new System.Drawing.Point(420, 570);
            this.visitingTime.Name = "visitingTime";
            this.visitingTime.Size = new System.Drawing.Size(0, 13);
            this.visitingTime.TabIndex = 26;
            // 
            // Attractions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 600);
            this.Controls.Add(this.visitingTime);
            this.Controls.Add(this.informatii);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attractions";
            this.Text = "Londra - Ghid Turistic";
            this.Load += new System.EventHandler(this.Attractions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informatii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private AxAcroPDFLib.AxAcroPDF informatii;
        private System.Windows.Forms.Label visitingTime;
    }
}