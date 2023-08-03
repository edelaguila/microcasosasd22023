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
    public partial class Horarios : Form
    {
        public HorarioController ctrl;
        public Horarios()
        {
            InitializeComponent();
            this.ctrl = new HorarioController(this);
        }

        public void printMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public void clearTextBox()
        {
            this.txt_hf.Text = "";
            this.txt_hi.Text = "";
        }
    }
}
