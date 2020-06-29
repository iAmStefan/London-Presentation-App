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
    public partial class Gallery : Form
    {
        public Gallery()
        {
            InitializeComponent();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedItem.ToString() == "Parada garzilor")
            {
                this.Controls.Add(movie);
                movie.Visible = true;
                this.Controls.Remove(imagine);
                movie.URL = "";
                imagine.Image = null;
                movie.Size = new Size(695, 510);
                close.Location = new Point(885, -2);
                back.Location = new Point(850, -2);
                this.Size = new Size(905, 550);
                imagine.Size = new Size(695, 510);
                movie.URL = @"Imagini/Guard/guardParade.mp4";
            }
            else if (lista.SelectedItem.ToString() == "Piata Trafalgar 1")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                imagine.Image = null;
                movie.URL = "";
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/trafalgarSquare/trafalgarSquare.jpeg");
            }
            else if (lista.SelectedItem.ToString() == "Piata Trafalgar 2")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                movie.URL = "";
                imagine.Image = null;
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/trafalgarSquare/trafalgarSquare 2.jpeg");
            }
            else if (lista.SelectedItem.ToString() == "Piata Trafalgar 3")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                imagine.Image = null;
                movie.URL = "";
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/trafalgarSquare/trafalgarSquare 3.jpeg"); // trafalgarSquare
            }
            else if (lista.SelectedItem.ToString() == "China Town 2")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                imagine.Image = null;
                movie.URL = "";
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/chinaTown/chinaTown 2.jpeg"); // chinaTown
            }
            else if (lista.SelectedItem.ToString() == "London Eye 2")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                imagine.Image = null;
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/londonEye/londonEye 2.jpeg");  // londonEye
            }
            else if (lista.SelectedItem.ToString() == "Memorialul reginei Victoria 1")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                imagine.Image = null;
                movie.URL = "";
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/memorialVictoria/memorialVictoria.jpeg");
            }
            else if (lista.SelectedItem.ToString() == "Memorialul reginei Victoria 2")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                imagine.Image = null;
                movie.URL = "";
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/memorialVictoria/memorialVictoria 2.jpeg");
            }
            else if (lista.SelectedItem.ToString() == "Catedrala Sf. Paul 2")
            {
                this.Controls.Remove(movie);
                this.Controls.Add(imagine);
                imagine.Image = null;
                movie.URL = "";
                close.Location = new Point(435, -2);
                back.Location = new Point(405, -2);
                this.Size = new Size(455, 550);
                imagine.Size = new Size(250, 510);
                imagine.Image = new Bitmap(@"Imagini/cathedral/cathedral 2.jpeg");
            }
            else if (lista.SelectedItem.ToString() == "") return;
            else
            {
                this.Controls.Add(imagine);
                this.Controls.Remove(movie);
                imagine.Image = null;
                movie.URL = "";
                close.Location = new Point(885, -2);
                back.Location = new Point(850, -2);
                this.Size = new Size(905, 550);
                imagine.Size = new Size(695, 510);
                if (lista.SelectedItem.ToString() == "Covent Garden 1")
                    imagine.Image = new Bitmap(@"Imagini/coventGarden/coventGarden 1.jpeg");
                else if (lista.SelectedItem.ToString() == "Covent Garden 2")
                    imagine.Image = new Bitmap(@"Imagini/coventGarden/coventGarden 2.jpeg");
                else if (lista.SelectedItem.ToString() == "Covent Garden 3")
                    imagine.Image = new Bitmap(@"Imagini/coventGarden/coventGarden 3.jpeg"); // coventGarden
                else if (lista.SelectedItem.ToString() == "Galeria Nationala 1")
                    imagine.Image = new Bitmap(@"Imagini/nationalGallery/nationalGallery.jpeg");
                else if (lista.SelectedItem.ToString() == "Galeria Nationala 2")
                    imagine.Image = new Bitmap(@"Imagini/nationalGallery/nationalGallery 2.jpeg");
                else if (lista.SelectedItem.ToString() == "Galeria Nationala 3")
                    imagine.Image = new Bitmap(@"Imagini/nationalGallery/nationalGallery 3.jpeg"); // nationalGallery
                else if (lista.SelectedItem.ToString() == "HMS Belfast 1")
                    imagine.Image = new Bitmap(@"Imagini/HMS Belfast/HMS Belfast.jpeg");
                else if (lista.SelectedItem.ToString() == "HMS Belfast 2")
                    imagine.Image = new Bitmap(@"Imagini/HMS Belfast/HMS Belfast 2.jpeg");
                else if (lista.SelectedItem.ToString() == "HMS Belfast 3")
                    imagine.Image = new Bitmap(@"Imagini/HMS Belfast/HMS Belfast 3.jpeg"); // HMS Belfast
                else if (lista.SelectedItem.ToString() == "London Eye 1")
                    imagine.Image = new Bitmap(@"Imagini/londonEye/londonEye.jpeg");
                if (lista.SelectedItem.ToString() == "Abatia Westminster 1")
                    imagine.Image = new Bitmap(@"Imagini/westminsterAbbey/westminsterAbbey.jpg");
                else if (lista.SelectedItem.ToString() == "Abatia Westminster 2")
                    imagine.Image = new Bitmap(@"Imagini/westminsterAbbey/westminsterAbbey2.jpg");
                else if (lista.SelectedItem.ToString() == "Abatia Westminster 3")
                    imagine.Image = new Bitmap(@"Imagini/westminsterAbbey/westminsterAbbey3.jpg"); // westminsterAbbey
                else if (lista.SelectedItem.ToString() == "British Museum 1")
                    imagine.Image = new Bitmap(@"Imagini/britishMuseum/britishMuseum.jpeg");
                else if (lista.SelectedItem.ToString() == "British Museum 2")
                    imagine.Image = new Bitmap(@"Imagini/britishMuseum/britishMuseum 2.jpeg");
                else if (lista.SelectedItem.ToString() == "British Museum 3")
                    imagine.Image = new Bitmap(@"Imagini/britishMuseum/britishMuseum 3.jpeg"); // britishMuseum
                else if (lista.SelectedItem.ToString() == "China Town 1")
                    imagine.Image = new Bitmap(@"Imagini/chinaTown/chinaTown.jpeg");
                if (lista.SelectedItem.ToString() == "Madame Tussauds 1")
                    imagine.Image = new Bitmap(@"Imagini/madameTussauds/madameTussauds.jpeg");
                //else if (lista.SelectedItem.ToString() == "Madame Tussauds 2")

                //else if (lista.SelectedItem.ToString() == "Madame Tussauds 3")
                // madameTussauds
                if (lista.SelectedItem.ToString() == "Catedrala Sf. Paul 1")
                    imagine.Image = new Bitmap(@"Imagini/cathedral/cathedral.jpeg");
                else if (lista.SelectedItem.ToString() == "Catedrala Sf. Paul 3")
                    imagine.Image = new Bitmap(@"Imagini/cathedral/cathedral 3.jpeg"); // cathedral

                else if (lista.SelectedItem.ToString() == "Memorialul reginei Victoria 3")
                    imagine.Image = new Bitmap(@"Imagini/memorialVictoria/memorialVictoria 3.jpeg"); // victoriaStatue
                else if (lista.SelectedItem.ToString() == "Observatorul GreenWich 1")
                    imagine.Image = new Bitmap(@"Imagini/observatory/observatory.jpeg");
                else if (lista.SelectedItem.ToString() == "Observatorul GreenWich 2")
                    imagine.Image = new Bitmap(@"Imagini/observatory/observatory 2.jpeg");
                else if (lista.SelectedItem.ToString() == "Observatorul GreenWich 3")
                    imagine.Image = new Bitmap(@"Imagini/observatory/observatory 3.jpeg"); // observatory
                else if (lista.SelectedItem.ToString() == "Palatul Buckingham 1")
                    imagine.Image = new Bitmap(@"Imagini/buckinghamPalace/buckinghamPalace.jpg");
                else if (lista.SelectedItem.ToString() == "Palatul Buckingham 2")
                    imagine.Image = new Bitmap(@"Imagini/buckinghamPalace/buckinghamPalace2.jpg");
                else if (lista.SelectedItem.ToString() == "Palatul Buckingham 3")
                    imagine.Image = new Bitmap(@"Imagini/buckinghamPalace/buckinghamPalace3.jpg"); // buckinghamPalace
                else if (lista.SelectedItem.ToString() == "Palatul Westminster 1")
                    imagine.Image = new Bitmap(@"Imagini/westminsterPalace/westminsterPalace.jpg");
                else if (lista.SelectedItem.ToString() == "Palatul Westminster 2")
                    imagine.Image = new Bitmap(@"Imagini/westminsterPalace/westminsterPalace2.jpg");
                else if (lista.SelectedItem.ToString() == "Palatul Westminster 3")
                    imagine.Image = new Bitmap(@"Imagini/westminsterPalace/westminsterPalace3.jpg"); // westminsterPalace
                else if (lista.SelectedItem.ToString() == "Picadilly Circus 1")
                    imagine.Image = new Bitmap(@"Imagini/picadillyCircus/picadillyCircus.jpeg");
                else if (lista.SelectedItem.ToString() == "Picadilly Circus 2")
                    imagine.Image = new Bitmap(@"Imagini/picadillyCircus/picadillyCircus 2.jpeg"); // picadillyCircus
                else if (lista.SelectedItem.ToString() == "Shakespeare Globe Theater 1")
                    imagine.Image = new Bitmap(@"Imagini/globeTheater/globeTheater.jpeg");
                else if (lista.SelectedItem.ToString() == "Shakespeare Globe Theater 2")
                    imagine.Image = new Bitmap(@"Imagini/globeTheater/globeTheater 2.jpeg");
                else if (lista.SelectedItem.ToString() == "Shakespeare Globe Theater 3")
                    imagine.Image = new Bitmap(@"Imagini/globeTheater/globeTheater 3.jpeg"); // globeTheater
                else if (lista.SelectedItem.ToString() == "The Shard 1")
                    imagine.Image = new Bitmap(@"Imagini/The Shard/theShard.jpeg");
                else if (lista.SelectedItem.ToString() == "The Shard 2")
                    imagine.Image = new Bitmap(@"Imagini/The Shard/theShard 2.jpeg");
                else if (lista.SelectedItem.ToString() == "The Shard 3")
                    imagine.Image = new Bitmap(@"Imagini/The Shard/theShard 3.jpg");   // The Shard
                else if (lista.SelectedItem.ToString() == "Turnul Londrei 1")
                    imagine.Image = new Bitmap(@"Imagini/londonTower/londonTower.jpeg");
                else if (lista.SelectedItem.ToString() == "Turnul Londrei 2")
                    imagine.Image = new Bitmap(@"Imagini/londonTower/londonTower 2.jpeg");
                else if (lista.SelectedItem.ToString() == "Turnul Londrei 3")
                    imagine.Image = new Bitmap(@"Imagini/londonTower/londonTower 3.jpeg");   // London tower
                else if (lista.SelectedItem.ToString() == "Tower Bridge 1")
                    imagine.Image = new Bitmap(@"Imagini/towerBridge/towerBridge.jpeg");
                else if (lista.SelectedItem.ToString() == "Tower Bridge 2")
                    imagine.Image = new Bitmap(@"Imagini/towerBridge/towerBridge2.jpg");
                else if (lista.SelectedItem.ToString() == "Tower Bridge 3")
                    imagine.Image = new Bitmap(@"Imagini/towerBridge/towerBridge3.jpg"); // towerBridge
                else if (lista.SelectedItem.ToString() == "Muzeul de istorie naturala 1")
                    imagine.Image = new Bitmap(@"Imagini/naturalHistory/naturalHistory.jpeg");
                else if (lista.SelectedItem.ToString() == "Muzeul de istorie naturala 2")
                    imagine.Image = new Bitmap(@"Imagini/naturalHistory/naturalHistory 2.jpeg");
                else if (lista.SelectedItem.ToString() == "Muzeul de istorie naturala 3")
                    imagine.Image = new Bitmap(@"Imagini/naturalHistory/naturalHistory 3.jpeg");
            }
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            string[] atractiiTuristice = { "Abatia Westminster 1", "Abatia Westminster 2", "Abatia Westminster 3", "", "British Museum 1", "British Museum 2", "British Museum 3", "", "China Town 1", "China Town 2", "", "Catedrala Sf. Paul 1", "Catedrala Sf. Paul 2", "Catedrala Sf. Paul 3", "", "Covent Garden 1", "Covent Garden 2", "Covent Garden 3", "", "Galeria Nationala 1", "Galeria Nationala 2", "Galeria Nationala 3", "", "HMS Belfast 1", "HMS Belfast 2", "HMS Belfast 3", "", "London Eye 1", "London Eye 2", "London Eye 3", "", "Madame Tussauds 1", "Madame Tussauds 2", "Madame Tussauds 3", "", "Memorialul reginei Victoria 1", "Memorialul reginei Victoria 2", "Memorialul reginei Victoria 3", "", "Muzeul de istorie naturala 1", "Muzeul de istorie naturala 2", "Muzeul de istorie naturala 3", "", "Observatorul GreenWich 1", "Observatorul GreenWich 2", "Observatorul GreenWich 3", "", "Palatul Buckingham 1", "Palatul Buckingham 2", "Palatul Buckingham 3", "", "Palatul Westminster 1", "Palatul Westminster 2", "Palatul Westminster 3", "", "Parada garzilor", "", "Piata Trafalgar 1", "Piata Trafalgar 2", "Piata Trafalgar 3", "", "Picadilly Circus 1", "Picadilly Circus 2", "", "Shakespeare Globe Theater 1", "Shakespeare Globe Theater 2", "Shakespeare Globe Theater 3", "", "The Shard 1", "The Shard 2", "The Shard 3", "", "Turnul Londrei 1", "Turnul Londrei 2", "Turnul Londrei 3", "", "Tower Bridge 1", "Tower Bridge 2", "Tower Bridge 3"};
            lista.Items.AddRange(atractiiTuristice);
            this.BackgroundImage = new Bitmap(@"Imagini/gallery.jpg");
            close.BackColor = Color.Transparent;
            back.BackColor = Color.Transparent;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
