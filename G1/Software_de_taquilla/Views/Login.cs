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

namespace Software_de_taquilla.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginController usr = new LoginController(this);
        }


        public void printMessage(string message)
        {
            MessageBox.Show(message);
        }


        private void txt_user_Click(object sender, EventArgs e)
        {
            txt_user.Text = "";
            txt_user.ForeColor = Color.Black;
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            txt_user.Text = "Usuario";
            txt_user.ForeColor = SystemColors.WindowFrame;
        }

        private void txt_pass_Click_1(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_pass.ForeColor = Color.Black;
            txt_pass.PasswordChar = '*';

        }

        private void txt_pass_Leave_1(object sender, EventArgs e)
        {
            txt_pass.Text = "Contraseña";
            txt_pass.ForeColor = SystemColors.WindowFrame;
            txt_pass.PasswordChar = '\0';
        }

    }
}
