using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_6
{
    public partial class Decision : Form
    {
        public Decision()
        {
            InitializeComponent();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOutput.Rows.Clear();
                SqlConnection connection = new SqlConnection("Server = LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Incident_decision", connection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[2]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                }
                reader.Close();
                command.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
                connection = null;
                foreach (string[] s in data)
                    dataGridViewOutput.Rows.Add(s);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            SetVisibleCore(false);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1Insert.Text) && !string.IsNullOrEmpty(textBox2Insert.Text) &&
                    !string.IsNullOrWhiteSpace(textBox1Insert.Text) && !string.IsNullOrWhiteSpace(textBox2Insert.Text))
                {
                    SqlConnection connection = new SqlConnection("Server= LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Incident_decision(ID_decision,Status_decision) VALUES(@1, @2)", connection);
                    command.Parameters.AddWithValue("1", textBox1Insert.Text);
                    command.Parameters.AddWithValue("2", textBox2Insert.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    MessageBox.Show("Запись успешно добавлена!");
                    textBox1Insert.Clear();
                    textBox2Insert.Clear();
                }
                else
                    MessageBox.Show("Все поля должны быть заполнены!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                textBox1Insert.Clear();
                textBox2Insert.Clear();
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1Update.Text) && !string.IsNullOrEmpty(textBox2Update.Text) && !string.IsNullOrEmpty(textBox3Update.Text) &&
                    !string.IsNullOrWhiteSpace(textBox1Update.Text) && !string.IsNullOrWhiteSpace(textBox2Update.Text) && !string.IsNullOrWhiteSpace(textBox3Update.Text))
                {
                    SqlConnection connection = new SqlConnection("Server= LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE [Incident_decision] SET ID_decision = @2,Status_decision = @3 WHERE ID_decision = @1", connection);
                    command.Parameters.AddWithValue("1", textBox1Update.Text);
                    command.Parameters.AddWithValue("2", textBox2Update.Text);
                    command.Parameters.AddWithValue("3", textBox3Update.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    MessageBox.Show("Запись успешно изменена!");
                    textBox1Update.Clear();
                    textBox2Update.Clear();
                    textBox3Update.Clear();
                }
                else
                    MessageBox.Show("Все поля должны быть заполнены!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                textBox1Update.Clear();
                textBox2Update.Clear();
                textBox3Update.Clear();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1Delete.Text) && !string.IsNullOrWhiteSpace(textBox1Delete.Text))
                {
                    SqlConnection connection = new SqlConnection("Server= LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Incident_decision WHERE ID_decision = @id", connection);
                    command.Parameters.AddWithValue("id", textBox1Delete.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    MessageBox.Show("Запись успешно удалена!");
                    textBox1Delete.Clear();
                }
                else
                    MessageBox.Show("Все поля должны быть заполнены!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                textBox1Delete.Clear();
            }
        }
    }
}
