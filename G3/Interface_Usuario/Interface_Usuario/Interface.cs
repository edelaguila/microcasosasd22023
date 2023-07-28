using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Usuario
{

    public partial class Interface : Form
    {
        private Form? currentForm;
        private readonly MostrarTablero VTablero = new();
        private readonly VerEquipo VEquipo = new();
        private readonly TabladePosiciones TDP = new();

        private void MostrarFormEnPanel(Form form)
        {
            CerrarFormActual(); // Close any previously displayed form

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
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
                panel2.Controls.Remove(currentForm);
                currentForm.Hide(); // Dispose of the form when closing it
                currentForm = null; // Reset the currentForm variable
            }
        }
     
        public Interface()        {
            InitializeComponent();

     
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CerrarFormActual();
            MostrarFormEnPanel(TDP);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CerrarFormActual();
            MostrarFormEnPanel(VTablero);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CerrarFormActual();
            MostrarFormEnPanel(VEquipo);



        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
