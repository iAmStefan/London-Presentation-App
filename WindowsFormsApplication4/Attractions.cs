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
    public partial class Attractions : Form
    {
        public Attractions()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Declarations
        int id = 0;
        static Button westmisterAbbey = new Button();
        static Button britishMuseum = new Button();
        static Button chinaTown = new Button();
        static Button cathedral = new Button();
        static Button coventGarden = new Button();
        static Button nationalGallery = new Button();
        static Button londonTower = new Button();
        static Button hmsBelfast = new Button();
        static Button londonEye = new Button();
        static Button madameTussauds = new Button();
        static Button victoriaQueen = new Button();
        static Button naturalHistory = new Button();
        static Button observatory = new Button();
        static Button buckinghamPalace = new Button();
        static Button westminsterPalace = new Button();
        static Button trafalgarSquare = new Button();
        static Button picadillyCircus = new Button();
        static Button globeTheater = new Button();
        static Button shard = new Button();
        static Button towerBridge = new Button();
        Button[] atractii = new Button[20] { westmisterAbbey, britishMuseum, chinaTown, cathedral, coventGarden, nationalGallery, londonTower, hmsBelfast, londonEye, madameTussauds, victoriaQueen, naturalHistory, observatory, buckinghamPalace, westminsterPalace, trafalgarSquare, picadillyCircus, globeTheater, shard, towerBridge };
        string[] attractionNames = new string[20] { "Abatia Westminster", "British Museum", "Cartierele Chinezesti", "Catedrala Sf. Paul", "Covent Garden", "Galeria Nationala", "HMS Belfast", "London Eye", "Madame Tussauds", "Memorialul reginei Victoria", "Muzeul de istorie naturala", "Observatorul GreenWich", "Palatul Buckingham", "Palatul Westminster", "Piata Trafalgar", "Picadilly Circus", "Globe Theater", "The Shard", "Tower Bridge", "Turnul Londrei" };
        #endregion

        void Place()
        {
            for (int i = 0; i < atractii.Length; i++)
            {
                atractii[i].Size = new Size(220, 50);
                atractii[i].Font = new Font("Monotype Corsiva", 14, FontStyle.Italic);
                atractii[i].Text = attractionNames[i];
                this.Controls.Add(atractii[i]);
            }

            westmisterAbbey.Location = new Point(40, 50);
            westmisterAbbey.Click += WestmisterAbbey_Click;

            britishMuseum.Location = new Point(40, 120);
            britishMuseum.Click += BritishMuseum_Click;

            chinaTown.Location = new Point(40, 190);
            chinaTown.Click += ChinaTown_Click;

            cathedral.Location = new Point(40, 260);
            cathedral.Click += Cathedral_Click;

            coventGarden.Location = new Point(40, 330);
            coventGarden.Click += CoventGarden_Click;

            nationalGallery.Location = new Point(40, 400);
            nationalGallery.Click += NationalGallery_Click;

            hmsBelfast.Location = new Point(40, 470);
            hmsBelfast.Click += HmsBelfast_Click;

            londonEye.Location = new Point(330, 50);
            londonEye.Click += LondonEye_Click;

            madameTussauds.Location = new Point(330, 120);
            madameTussauds.Click += MadameTussauds_Click;

            victoriaQueen.Location = new Point(330, 190);
            victoriaQueen.Click += VictoriaQueen_Click;

            naturalHistory.Location = new Point(330, 330);
            naturalHistory.Click += NaturalHistory_Click;

            observatory.Location = new Point(330, 260);
            observatory.Click += Observatory_Click;

            buckinghamPalace.Location = new Point(330, 400);
            buckinghamPalace.Click += BuckinghamPalace_Click;

            westminsterPalace.Location = new Point(610, 50);
            westminsterPalace.Click += WestminsterPalace_Click;

            trafalgarSquare.Location = new Point(610, 120);
            trafalgarSquare.Click += TrafalgarSquare_Click;

            picadillyCircus.Location = new Point(610, 190);
            picadillyCircus.Click += PicadillyCircus_Click;

            globeTheater.Location = new Point(610, 260);
            globeTheater.Click += GlobeTheater_Click;

            shard.Location = new Point(610, 330);
            shard.Click += Shard_Click;

            towerBridge.Location = new Point(610, 400);
            towerBridge.Click += TowerBridge_Click;

            londonTower.Location = new Point(610, 470);
            londonTower.Click += LondonTower_Click;
        }

        private void LondonTower_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Turnul Londrei.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/londonTower/londonTower 2.jpeg");
            id = 1;
        }

        private void TowerBridge_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/TowerBridge.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/towerBridge/towerBridge.jpeg");
            id = 1;
        }

        private void Shard_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/The Shard.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/The Shard/theShard.jpeg");
            id = 1;
        }

        private void GlobeTheater_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Globe Theater.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/globeTheater/globeTheater.jpeg");
            id = 1;
        }

        private void PicadillyCircus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Picadilly Circus.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/picadillyCircus/picadillyCircus 2.jpeg");
            id = 1;
        }

        private void TrafalgarSquare_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Trafalgar Square.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/trafalgarSquare/trafalgar Square.jpg");
            visitingTime.Text = "Timp de vizitare: maximum 30 de minute";
            visitingTime.Location = new Point(360, 600);
            this.Height = 620;
            id = 1;
        }

        private void WestminsterPalace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Palatul Westminster.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/westminsterPalace/westminsterPalace.jpg");
            id = 1;
        }

        private void BuckinghamPalace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Buckingham Palace.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/buckinghamPalace/buckinghamPalace.jpg");
            id = 1;
        }

        private void Observatory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Observatory.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/observatory/observatory 2.jpeg");
            id = 1;
        }

        private void NaturalHistory_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Natural History.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/naturalHistory/naturalHistory.jpeg");
            id = 1;
            visitingTime.Text = "Timp de vizitare: 2-3 ore";
            visitingTime.Location = new Point(360, 600);
            this.Height = 620;
        }

        private void VictoriaQueen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Memorialul Regina Victoria.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/memorialVictoria/memorialVictoria 3.jpeg");
            id = 1;
        }

        private void MadameTussauds_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Madame Tussauds.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/madameTussauds/madameTussauds.jpeg");
            id = 1;
            visitingTime.Text = "Timp de vizitare: 2 ore";
            visitingTime.Location = new Point(360, 600);
            this.Height = 620;
        }

        private void LondonEye_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/London Eye.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/londonEye/londonEye.jpeg");
            id = 1;
        }

        private void HmsBelfast_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/HMS Belfast.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/HMS Belfast/HMS Belfast 3.jpeg");
            id = 1;
        }

        private void NationalGallery_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/National Gallery.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/nationalGallery/nationalGallery.jpeg");
            id = 1;
            visitingTime.Text = "Timp de vizitare: 2-3 ore";
            visitingTime.Location = new Point(360, 600);
            this.Height = 620;
        }

        private void CoventGarden_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Covent Garden.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/coventGarden/coventGarden 1.jpeg");
            id = 1;
        }

        private void Cathedral_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Catedrala Sf. Paul.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/cathedral/cathedral 3.jpeg");
            id = 1;
        }

        private void ChinaTown_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/China Town.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/chinaTown/chinaTown.jpeg");
            id = 1;
        }

        private void BritishMuseum_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/British Museum.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/britishMuseum/britishMuseum.jpeg");
            visitingTime.Text = "Timp de vizitare: minim 3 ore";
            visitingTime.Location = new Point(360, 600);
            this.Height = 620;
            id = 1;
        }

        private void WestmisterAbbey_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < atractii.Length; i++)
                atractii[i].Visible = false;
            informatii.Visible = true;
            informatii.LoadFile(@"Informatii/Abatia Westminster.pdf");
            informatii.Size = new Size(800, 510);
            informatii.Location = new Point(30, 50);
            this.BackgroundImage = new Bitmap(@"Imagini/westminsterAbbey/westminsterAbbey.jpg");
            id = 1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                for (int i = 0; i < atractii.Length; i++)
                    atractii[i].Visible = true;
                this.BackgroundImage = new Bitmap(@"Imagini/tubeMap.gif");
                informatii.Visible = false;
                id = 0;
            }
            else if (id == 0)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void Attractions_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/tubeMap.gif");
            close.BackColor = Color.Transparent;
            back.BackColor = Color.Transparent;
            visitingTime.BackColor = Color.Transparent;
            Place();
        }
    }
}
