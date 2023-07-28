using Software_de_taquilla.Views;
using Software_de_taquilla.Views.AdminViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Controllers
{
    public class ReportesController
    {
        Views.AdminViews.ReportesMensuales myview;

        public ReportesController(ReportesMensuales view)
        {
            this.myview = view;
        }

    }
}
