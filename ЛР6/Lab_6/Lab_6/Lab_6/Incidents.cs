using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_6
{
    public partial class Incidents : Form
    {
        public Incidents()
        {
            InitializeComponent();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            SetVisibleCore(false);
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOutput.Rows.Clear();
                SqlConnection connection = new SqlConnection("Server = LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Incident", connection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1Insert.Text) && !string.IsNullOrEmpty(textBox2Insert.Text) && !string.IsNullOrEmpty(textBox3Insert.Text) && !string.IsNullOrEmpty(textBox4Insert.Text) && !string.IsNullOrEmpty(textBox5Insert.Text) &&
                    !string.IsNullOrWhiteSpace(textBox1Insert.Text) && !string.IsNullOrWhiteSpace(textBox2Insert.Text) && !string.IsNullOrWhiteSpace(textBox3Insert.Text) && !string.IsNullOrWhiteSpace(textBox4Insert.Text) && !string.IsNullOrWhiteSpace(textBox5Insert.Text))
                {
                    SqlConnection connection = new SqlConnection("Server= LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Incident(ID_incident, Date, Short_plot, ID_type, ID_decision) VALUES(@1, @2, @3, @4, @5)", connection);
                    command.Parameters.AddWithValue("1", textBox1Insert.Text);
                    command.Parameters.AddWithValue("2", textBox2Insert.Text);
                    command.Parameters.AddWithValue("3", textBox3Insert.Text);
                    command.Parameters.AddWithValue("4", textBox4Insert.Text);
                    command.Parameters.AddWithValue("5", textBox5Insert.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    MessageBox.Show("Запись успешно добавлена!");
                    textBox1Insert.Clear();
                    textBox2Insert.Clear();
                    textBox3Insert.Clear();
                    textBox4Insert.Clear();
                    textBox5Insert.Clear();
                }
                else
                    MessageBox.Show("Все поля должны быть заполнены!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                textBox1Insert.Clear();
                textBox2Insert.Clear();
                textBox3Insert.Clear();
                textBox4Insert.Clear();
                textBox5Insert.Clear();
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1Update.Text) && !string.IsNullOrEmpty(textBox2Update.Text) && !string.IsNullOrEmpty(textBox3Update.Text) && !string.IsNullOrEmpty(textBox4Update.Text) && !string.IsNullOrEmpty(textBox5Update.Text) && !string.IsNullOrEmpty(textBox6Update.Text) &&
                    !string.IsNullOrWhiteSpace(textBox1Update.Text) && !string.IsNullOrWhiteSpace(textBox2Update.Text) && !string.IsNullOrWhiteSpace(textBox3Update.Text) && !string.IsNullOrWhiteSpace(textBox4Update.Text) && !string.IsNullOrWhiteSpace(textBox5Update.Text) && !string.IsNullOrWhiteSpace(textBox6Update.Text))
                {
                    SqlConnection connection = new SqlConnection("Server= LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE [Incident] SET ID_incident = @2, Date = @3, Short_plot = @4, ID_type = @5, ID_decision = @6 WHERE ID_incident = @1", connection);
                    command.Parameters.AddWithValue("1", textBox1Update.Text);
                    command.Parameters.AddWithValue("2", textBox2Update.Text);
                    command.Parameters.AddWithValue("3", textBox3Update.Text);
                    command.Parameters.AddWithValue("4", textBox4Update.Text);
                    command.Parameters.AddWithValue("5", textBox5Update.Text);
                    command.Parameters.AddWithValue("6", textBox6Update.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    MessageBox.Show("Запись успешно изменена!");
                    textBox1Update.Clear();
                    textBox2Update.Clear();
                    textBox3Update.Clear();
                    textBox4Update.Clear();
                    textBox5Update.Clear();
                    textBox6Update.Clear();
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
                textBox4Update.Clear();
                textBox5Update.Clear();
                textBox6Update.Clear();
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
                    SqlCommand command = new SqlCommand("DELETE FROM Incident WHERE ID_incident = @id", connection);
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
