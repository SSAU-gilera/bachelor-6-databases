﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab_6
{
    public partial class Type : Form
    {
        public Type()
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
                SqlCommand command = new SqlCommand("SELECT * FROM Type_of_incident", connection);
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
                    SqlCommand command = new SqlCommand("INSERT INTO Type_of_incident(ID_type,Name_type) VALUES(@1, @2)", connection);
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
                    SqlCommand command = new SqlCommand("UPDATE [Type_of_incident] SET ID_type = @2, Name_type = @3 WHERE ID_type = @1", connection);
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
                    SqlCommand command = new SqlCommand("DELETE FROM Type_of_incident WHERE ID_type = @id", connection);
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
