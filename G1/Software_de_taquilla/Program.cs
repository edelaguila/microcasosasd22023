using Software_de_taquilla.Views.UserViews;
using Software_de_taquilla.Views;

namespace Software_de_taquilla
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {

                ApplicationConfiguration.Initialize();
                Application.Run(new Login());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al iniciar la aplicación: " + ex.Message,
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}