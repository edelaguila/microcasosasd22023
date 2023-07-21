using Software_de_taquilla.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Controllers
{
    public class ClientController
    {
        ClientView myview;

        public ClientController(ClientView view)
        {
            this.myview = view;
            this.myview.Load += new EventHandler(this.renderView);
        }


        public void renderView(object sender, EventArgs e)
        {
            this.myview.lbl_title.Text = "vista cliente";
        }
    }
}
