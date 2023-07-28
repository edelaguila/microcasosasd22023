using Software_de_taquilla.Views.AdminViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using Software_de_taquilla.Models.Dao;

namespace Software_de_taquilla.Controllers
{
    public class UserController
    {
        public UserManagment view;
        public UserController(UserManagment view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponent);
        }

        public void buildComponent(Object sender, EventArgs e)
        {
            this.view.btn_save.Click += new EventHandler(this.saveUser);
            this.view.btn_delete.Click += new EventHandler(this.deleteUser);
            this.view.passImage.Click += new EventHandler(this.passwordStatus);
            this.view.btn_update.Click += new EventHandler(this.updateUser);
            this.fillDataGrid();
            this.fillRoleList();
        }
        public void updateUser(Object sender, EventArgs e)
        {

            string n = this.view.data_grid.SelectedRows[0].Cells[1].Value.ToString();
            string c = this.view.data_grid.SelectedRows[0].Cells[2].Value.ToString();
            int r = Convert.ToInt32(this.view.data_grid.SelectedRows[0].Cells[3].Value);
            this.view.btn_save.Text = "Actualizar Cambios";
            this.view.txt_name.Text = n;
            this.view.txt_contrasenia.Text = c;
            this.view.role_list.SelectedIndex = r - 1;
            this.view.btn_save.BackColor = Color.FromArgb(255, 75, 10);
        }

        public void passwordStatus(Object sender, EventArgs e)
        {
            if (this.view.txt_contrasenia.PasswordChar.Equals('\0'))
            {
                this.view.txt_contrasenia.PasswordChar = '*';
            }
            else
            {
                this.view.txt_contrasenia.PasswordChar = '\0';
            }
        }


        public bool isFullFields()
        {
            return this.view.txt_contrasenia.Text != "" || this.view.txt_name.Text != "";
        }


        public void saveUser(Object sender, EventArgs e)
        {
            if (this.view.btn_save.BackColor == Color.SeaGreen)
            {

                string username = this.view.txt_name.Text;
                string pass = this.view.txt_contrasenia.Text;
                int rol = Convert.ToInt32(this.view.role_list.SelectedIndex + 1);
                UserDao mydao = new UserDao();
                mydao.insertUser(username, pass, rol);
                if (this.isFullFields())
                {
                    this.view.printMessage("Usuario Agregado :D");
                    this.fillDataGrid();
                    this.view.clearTextBox();
                }
                else
                {
                    this.view.printMessage("Llene todos los campos");
                    this.view.clearTextBox();
                }
            }
            else
            {
                if (this.view.data_grid.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario para ser acutalizado");
                    return;
                }
                string username = this.view.txt_name.Text;
                string pass = this.view.txt_contrasenia.Text;
                int rol = Convert.ToInt32(this.view.role_list.SelectedIndex + 1);
                int id = Convert.ToInt32(this.view.data_grid.SelectedRows[0].Cells[0].Value);
                UserDao mydao = new UserDao();
                mydao.updateUser(id, username, pass, rol);
                if (this.isFullFields())
                {
                    this.view.printMessage("Usuario Actualizado");
                    this.fillDataGrid();
                    this.view.clearTextBox();
                    this.view.btn_save.BackColor = Color.SeaGreen;
                }
                else
                {
                    this.view.printMessage("Llene todos los campos");
                    this.view.clearTextBox();
                }
            }
        }


        public void fillDataGrid()
        {
            UserDao userdao = new UserDao();
            List<User> users = userdao.getUsers();
            this.view.data_grid.ColumnCount = 4;
            this.view.data_grid.Columns[0].Name = "ID";
            this.view.data_grid.Columns[1].Name = "Usuario";
            this.view.data_grid.Columns[2].Name = "Contraseña";
            this.view.data_grid.Columns[3].Name = "Rol";
            this.view.data_grid.Rows.Clear();
            foreach (User user in users)
            {
                this.view.data_grid.Rows.Add(user.id, user.name, user.pass, user.rol);
            }
        }

        public void fillRoleList()
        {
            RoleDao roledao = new RoleDao();
            List<Role> roles = roledao.getRoles();
            foreach (Role role in roles)
            {
                this.view.role_list.Items.Add(role.description);
            }
        }

        public void deleteUser(Object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.view.data_grid.SelectedRows[0].Cells[0].Value);
            if (MessageBox.Show("¿Esta seguro que desea eliminarlo?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                UserDao user = new UserDao();
                user.deleteUser(id);
                this.fillDataGrid();
            }
        }
    }
}
