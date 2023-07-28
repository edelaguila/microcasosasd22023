using Software_de_taquilla.Views.AdminViews;
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
    public partial class DashboardCliente : Form
    {

        public Form current;
        public void openForm(Form hijo)
        {
            if (this.current != null)
            {
                this.current.Close();
            }
            this.current = hijo;
            hijo.Dock = DockStyle.Fill;
            hijo.TopLevel = false;
            this.panel_container.Controls.Add(hijo);
            this.panel_container.Tag = hijo;
            hijo.Show();
        }
        public DashboardCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.openForm(new Pagos());
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuAyuda_Click(object sender, EventArgs e)
        {
            this.openForm(new MenuAyuda());
        }

        private void btnCartelera_Click(object sender, EventArgs e)
        {
            this.openForm(new Cartelera());
        }
    }
}
