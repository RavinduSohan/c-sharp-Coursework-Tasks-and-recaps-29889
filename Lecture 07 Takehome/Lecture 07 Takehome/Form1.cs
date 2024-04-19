using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_07_Takehome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUserControl1_Click(object sender, EventArgs e)
        {
            UserControl1 obj = new UserControl1();
            obj.Show();
            this.Hide();
        }

        private void btnUserControl2_Click(object sender, EventArgs e)
        {
            UserControl2 obj = new UserControl2();
            obj.Show();
            this.Hide();
        }
    }
}
