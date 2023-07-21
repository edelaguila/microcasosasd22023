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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_correo_Leave(object sender, EventArgs e)
        {

            txt_correo.Text = "ejemplo♦gmail.com";
            txt_correo.ForeColor = SystemColors.WindowFrame;
        }

        private void txt_correo_Click(object sender, EventArgs e)
        {
            txt_correo.Text = "";
            txt_correo.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefono_Click(object sender, EventArgs e)
        {
            txt_telefono.Text = "";
            txt_telefono.ForeColor = Color.Black;
        }

        private void txt_telefono_Leave(object sender, EventArgs e)
        {
            txt_telefono.Text = "Telefono";
            txt_telefono.ForeColor = SystemColors.WindowFrame;
        }

        private void txt_monto_Click(object sender, EventArgs e)
        {
            txt_monto.Text = "";
            txt_monto.ForeColor = Color.Black;
        }

        private void txt_monto_Leave(object sender, EventArgs e)
        {
            txt_monto.Text = "Q.245.00 ";
            txt_monto.ForeColor = SystemColors.WindowFrame;
        }
    }
}
