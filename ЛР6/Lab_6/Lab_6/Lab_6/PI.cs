using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_6
{
    public partial class PI : Form
    {
        public PI()
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
                SqlCommand command = new SqlCommand("SELECT * FROM Participant_incident", connection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
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
                if (!string.IsNullOrEmpty(textBox1Insert.Text) && !string.IsNullOrEmpty(textBox2Insert.Text) && !string.IsNullOrEmpty(textBox3Insert.Text) &&
                    !string.IsNullOrWhiteSpace(textBox1Insert.Text) && !string.IsNullOrWhiteSpace(textBox2Insert.Text) && !string.IsNullOrWhiteSpace(textBox3Insert.Text))
                {
                    SqlConnection connection = new SqlConnection("Server= LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Participant_incident(ID_incident, ID_participant, ID_attitude) VALUES(@1, @2, @3)", connection);
                    command.Parameters.AddWithValue("1", textBox1Insert.Text);
                    command.Parameters.AddWithValue("2", textBox2Insert.Text);
                    command.Parameters.AddWithValue("3", textBox3Insert.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    MessageBox.Show("Запись успешно добавлена!");
                    textBox1Insert.Clear();
                    textBox2Insert.Clear();
                    textBox3Insert.Clear();
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
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1Update.Text) && !string.IsNullOrEmpty(textBox2Update.Text) && !string.IsNullOrEmpty(textBox3Update.Text) && !string.IsNullOrEmpty(textBox4Update.Text) && !string.IsNullOrEmpty(textBox5Update.Text) &&
                    !string.IsNullOrWhiteSpace(textBox1Update.Text) && !string.IsNullOrWhiteSpace(textBox2Update.Text) && !string.IsNullOrWhiteSpace(textBox3Update.Text) && !string.IsNullOrWhiteSpace(textBox4Update.Text) && !string.IsNullOrWhiteSpace(textBox5Update.Text))
                {
                    SqlConnection connection = new SqlConnection("Server= LAPTOP-235LH2MO\\SQLEXPRESS; Database = Registration of incident; User ID=sa; Password=mssslkova");
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE [Participant_incident] SET ID_incident = @3, ID_participant = @4, ID_attitude = @5 WHERE ID_incident = @1 AND ID_participant = @2", connection);
                    command.Parameters.AddWithValue("1", textBox1Update.Text);
                    command.Parameters.AddWithValue("2", textBox2Update.Text);
                    command.Parameters.AddWithValue("3", textBox3Update.Text);
                    command.Parameters.AddWithValue("4", textBox4Update.Text);
                    command.Parameters.AddWithValue("5", textBox5Update.Text);
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
                    SqlCommand command = new SqlCommand("DELETE FROM Participant_incident WHERE ID_incident = @1 AND ID_participant = @2", connection);
                    command.Parameters.AddWithValue("1", textBox1Delete.Text);
                    command.Parameters.AddWithValue("2", textBox2Delete.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    MessageBox.Show("Запись успешно удалена!");
                    textBox1Delete.Clear();
                    textBox2Delete.Clear();
                }
                else
                    MessageBox.Show("Все поля должны быть заполнены!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                textBox1Delete.Clear();
                textBox2Delete.Clear();
            }
        }
    }
}
