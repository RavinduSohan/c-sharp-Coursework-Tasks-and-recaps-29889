using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_08_Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SAD Marks selected");
        }

        private void btnCSharp_Click(object sender, EventArgs e)
        {
            
            CSharp cSharpMarksForm = new CSharp();
            cSharpMarksForm.ShowDialog();
        }

        
    }
}
