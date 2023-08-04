using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_UsuarioFinal
{


    public partial class Menu_Principal : Form
    {

        private Form currentForm;

        private readonly Tableros formTableros = new Tableros();
        private readonly Estadisticas formEstadisticas = new Estadisticas();
        private readonly Tablas formTablas = new Tablas();
        private readonly Equipos formEquipos = new Equipos();
        private void MostrarFormEnPanel(Form form)
        {
            CerrarFormActual(); // Close any previously displayed form

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Pnl_Menu.Controls.Add(form);
            form.Show();
            form.BringToFront(); // Bring the newly added form to the front
            currentForm = form; // Update the currentForm variable with the newly displayed form
        }
        private void CerrarFormActual()
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Hide();
                Pnl_Menu.Controls.Remove(currentForm);
                currentForm.Hide(); // Dispose of the form when closing it
                currentForm = null; // Reset the currentForm variable
            }
        }
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioSesion inicio = new InicioSesion();
            inicio.Show();

        }

        private void Btn_Tablero_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formTableros);
        }

        private void Btn_Estadisticas_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEstadisticas);
        }

        private void Btn_Tablas_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formTablas);
        }

        private void Btn_Equipos_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEquipos);
        }
    }
}
