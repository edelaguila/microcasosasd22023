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
        public DashboardAdmin(int rol)
        {
            InitializeComponent();
            lblPerfil.Text = this.getRole(rol);
        }

        public string getRole(int r)
        {
            if (r == 1) return "Administrador";
            if (r == 2) return "Empleado";
            if (r == 3) return "Cliente";
            return "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pic_Perfil.TabStop = false; // Deshabilitar el enfoque del control para evitar que se muestre el marco cuando se selecciona.
            Pic_Perfil.BorderStyle = BorderStyle.None;
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

        private void btnMenuAyuda_Click(object sender, EventArgs e)
        {
            this.openForm(new UserViews.MenuAyuda());
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            this.openForm(new AdminViews.ReportesMensuales());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.openForm(new AdminViews.Horarios());
        }
    }
}
