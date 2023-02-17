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
    public partial class Form1 : Form
    {
        public static int count =0;
        public static int WINc = 0;
        bool ans = false;
        public static int drawcount = 0;
        public static int xwincount = 0;
        public static int Owincount = 0;
       
     
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "1";
         int a = xwincount + Owincount + drawcount;
         label10.Text = a.ToString();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            WINc++;
            count++;
            button7.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
            if (WINc == 9)
            {
                draw();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            WINc++;
            count++;
            button1.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
             if (WINc == 9)
            {
                draw();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            WINc++;
            count++;
            button2.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
            if (WINc == 9)
            {
                draw();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            WINc++;
            count++;
            button3.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
             if (WINc == 9)
            {
                draw();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            WINc++;
            count++;
            button5.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
             if (WINc == 9)
            {
                draw();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            WINc++;
            count++;
            button4.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
            if (WINc == 9)
            {
                draw();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            WINc++;
            count++;
            button6.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
            if (WINc == 9)
            {
                draw();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            WINc++;
            count++;
            button8.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
             if (WINc == 9)
            {
                draw();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            WINc++;
            count++;
            button9.Text = getXorO(count);
            if (WINc >= 5)
            {
                winner();
            }
             if (WINc == 9)
            {
                draw();
            }
        }
        public static string getXorO(int a)
        {
            string getXorO = "X";
            if (count % 2 == 0)
            {
                return "O";
            }

            return getXorO;
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        public void draw()
        {
            count = count * 0;
            WINc = WINc * 0;
            MessageBox.Show("Match Draw");
            drawcount = drawcount + 1;
            label7.Text = drawcount.ToString();
            c();
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            
        }
       
        public void  winner()
        {
            
                string b1 = button1.Text;
                string b2 = button2.Text;
                string b3 = button3.Text;
                string b4 = button4.Text;
                string b5 = button5.Text;
                string b6 = button6.Text;
                string b7 = button7.Text;
                string b8 = button8.Text;
                string b9 = button9.Text;
            
                if (b1 =="X"&& b2=="X" && b3 == "X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b1 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                 
                }
                else if (b1 =="X"&& b4=="X" && b7=="X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b1 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();   
                 
                }
                else if (b7 =="X"&& b8=="X" && b9=="X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b7 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b9 =="X" &&b6=="X" &&b3=="X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b9 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b4 == "X" && b5 =="X"&& b6=="X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b4 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b7 =="X"&& b5=="X" && b3 =="X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b7 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b1 =="X"&& b5=="X" &&  b9=="X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b1 + ": Is won the Match");
                    button11.Visible = true;
                    ans = true;
                    count = count * 0;
                    win();
                }
                else if (b2 =="X" &&b5=="X" && b8 == "X")
                {
                    
                    xwincount++;
                    label9.Text = xwincount.ToString();
                    MessageBox.Show(b2+ ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                if (b1 == "O" && b2 == "O" && b3 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b1 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();          
                }
                else if (b1 == "O" && b4 == "O" && b7 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b1 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();          
                }
                else if (b7 == "O" && b8 == "O" && b9 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b7 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b9 == "O" && b6 == "O" && b3 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b9 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b4 == "O" && b5 == "O" && b6 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b4 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b7 == "O" && b5 == "O" && b3 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b7 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b1 == "O" && b5 == "O" && b9 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b1 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
                else if (b2 == "O" && b5 == "O" && b8 == "O")
                {
                    
                    Owincount++;
                    label8.Text = Owincount.ToString();
                    MessageBox.Show(b2 + ": Is won the Match");
                    ans = true;
                    button11.Visible = true;
                    count = count * 0;
                    win();
                }
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }
        public void r3()
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
      
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            count = count * 0;
            WINc = WINc * 0;
            xwincount = xwincount * 0;
            Owincount = Owincount * 0;
            this.Close();

            
          
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        public void win()
        {
          
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            WINc = WINc * 0;
            c();
               
        }
        public void c()
        {
            label1.Visible = false;
            int t = xwincount + Owincount + drawcount+1;
            label10.Text = t.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
