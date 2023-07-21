using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Views;
using Software_de_taquilla.Views.AdminViews;

namespace Software_de_taquilla.Controllers
{
    public class LoginController
    {
        public Login view;
        public LoginController(Login view)
        {
            this.view = view;
            this.view.btn_login.Click += new EventHandler(this.buildView);
        }

        private void buildView(Object sender, EventArgs e)
        {
            UserDao myuser = new UserDao();
            string user = this.view.txt_user.Text;
            string pass = this.view.txt_pass.Text;
            if (myuser.userExist(user, pass))
            {
                this.view.printMessage("¡Bienvenido!");
                this.view.Visible = false;
                DashboardAdmin admin = new DashboardAdmin();
                admin.ShowDialog();
                this.view.Visible = true;
            }
            else
            {
                this.view.printMessage("Usuario o Contraseña incorrectos");
            }
        }
    }
}

