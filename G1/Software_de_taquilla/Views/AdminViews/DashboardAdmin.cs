using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_taquilla.Views.AdminViews
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PctPerfil.TabStop = false; // Deshabilitar el enfoque del control para evitar que se muestre el marco cuando se selecciona.
            PctPerfil.BorderStyle = BorderStyle.None;
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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


        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            this.openForm(new UserManagment());
        }

        private void btn_peliculas_Click(object sender, EventArgs e)
        {
            this.openForm(new MovieManagment());
        }
    }
}
