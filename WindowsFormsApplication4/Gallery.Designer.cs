namespace WindowsFormsApplication4
{
    partial class Gallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gallery));
            this.lista = new System.Windows.Forms.ListBox();
            this.imagine = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.movie = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.imagine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 30);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(160, 511);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // imagine
            // 
            this.imagine.BackColor = System.Drawing.Color.Transparent;
            this.imagine.Location = new System.Drawing.Point(198, 30);
            this.imagine.Name = "imagine";
            this.imagine.Size = new System.Drawing.Size(695, 510);
            this.imagine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagine.TabIndex = 1;
            this.imagine.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(885, -2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(850, -2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 23);
            this.back.TabIndex = 3;
            this.back.Text = "<-";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // movie
            // 
            this.movie.Enabled = true;
            this.movie.Location = new System.Drawing.Point(200, 30);
            this.movie.Name = "movie";
            this.movie.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("movie.OcxState")));
            this.movie.Size = new System.Drawing.Size(185, 170);
            this.movie.TabIndex = 4;
            this.movie.Visible = false;
            // 
            // Gallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 550);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.imagine);
            this.Controls.Add(this.lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gallery";
            this.Text = "Londra - Ghid Turistic";
            this.Load += new System.EventHandler(this.Gallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.PictureBox imagine;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label back;
        private AxWMPLib.AxWindowsMediaPlayer movie;
    }
}