using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace Software_de_taquilla.Views.UserViews.components
{
    public partial class MovieCard : UserControl
    {
        public int h, m;
        public Movie mov;
        public MovieCard(Movie movie, int h, int m)
        {
            this.mov = movie;
            this.h = h;
            this.m = m;
            InitializeComponent();
            label1.Text = movie.name;
            picture.Image = Image.FromFile("./../../../images/" + movie.image);
            int duracion = Convert.ToInt32(movie.duration);
            time_line.Value = duracion;
            label2.Text = duracion.ToString() + "min";
        }




        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SeaGreen;
            this.panel_card.BorderStyle = BorderStyle.FixedSingle;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.panel_card.BorderStyle = BorderStyle.None;
            label3.ForeColor = SystemColors.ControlDarkDark;

        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            MovieSelection mv = new MovieSelection(mov);
            mv.ShowDialog();
            this.Visible = true;

        }
    }
}
