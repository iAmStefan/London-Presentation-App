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
    public partial class Informatii : Form
    {
        public Informatii(string numeAtractie)
        {
            InitializeComponent();
            if (numeAtractie == "hmsBelfast")
            {
                information.LoadFile(@"Informatii/HMS Belfast.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/HMS Belfast/HMS Belfast 3.jpeg");
            }
            else if (numeAtractie == "madameTussauds")
            {
                information.LoadFile(@"Informatii/Madame Tussauds.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/madameTussauds/madameTussauds.jpeg");
                visitingTime.Text = "Timp de vizitare: 2 ore";
                this.Height = 530;
            }
            else if (numeAtractie == "observatory")
            {
                information.LoadFile(@"Informatii/Observatory.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/observatory/observatory 2.jpeg");
            }
            else if (numeAtractie == "globeTheater")
            {
                this.BackgroundImage = new Bitmap(@"Imagini/globeTheater/globeTheater.jpeg");
            }
            else if (numeAtractie == "theShard")
            {
                information.LoadFile(@"Informatii/The Shard.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/The Shard/theShard.jpeg");
            }
            else if (numeAtractie == "towerBridge")
            {
                information.LoadFile(@"Informatii/TowerBridge.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/towerBridge/towerBridge.jpeg");
            }
            else if (numeAtractie == "picadillyCircus")
            {
                information.LoadFile(@"Informatii/Picadilly Circus.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/picadillyCircus/picadillyCircus 2.jpeg");
            }
            else if (numeAtractie == "coventGarden")
            {
                information.LoadFile(@"Informatii/Covent Garden.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/coventGarden/coventGarden 1.jpeg");
                visitingTime.Text = "Timp de vizitare: 1 ora";
                this.Height = 530;
            }
            else if (numeAtractie == "cathedral")
            {
                information.LoadFile(@"Informatii/Catedrala Sf. Paul.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/cathedral/cathedral 3.jpeg");
            }
            else if (numeAtractie == "britishMuseum")
            {
                information.LoadFile(@"Informatii/British Museum.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/britishMuseum/britishMuseum.jpeg");
                visitingTime.Text = "Timp de vizitare: minim 3 ore";
                this.Height = 530;
            }
            else if (numeAtractie == "naturalHistory")
            {
                information.LoadFile(@"Informatii/Natural History.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/naturalHistory/naturalHistory.jpeg");
                visitingTime.Text = "Timp de vizitare: 2-3 ore";
                this.Height = 530;
            }
            else if (numeAtractie == "nationalGallery")
            {
                information.LoadFile(@"Informatii/National Gallery.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/nationalGallery/nationalGallery.jpeg");
                visitingTime.Text = "Timp de vizitare: 2-3 ore";
                this.Height = 530;
            }
            else if (numeAtractie == "londonEye")
            {
                information.LoadFile(@"Informatii/London Eye.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/londonEye/londonEye.jpeg");
            }
            else if (numeAtractie == "westminsterAbbey")
            {
                information.LoadFile(@"Informatii/Abatia Westminster.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/westminsterAbbey/westminsterAbbey.jpg");
            }
            else if (numeAtractie == "westminsterPalace")
            {
                information.LoadFile(@"Informatii/Palatul Westminster.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/westminsterPalace/westminsterPalace.jpg");
            }
            else if (numeAtractie == "victoriaMemorial")
            {
                information.LoadFile(@"Informatii/Memorialul Regina Victoria.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/memorialVictoria/memorialVictoria 3.jpeg");
            }
            else if (numeAtractie == "buckinghamPalace")
            {
                information.LoadFile(@"Informatii/Buckingham Palace.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/buckinghamPalace/buckinghamPalace.jpg");
            }
            else if (numeAtractie == "trafalgarSquare")
            {
                information.LoadFile(@"Informatii/Trafalgar Square.pdf");
                this.BackgroundImage = new Bitmap(@"Imagini/trafalgarSquare/trafalgar Square.jpg");
                visitingTime.Text = "Timp de vizitare: maximum 30 de minute";
                this.Height = 530;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Informatii_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Informatii_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            close.BackColor = Color.Transparent;
            visitingTime.BackColor = Color.Transparent;
        }
    }
}
