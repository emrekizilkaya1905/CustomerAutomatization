using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            dataGridView1.ClearSelection();
            textBoxCustomerId.Text = "0";
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
                catch (Exception ex)
                {
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            textBoxCustomerId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            textBoxSalary.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            textBoxEligible.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            textBoxCity.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();

        }

       
    }
}
