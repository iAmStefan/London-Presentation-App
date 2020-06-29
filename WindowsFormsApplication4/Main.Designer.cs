namespace WindowsFormsApplication4
{
    partial class Main
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
            this.attractions = new System.Windows.Forms.Button();
            this.touristicGuide = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.photoGallery = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attractions
            // 
            this.attractions.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attractions.Location = new System.Drawing.Point(12, 389);
            this.attractions.Name = "attractions";
            this.attractions.Size = new System.Drawing.Size(115, 40);
            this.attractions.TabIndex = 0;
            this.attractions.Text = "Atractii Turisitce";
            this.attractions.UseVisualStyleBackColor = true;
            this.attractions.Click += new System.EventHandler(this.attractions_Click);
            // 
            // touristicGuide
            // 
            this.touristicGuide.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touristicGuide.Location = new System.Drawing.Point(743, 389);
            this.touristicGuide.Name = "touristicGuide";
            this.touristicGuide.Size = new System.Drawing.Size(115, 40);
            this.touristicGuide.TabIndex = 1;
            this.touristicGuide.Text = "Ghid Turistic";
            this.touristicGuide.UseVisualStyleBackColor = true;
            this.touristicGuide.Click += new System.EventHandler(this.touristicGuide_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(239, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(409, 57);
            this.title.TabIndex = 2;
            this.title.Text = "Londra - Ghid Turistic\r\n";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.BackColor = System.Drawing.Color.Transparent;
            this.author.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.author.Location = new System.Drawing.Point(272, 66);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(325, 39);
            this.author.TabIndex = 3;
            this.author.Text = "Autor: Patrascu Alexandru";
            // 
            // photoGallery
            // 
            this.photoGallery.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoGallery.Location = new System.Drawing.Point(390, 389);
            this.photoGallery.Name = "photoGallery";
            this.photoGallery.Size = new System.Drawing.Size(115, 40);
            this.photoGallery.TabIndex = 5;
            this.photoGallery.Text = "Galerie Foto";
            this.photoGallery.UseVisualStyleBackColor = true;
            this.photoGallery.Click += new System.EventHandler(this.photoGallery_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(865, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 6;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.Location = new System.Drawing.Point(232, 115);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(416, 28);
            this.teacher.TabIndex = 8;
            this.teacher.Text = "Profesor coordonator: Cretescu Rodica-Angelica";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 461);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.close);
            this.Controls.Add(this.photoGallery);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.touristicGuide);
            this.Controls.Add(this.attractions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Londra - Ghid Turistic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attractions;
        private System.Windows.Forms.Button touristicGuide;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Button photoGallery;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label teacher;
    }
}

