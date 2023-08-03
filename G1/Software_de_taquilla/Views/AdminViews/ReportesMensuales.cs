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

namespace Software_de_taquilla.Views.AdminViews
{
    public partial class ReportesMensuales : Form
    {
        public ReportesMensuales()
        {
            InitializeComponent();
            this.fillData(-1);
        }

        public int getWeek(int dia)
        {
            if (dia > 0 && dia < 7) return 1;
            if (dia > 7 && dia < 15) return 2;
            if (dia > 15 && dia < 21) return 3;
            return 4;
        }



        public void fillData(int n)
        {
            this.data_grid.Rows.Clear();
            VentaDao vdao = new VentaDao();
            List<Venta> ventas = vdao.getVenta();
            this.data_grid.ColumnCount = 4;
            this.data_grid.Columns[0].Name = "ID";
            this.data_grid.Columns[1].Name = "Cine";
            this.data_grid.Columns[2].Name = "Fecha";
            this.data_grid.Columns[3].Name = "Total";
            foreach (Venta venta in ventas)
            {
                if (n == -1)
                {
                    this.data_grid.Rows.Add(venta.id, venta.id_cine, venta.fecha, venta.total);
                }
                else
                {
                    string fecha = venta.fecha.Substring(venta.fecha.IndexOf('/') + 1, venta.fecha.IndexOf('/') + 1);
                    string mes = venta.fecha.Substring(0, venta.fecha.IndexOf('/'));
                    int dia = Convert.ToInt32(mes);
                    int _mes = Convert.ToInt32(fecha);
                    int semana = getWeek(dia);
                    int mes_seleccionado = combo_mes.SelectedIndex + 1;
                    if (n == semana && _mes == mes_seleccionado) this.data_grid.Rows.Add(venta.id, venta.id_cine, venta.fecha, venta.total);
                }
            }
        }


        private void btn_IngresoS_Click(object sender, EventArgs e)
        {
        }

        private void combo_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.combo_filtro.SelectedIndex.ToString());
            this.fillData(this.combo_filtro.SelectedIndex + 1);
        }
    }
}
