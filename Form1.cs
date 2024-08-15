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
                    MessageBox.Show("There has been error occured. Error Code:E101\n" + ex.Message);
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
                dataGridView1.ClearSelection();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            textBoxCustomerId.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            textBoxSurname.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            textBoxSalary.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();

            textBoxCity.Text = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
            string eligible = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            if (eligible.Equals("True"))
                textBoxEligible.Text = "Yes";
            else
                textBoxEligible.Text = "No";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer(Name, Surname, Salary, "
                    + "EligibleForCredit, City) VALUES (@P1,@P2,@P3,@P4,@P5)", connection);
                cmd.Parameters.AddWithValue("@P1", textBoxName.Text);
                cmd.Parameters.AddWithValue("@P2", textBoxSurname.Text);
                cmd.Parameters.AddWithValue("@P3", textBoxSalary.Text);
                if (Convert.ToInt32(textBoxSalary.Text) > 10.000)
                {
                    cmd.Parameters.AddWithValue("@P4", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@P4", 0);
                }

                cmd.Parameters.AddWithValue("@P5", textBoxCity.Text);
                // Query olmayan sqlu calistir. Yani sorgu olmayan select haric.
                //Insert, update,delete
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("There has been error occured Error code: E102\n" + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            showData();
            clearBoxes();
        }
        private void clearBoxes()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxSalary.Clear();
            textBoxEligible.Clear();
            textBoxCity.Clear();
            textBoxCustomerId.Text = "0";

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            clearBoxes();
        }
    }
}
