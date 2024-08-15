using System.Data;
using System.Data.SqlClient;

namespace CustomerAutomatization
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=EMRE\SQLEXPRESS;Initial Catalog=ProjectsVT;Integrated Security=True;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            {
                try
                {
                    string sqlSentence = "SELECT CustomerId, Name, Surname, Salary, EligibleForCredit, City FROM Customer";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSentence, connection);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("There has been error occured." + ex.Message);
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
