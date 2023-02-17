using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            //frm2.ShowDialog();
         }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
