using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void attractions_Click(object sender, EventArgs e)
        {
            Attractions atractii = new Attractions();
            atractii.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/londonStart.jpg");
            close.BackColor = Color.Transparent;
            teacher.BackColor = Color.Transparent;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void photoGallery_Click(object sender, EventArgs e)
        {
            Gallery gallery = new Gallery();
            gallery.Show();
            this.Hide();
        }

        private void touristicGuide_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.Show();
            this.Hide();
        }
    }
}
