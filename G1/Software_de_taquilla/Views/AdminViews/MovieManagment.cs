using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Controllers;

namespace Software_de_taquilla.Views.AdminViews
{
    public partial class MovieManagment : Form
    {
        public string image_location;
        public MovieManagment()
        {
            InitializeComponent();
            MovieController ctrl = new MovieController(this);
        }

        public void clearTextBox()
        {
            txt_duracion.Text = "";
            txt_name.Text = "";
            txt_publico.Text = "";
        }

        public void printMessage(string msg)
        {
            MessageBox.Show(msg);
        }


        private void panel_picture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel_picture_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string myfile = files[0];
            this.image_location = myfile;
            panel_picture.BackgroundImage = Image.FromFile(myfile);
            panel_picture.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
