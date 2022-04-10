using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birincisol, ikincisol, ucuncusol,dorduncusol = 0;
        int bak = 0;
        Random rd = new Random();
        Point pt = new Point();
        int bakiyeson = 0;
        int sure = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.ReadOnly = true;
            label20.Visible = false;
            button1.Enabled = false;
          
            birincisol = pictureBox1.Left;
            ikincisol = pictureBox2.Left;
            ucuncusol = pictureBox3.Left;
            dorduncusol = pictureBox4.Left;

            comboBox1.Items.Add("1 Şahmerdan");
            comboBox1.Items.Add("2 Demirkırat");
            comboBox1.Items.Add("3 Akgül");
            comboBox1.Items.Add("4 Karadut");

            comboBox1.SelectedIndex = 0;
            numericUpDown1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           timer1.Enabled = true;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int kazanan=0;
            timer2.Start();
            timer2.Enabled = true;
         
            int batgenis = pictureBox1.Width;
            int iatgenis = pictureBox2.Width;
            int uatgenis = pictureBox3.Width;
            int datgenis = pictureBox4.Width;
            
            pictureBox1.Left += rd.Next(1, 11);
            pictureBox2.Left += rd.Next(1, 11);
            pictureBox3.Left += rd.Next(1, 11);
            pictureBox4.Left += rd.Next(1, 11);
            int bitiscizgi = label6.Left;
            
            if (pictureBox1.Left+batgenis>=bitiscizgi)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("KAZANAN BİRİNCİ AT" + " " +comboBox1.Items[0]);
                button1.Enabled = false;
                kazanan=0;
                label22.Visible = false;
               
            }
            if (pictureBox2.Left + iatgenis >= bitiscizgi)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("KAZANAN İKİNCİ AT"+" "+comboBox1.Items[1]);
                button1.Enabled = false;
                 kazanan=1;
                 label22.Visible = false;
            }
            if (pictureBox3.Left + uatgenis >= bitiscizgi)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("KAZANAN ÜÇÜNCÜ AT" +" "+ comboBox1.Items[2]);
                button1.Enabled = false;
                 kazanan=2;
                label22.Visible = false;
            }
            if (pictureBox4.Left + datgenis >= bitiscizgi)
            {
                timer1.Stop();
                timer1.Enabled = false;
                MessageBox.Show("KAZANAN DÖRDÜNCÜ AT" +" "+ comboBox1.Items[3]);
                button1.Enabled = false;
                kazanan=3;
                label22.Visible = false;
               
            }
           
            if (timer1.Enabled==true)
            {
               
                button3.Enabled = false;
                button1.Enabled = false;

            }
            else

            {
                timer2.Stop();
                timer2.Enabled = false;
                sure = 0;
                button3.Enabled = true;
                label22.Text = "AT YARIŞI BİLGİ EKRANI";
                if (comboBox1.SelectedIndex == kazanan)
                {
                    label20.Visible = true;
                    label20.Text = "kazandın";
                    bakiyeson = bak * 2;
                    numericUpDown1.Value = Convert.ToInt16(bakiyeson);
                   
                }
                else
                {
                    label20.Visible = true;
                    label20.Text = "kaybettin";
                    bakiyeson = bak * 0;
                    textBox1.Text = bakiyeson.ToString();
                  
                    label22.Text = "AT YARIŞI BİLGİ EKRANI";
                    numericUpDown1.Value = Convert.ToInt16(bakiyeson);
                }
       
            }

            if (pictureBox4.Left + datgenis > pictureBox3.Left + datgenis && pictureBox4.Left + datgenis > pictureBox2.Left + datgenis && pictureBox4.Left + datgenis > pictureBox1.Left + datgenis )
            {
                label22.Text = "karadut koptu geliyor";
            }
            else if (pictureBox3.Left + datgenis+5 > pictureBox4.Left + datgenis && pictureBox3.Left + datgenis+5 > pictureBox2.Left + datgenis && pictureBox3.Left + datgenis+5 > pictureBox1.Left + datgenis)
            {
                label22.Text = "Akgül 5 adım öne önde";
            }

            else if (pictureBox2.Left + datgenis > pictureBox4.Left + datgenis && pictureBox2.Left + datgenis > pictureBox3.Left + datgenis && pictureBox2.Left + datgenis > pictureBox1.Left + datgenis)
            {
                label22.Text = "Demirkırat şuan birinci";
            }
            else
            {
                label22.Text = "Şahmerdan ezdi geçti";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label12.Text = "Süre";
            label12.BackColor = Color.Gold;
            pt.X = 1;
            pt.Y = 12;
           pictureBox1.Location = pt;

           pt.X = 1;
           pt.Y = 119;
           pictureBox2.Location = pt;

           pt.X = 1;
           pt.Y = 226;
           pictureBox3.Location = pt;

           pt.X = 1;
           pt.Y = 328;
           pictureBox4.Location = pt;

            numericUpDown1.Enabled=true;
       
            comboBox1.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = false;
          
            numericUpDown1.Value=0;

            comboBox1.SelectedIndex = 0;
            label20.Text = "DURUM:";
            label20.Text = string.Empty;
        
            label22.Visible = true;
            label22.Text = "AT YARIŞI BİLGİ EKRANI";
            textBox1.Text = "Bakiye:";
            numericUpDown1.Value = 0;

            if (bakiyeson>0)
            {
              
                numericUpDown1.Value = Convert.ToInt16(bakiyeson);

            }
            else
            {
                numericUpDown1.Value = Convert.ToInt16(bakiyeson);
              //  numericUpDown1.DownButton();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (comboBox1.SelectedIndex!=-1 && numericUpDown1.Value!=0)
            {

                button2.Enabled = false;
                button1.Enabled = true;
                comboBox1.Enabled = false;
                numericUpDown1.Enabled = false;

                bak = Convert.ToInt16(numericUpDown1.Value);
                textBox1.Text ="Bakiye:"+bak.ToString()+" TL";
              
            }
            else
            {
                textBox1.Text = "Miktar Arttır";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure++;
            label12.Text = sure.ToString();
        }

      
        
    }
}