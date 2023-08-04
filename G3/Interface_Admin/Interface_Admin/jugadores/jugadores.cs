using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Admin
{
    public partial class jugadores : Form
    {
        public jugadores()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchText = textBox1.Text;


            DatabaseConnection dbConnection = DatabaseConnection.Instance;
            SqlConnection connection = dbConnection.OpenConnection();

            string sqlQuery = "SELECT * FROM JUGADORES WHERE nombre LIKE @searchText OR apellido LIKE @searchText;";
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }

            dbConnection.CloseConnection();
        }
    }
}
