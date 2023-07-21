using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class MenuAyuda : Form
    {
        public MenuAyuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_correoayuda_Click(object sender, EventArgs e)
        {
            txt_correoayuda.Text = "";
            txt_correoayuda.ForeColor = Color.Black;
        }

        private void txt_correoayuda_Leave(object sender, EventArgs e)
        {
            txt_correoayuda.Text = "ejemplo♦gmail.com";
            txt_correoayuda.ForeColor = SystemColors.WindowFrame;
        }

        private void txt_telefonoayuda_Click(object sender, EventArgs e)
        {
            txt_telefonoayuda.Text = "";
            txt_telefonoayuda.ForeColor = Color.Black;
        }

        private void txt_telefonoayuda_Leave(object sender, EventArgs e)
        {
            txt_telefonoayuda.Text = "Telefono";
            txt_telefonoayuda.ForeColor = SystemColors.WindowFrame;
        }
    }
}
