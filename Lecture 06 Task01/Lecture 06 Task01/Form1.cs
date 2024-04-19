using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_06_Task01
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            clickCount++; 
            labelcounter.Text = clickCount.ToString();
        }
    }
}
