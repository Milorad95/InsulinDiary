using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Insulin_diary
{
    public partial class FormAddNewValue : Form
    {
        public FormAddNewValue()
        {
            InitializeComponent();
        }


        /* this method will insert all data from the form into a database */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var con = "Data Source=DESKTOP-ELB063I\\SQLEXPRESS01;Initial Catalog=InsulinDiary;Integrated Security=True";
            var connection = new SqlConnection(con);

            try
            {
                var command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = $@"INSERT INTO Notes (DateOfMeasurement, TimeOfMeasurement, ReferenceValue) VALUES (@d, @t, @r)";
                command.Parameters.AddWithValue("@d", DateTime.Parse(txtDate.Text.ToString()));
                command.Parameters.AddWithValue("@t", DateTime.Parse(txtTime.Text.ToString()).ToShortTimeString());
                command.Parameters.AddWithValue("@r", decimal.Parse(txtRefValue.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception a)
            {
                MessageBox.Show($"Error: {a.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
                this.Close();
                var f = new FormShowAllValues();      /* f instances will show the user all values, including new values if the user before have added them */
                f.Show();
            }
        }


        /* this method will show to form current date and time at the moment when the form is opening */
        private void FormAddNewValue_Load(object sender, EventArgs e)
        {
            txtDate.Value = DateTime.Now.Date;
            txtTime.Text = DateTime.UtcNow.ToString("t");
        }
    }
}
