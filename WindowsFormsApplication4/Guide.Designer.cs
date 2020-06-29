namespace WindowsFormsApplication4
{
    partial class Guide
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
            this.oneDay = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.threeDays = new System.Windows.Forms.Button();
            this.twoDays = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oneDay
            // 
            this.oneDay.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneDay.Location = new System.Drawing.Point(80, 132);
            this.oneDay.Name = "oneDay";
            this.oneDay.Size = new System.Drawing.Size(140, 40);
            this.oneDay.TabIndex = 0;
            this.oneDay.Text = "Pentru o zi";
            this.oneDay.UseVisualStyleBackColor = true;
            this.oneDay.Click += new System.EventHandler(this.oneDay_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(13, 63);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(271, 42);
            this.title.TabIndex = 4;
            this.title.Text = "Ghiduri Turistice";
            // 
            // threeDays
            // 
            this.threeDays.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeDays.Location = new System.Drawing.Point(80, 397);
            this.threeDays.Name = "threeDays";
            this.threeDays.Size = new System.Drawing.Size(140, 40);
            this.threeDays.TabIndex = 5;
            this.threeDays.Text = "Pentru 3 zile";
            this.threeDays.UseVisualStyleBackColor = true;
            this.threeDays.Click += new System.EventHandler(this.threeDays_Click);
            // 
            // twoDays
            // 
            this.twoDays.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoDays.Location = new System.Drawing.Point(80, 261);
            this.twoDays.Name = "twoDays";
            this.twoDays.Size = new System.Drawing.Size(140, 40);
            this.twoDays.TabIndex = 6;
            this.twoDays.Text = "Pentru 2 zile";
            this.twoDays.UseVisualStyleBackColor = true;
            this.twoDays.Click += new System.EventHandler(this.twoDays_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(918, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(882, -1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 10;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 570);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.twoDays);
            this.Controls.Add(this.threeDays);
            this.Controls.Add(this.title);
            this.Controls.Add(this.oneDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guide";
            this.Text = "Londra - Ghid Turistic";
            this.Load += new System.EventHandler(this.Guide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oneDay;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button threeDays;
        private System.Windows.Forms.Button twoDays;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
    }
}