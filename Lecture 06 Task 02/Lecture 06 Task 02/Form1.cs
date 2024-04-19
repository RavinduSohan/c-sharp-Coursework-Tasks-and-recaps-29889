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

namespace Lecture_06_Task_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string batch = txtBatch.Text.Trim();
            string program = txtDegree.Text.Trim();

           
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(batch) || string.IsNullOrEmpty(program))
            {
                
                lblError.Text = "Please fill in all fields.";
            }
            else
            {
               
                MessageBox.Show($"Name: {name}\nBatch: {batch}\nDegree Program: {program}", "User Information");

                
                lblError.Text = "";
            }
        }
    }
}
