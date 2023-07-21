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
    public partial class UserManagment : Form
    {
        public UserManagment()
        {
            InitializeComponent();
            UserController ctrl = new UserController(this);
        }

        public void printMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public void clearTextBox()
        {
            txt_contrasenia.Text = "";
            txt_name.Text = "";
        }

    }
}
