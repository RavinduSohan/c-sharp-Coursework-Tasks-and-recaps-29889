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

namespace Lecture_08_Task_01
{
    public partial class CSharp : Form
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\hp\\Documents\\Student Marks.mdf\";Integrated Security=True;Connect Timeout=30";
        public CSharp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExamination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtCoursework_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtExamination.Text, out int examMarks) && int.TryParse(txtCoursework.Text, out int courseworkMarks))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        connection.Open();

                        string query = "INSERT INTO StudentMarks (ExamMarks, CourseworkMarks) VALUES (@ExamMarks, @CourseworkMarks)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ExamMarks", examMarks);
                        command.Parameters.AddWithValue("@CourseworkMarks", courseworkMarks);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Marks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to save marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
