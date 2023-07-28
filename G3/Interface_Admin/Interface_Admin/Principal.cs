using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Admin
{
    public partial class Principal : Form
    {
        private Form currentForm;

        private readonly tablero formTablero = new tablero();
        private readonly campeonatos formCampeonatos = new campeonatos();
        private readonly equipos formEquipos = new equipos();
        private readonly entrenadores formEntrenadores = new entrenadores();
        private readonly jugadores formJugadores = new jugadores();
        private readonly empleados formEmpleados = new empleados();
        private readonly bitacora formBitacora = new bitacora();


        private void MostrarFormEnPanel(Form form)
        {
            CerrarFormActual(); // Close any previously displayed form

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
            form.BringToFront(); // Bring the newly added form to the front
            currentForm = form; // Update the currentForm variable with the newly displayed form
        }

        // MÃ©todo para cerrar el formulario actualmente abierto en el panel.
        private void CerrarFormActual()
        {
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Hide();
                pnlContenedor.Controls.Remove(currentForm);
                currentForm.Hide(); // Dispose of the form when closing it
                currentForm = null; // Reset the currentForm variable
            }
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
            MessageBox.Show("Sesión Cerrada");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formTablero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formCampeonatos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEquipos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEntrenadores);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formJugadores);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEmpleados);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formBitacora);
        }
    }
}
