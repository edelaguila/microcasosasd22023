using Software_de_taquilla.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_taquilla.Views
{
    public partial class Register : Form
    {
        public RegisterController ctrl;
        public Register()
        {
            InitializeComponent();
            this.ctrl = new RegisterController(this);
        }

        public void printMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
