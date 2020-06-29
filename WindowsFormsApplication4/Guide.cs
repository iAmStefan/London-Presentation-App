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
    public partial class Guide : Form
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void Guide_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"Imagini/journal.jpg");
            close.BackColor = Color.Transparent;
            back.BackColor = Color.Transparent;
            Placing();
            for (int i = 0; i < 18; i++)
            {
                Point punct = new Point();
                punct.X = puncteX[i];
                punct.Y = puncteY[i];
                points.Add(punct);
            }
        }

        #region Declarari
        //Point cursor;
        string attractionName;
        int mapId = 0;
        int id = 0;
        PictureBox harta = new PictureBox();
        Label trafalgarSquare = new Label();
        Label buckinghamPalace = new Label();
        Label victoriaMemorial = new Label();
        Label westminsterPalace = new Label();
        Label westminsterAbbey = new Label();
        Label londonEye = new Label();
        Label nationalGallery = new Label();
        Label naturalHistory = new Label();
        Label britishMuseum = new Label();
        Label cathedral = new Label();
        Label coventGarden = new Label();
        Label picadillyCircus = new Label();
        Label towerBridge = new Label();
        Label theShard = new Label();
        Label globeTheater = new Label();
        Label observatory = new Label();
        Label madameTussauds = new Label();
        Label hmsBelfast = new Label();
        List<Point> points = new List<Point>();
        int[] puncteX = new int[18] { 270, 200, 215, 255, 270, 290, 270, 280, 30, 180, 820, 390, 390, 460, 440, 480, 250, 290 };
        int[] puncteY = new int[18] { 120, 180, 180, 195, 195, 175, 140, 80, 220, 10, 350, 100, 145, 140, 160, 160, 130, 100 };
        #endregion Declarari

        void Placing()
        {
            trafalgarSquare.Text = "Piata Trafalgar";
            trafalgarSquare.Size = new Size(80, 15);
            trafalgarSquare.Location = new Point(280, 120);
            trafalgarSquare.BackColor = Color.Transparent;
            trafalgarSquare.ForeColor = Color.White;
            trafalgarSquare.Click += TrafalgarSquare_Click;

            buckinghamPalace.Text = "Palatul Buckingham";
            buckinghamPalace.Size = new Size(105, 15);
            buckinghamPalace.Location = new Point(100, 177);
            buckinghamPalace.BackColor = Color.Transparent;
            buckinghamPalace.ForeColor = Color.White;
            buckinghamPalace.Click += BuckinghamPalace_Click;

            victoriaMemorial.Text = "Memorialul reginei Victoria";
            victoriaMemorial.Size = new Size(130, 15);
            victoriaMemorial.Location = new Point(170, 160);
            victoriaMemorial.BackColor = Color.Transparent;
            victoriaMemorial.ForeColor = Color.White;
            victoriaMemorial.Click += VictoriaMemorial_Click;

            westminsterPalace.Text = "Palatul Westminster";
            westminsterPalace.Size = new Size(100, 15);
            westminsterPalace.Location = new Point(200, 210);
            westminsterPalace.BackColor = Color.Transparent;
            westminsterPalace.ForeColor = Color.White;
            westminsterPalace.Click += WestminsterPalace_Click;

            westminsterAbbey.Text = "Abatia Westminster";
            westminsterAbbey.Size = new Size(100, 15);
            westminsterAbbey.Location = new Point(280, 195);
            westminsterAbbey.BackColor = Color.Transparent;
            westminsterAbbey.ForeColor = Color.White;
            westminsterAbbey.Click += WestminsterAbbey_Click;

            londonEye.Text = "Ochiul Londrei";
            londonEye.Size = new Size(80, 15);
            londonEye.Location = new Point(300, 175);
            londonEye.BackColor = Color.Transparent;
            londonEye.ForeColor = Color.White;
            londonEye.Click += LondonEye_Click;

            nationalGallery.Text = "Galeria Nationala";
            nationalGallery.Size = new Size(100, 15);
            nationalGallery.Location = new Point(280, 138);
            nationalGallery.BackColor = Color.Transparent;
            nationalGallery.ForeColor = Color.White;
            nationalGallery.Click += NationalGallery_Click;

            naturalHistory.Text = "Muzeul de istorie naturala";
            naturalHistory.Size = new Size(130, 15);
            naturalHistory.Location = new Point(40, 220);
            naturalHistory.BackColor = Color.Transparent;
            naturalHistory.ForeColor = Color.White;
            naturalHistory.Click += NaturalHistory_Click;

            britishMuseum.Text = "British Museum";
            britishMuseum.Size = new Size(100, 15);
            britishMuseum.Location = new Point(290, 78);
            britishMuseum.BackColor = Color.Transparent;
            britishMuseum.ForeColor = Color.White;
            britishMuseum.Click += BritishMuseum_Click;

            cathedral.Text = "Catedrala Sf. Paul";
            cathedral.Size = new Size(100, 15);
            cathedral.Location = new Point(400, 98);
            cathedral.BackColor = Color.Transparent;
            cathedral.ForeColor = Color.White;
            cathedral.Click += Cathedral_Click;

            coventGarden.Text = "Covent Garden";
            coventGarden.Size = new Size(100, 15);
            coventGarden.Location = new Point(210, 98);
            coventGarden.BackColor = Color.Transparent;
            coventGarden.ForeColor = Color.White;
            coventGarden.Click += CoventGarden_Click;

            picadillyCircus.Text = "Picadilly Circus";
            picadillyCircus.Size = new Size(100, 15);
            picadillyCircus.Location = new Point(170, 128);
            picadillyCircus.BackColor = Color.Transparent;
            picadillyCircus.ForeColor = Color.White;
            picadillyCircus.Click += PicadillyCircus_Click;

            towerBridge.Text = "Tower Bridge";
            towerBridge.Size = new Size(100, 15);
            towerBridge.Location = new Point(490, 160);
            towerBridge.BackColor = Color.Transparent;
            towerBridge.ForeColor = Color.White;
            towerBridge.Click += TowerBridge_Click;

            theShard.Text = "The Shard";
            theShard.Size = new Size(100, 15);
            theShard.Location = new Point(440, 175);
            theShard.BackColor = Color.Transparent;
            theShard.ForeColor = Color.White;
            theShard.Click += TheShard_Click;

            globeTheater.Text = "Shakespeare Globe Theater";
            globeTheater.Size = new Size(150, 15);
            globeTheater.Location = new Point(385, 125);
            globeTheater.BackColor = Color.Transparent;
            globeTheater.ForeColor = Color.White;
            globeTheater.Click += GlobeTheater_Click;

            observatory.Text = "Observatorul GreenWich";
            observatory.Size = new Size(130, 15);
            observatory.Location = new Point(695, 348);
            observatory.BackColor = Color.Transparent;
            observatory.ForeColor = Color.White;
            observatory.Click += Observatory_Click;

            madameTussauds.Text = "Madame Tussauds";
            madameTussauds.Size = new Size(100, 15);
            madameTussauds.Location = new Point(190, 10);
            madameTussauds.BackColor = Color.Transparent;
            madameTussauds.ForeColor = Color.White;
            madameTussauds.Click += MadameTussauds_Click;

            hmsBelfast.Text = "HMS Belfast";
            hmsBelfast.Size = new Size(100, 15);
            hmsBelfast.Location = new Point(470, 140);
            hmsBelfast.BackColor = Color.Transparent;
            hmsBelfast.ForeColor = Color.White;
            hmsBelfast.Click += HmsBelfast_Click;

            harta.Size = new Size(920, 420);
            harta.Location = new Point(10, 120);
            harta.BorderStyle = BorderStyle.FixedSingle;
            harta.SizeMode = PictureBoxSizeMode.StretchImage;
            harta.Paint += Harta_Paint;
        }

        private void HmsBelfast_Click(object sender, EventArgs e)
        {
            attractionName = "hmsBelfast";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void MadameTussauds_Click(object sender, EventArgs e)
        {
            attractionName = "madameTussauds";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void Observatory_Click(object sender, EventArgs e)
        {
            attractionName = "observatory";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void GlobeTheater_Click(object sender, EventArgs e)
        {
            attractionName = "globeTheater";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void TheShard_Click(object sender, EventArgs e)
        {
            attractionName = "theShard";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void TowerBridge_Click(object sender, EventArgs e)
        {
            attractionName = "towerBridge";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void PicadillyCircus_Click(object sender, EventArgs e)
        {
            attractionName = "picadillyCircus";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void CoventGarden_Click(object sender, EventArgs e)
        {
            attractionName = "coventGarden";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void Cathedral_Click(object sender, EventArgs e)
        {
            attractionName = "cathedral";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void BritishMuseum_Click(object sender, EventArgs e)
        {
            attractionName = "britishMuseum";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void NaturalHistory_Click(object sender, EventArgs e)
        {
            attractionName = "naturalHistory";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void NationalGallery_Click(object sender, EventArgs e)
        {
            attractionName = "nationalGallery";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void LondonEye_Click(object sender, EventArgs e)
        {
            attractionName = "londonEye";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void WestminsterAbbey_Click(object sender, EventArgs e)
        {
            attractionName = "westminsterAbbey";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void WestminsterPalace_Click(object sender, EventArgs e)
        {
            attractionName = "westminsterPalace";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void VictoriaMemorial_Click(object sender, EventArgs e)
        {
            attractionName = "victoriaMemorial";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void BuckinghamPalace_Click(object sender, EventArgs e)
        {
            attractionName = "buckinghamPalace";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        private void TrafalgarSquare_Click(object sender, EventArgs e)
        {
            attractionName = "trafalgarSquare";
            Informatii informatii = new Informatii(attractionName);
            informatii.Show();
        }

        void removeControl(Label control1, Label control2, Label control3)
        {
            harta.Controls.Remove(control1);
            harta.Controls.Remove(control2);
            harta.Controls.Remove(control3);
        }

        void addControl(Label control1, Label control2, Label control3)
        {
            harta.Controls.Add(control1);
            harta.Controls.Add(control2);
            harta.Controls.Add(control3);
        }

        private void Harta_Paint(object sender, PaintEventArgs e)
        {
            if (mapId == 1)
            {
                for (int i = 0; i < 6; i++)
                {           
                    Pen myRectPen = new Pen(Color.DodgerBlue, 2);
                    Rectangle patrat = new Rectangle();
                    patrat.Size = new Size(10, 10);
                    patrat.Location = new Point(points[i].X, points[i].Y);
                    e.Graphics.DrawRectangle(myRectPen, patrat);
                }
            }
            else if (mapId == 2)
            {
                for (int i = 0; i < 9; i++)
                {
                    Pen myRectPen = new Pen(Color.DodgerBlue, 2);
                    Rectangle patrat = new Rectangle();
                    patrat.Size = new Size(10, 10);
                    patrat.Location = new Point(points[i].X, points[i].Y);
                    e.Graphics.DrawRectangle(myRectPen, patrat);
                }
            }
            else if (mapId == 3)
            {
                for (int i = 0; i < 18; i++)
                {
                    Pen eu = new Pen(Color.DodgerBlue, 2);
                    Rectangle patrat = new Rectangle();
                    patrat.Size = new Size(10, 10);
                    patrat.Location = new Point(points[i].X, points[i].Y);
                    e.Graphics.DrawRectangle(eu, patrat);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (id == 1)
            {
                removeControl(trafalgarSquare, buckinghamPalace, victoriaMemorial);
                removeControl(westminsterPalace, westminsterAbbey, londonEye);
                removeControl(nationalGallery, naturalHistory, britishMuseum);
                removeControl(cathedral, hmsBelfast, coventGarden);
                removeControl(picadillyCircus, towerBridge, theShard);
                removeControl(globeTheater, observatory, madameTussauds);
                oneDay.Visible = true;
                twoDays.Visible = true;
                threeDays.Visible = true;
                title.Visible = true;
                this.Controls.Remove(harta);
                this.Height = 570;
                id = 0;
                mapId = 0;
                harta.Size = new Size(940, 420);
                harta.Location = new Point(0, 150);
            }
            else if (id == 0)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void oneDay_Click(object sender, EventArgs e)
        {
            addControl(trafalgarSquare, buckinghamPalace, victoriaMemorial);
            addControl(westminsterPalace, westminsterAbbey, londonEye);
            id = 1;
            mapId = 1;
            harta.Location = new Point(240, 30);
            harta.Size = new Size(430, 420);
            this.Height = 480;
            oneDay.Visible = false;
            twoDays.Visible = false;
            threeDays.Visible = false;
            title.Visible = false;
            this.Controls.Add(harta);
            harta.Image = new Bitmap(@"Imagini/mapDay1.png");
        }

        private void twoDays_Click(object sender, EventArgs e)
        {
            addControl(trafalgarSquare, buckinghamPalace, victoriaMemorial);
            addControl(westminsterPalace, westminsterAbbey, londonEye);
            addControl(nationalGallery, naturalHistory, britishMuseum);
            id = 1;
            mapId = 2;
            harta.Location = new Point(240, 30);
            harta.Size = new Size(430, 420);
            this.Height = 480;
            oneDay.Visible = false;
            twoDays.Visible = false;
            threeDays.Visible = false;
            title.Visible = false;
            this.Controls.Add(harta);
            harta.Image = new Bitmap(@"Imagini/mapDay2.png");
        }

        private void threeDays_Click(object sender, EventArgs e)
        {
            addControl(trafalgarSquare, buckinghamPalace, victoriaMemorial);
            addControl(westminsterPalace, westminsterAbbey, londonEye);
            addControl(nationalGallery, naturalHistory, britishMuseum);
            addControl(cathedral, coventGarden, hmsBelfast);
            addControl(picadillyCircus, towerBridge, theShard);
            addControl(globeTheater, observatory, madameTussauds);
            id = 1;
            mapId = 3;
            oneDay.Visible = false;
            twoDays.Visible = false;
            threeDays.Visible = false;
            title.Visible = false;
            this.Controls.Add(harta);
            harta.Image = new Bitmap(@"Imagini/map.png");
        }
    }
}
