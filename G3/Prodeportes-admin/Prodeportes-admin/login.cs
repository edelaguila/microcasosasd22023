namespace Prodeportes_admin
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin adminForm = new();
            adminForm.Show();

            this.Hide();
        }
    }
}