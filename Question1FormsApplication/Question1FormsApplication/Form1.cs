using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1FormsApplication
{
    public partial class Form1 : Form
    {
        public static string studentNumber = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentNumber = textBox1.Text;
            //hide Form1
            this.Hide();
            //create instance of Form2
            var f2 = new Form2();
            //show form2
            f2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
