using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class Asientos : Form
    {
        public Movie movie;
        public Asientos(Movie mv)
        {
            this.movie = mv;
            InitializeComponent();
            this.createEffects();
        }


        public void clickEvent(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == System.Drawing.Color.WhiteSmoke)
            {
                btn.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                btn.BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }

        public void createEffects()
        {
            foreach (Control button in panel2.Controls)
            {
                if (button is Button)
                {
                    button.Click += new EventHandler(this.clickEvent);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsientoDao asi = new AsientoDao();
            asi.updateAsiento(this.movie.id_room, 1);
        }
    }
}
