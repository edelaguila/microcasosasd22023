<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodeportes_admin
{
    public partial class Admin : Form
    {

        private readonly tablero formTablero = new();
        private readonly campeonatos formCampeonatos = new();
        private readonly equipos formEquipos = new();
        private readonly entrenadores formEntrenadores = new();
        private readonly jugadores formJugadores = new();
        private readonly empleados formEmpleados = new();
        private readonly bitacora formBitacora = new();

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new();
            login.Show();

        }

        private void MostrarFormEnPanel(Form form)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls[0].Hide();

            // A continuación, muestra el Form deseado en el panel.
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }



        private void btnTablero_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formTablero);
        }

        private void btnCampeonato_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formCampeonatos);
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEquipos);
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEntrenadores);
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formJugadores);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEmpleados);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formBitacora);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new();
            login.Show();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodeportes_admin
{
    public partial class Admin : Form
    {

        private readonly tablero formTablero = new();
        private readonly campeonatos formCampeonatos = new();
        private readonly equipos formEquipos = new();
        private readonly entrenadores formEntrenadores = new();
        private readonly jugadores formJugadores = new();
        private readonly empleados formEmpleados = new();
        private readonly bitacora formBitacora = new();

        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new();
            login.Show();

        }

        private void MostrarFormEnPanel(Form form)
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls[0].Hide();

            // A continuación, muestra el Form deseado en el panel.
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(form);
            form.Show();
        }



        private void btnTablero_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formTablero);
        }

        private void btnCampeonato_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formCampeonatos);
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEquipos);
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEntrenadores);
        }

        private void btnJugador_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formJugadores);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formEmpleados);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(formBitacora);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            login login = new();
            login.Show();
        }
    }
}
>>>>>>> 2c8af600a16738343e5e8e7883032b3022314bcc
