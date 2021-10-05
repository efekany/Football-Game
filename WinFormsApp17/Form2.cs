using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label6.Text = c.ToString();
            label7.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }

            if(Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label4.Text) == Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            } 

            if(Convert.ToInt32(label7.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if(Convert.ToInt32(label6.Text) > Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.Enabled = false;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label21.Text = a.ToString();
            label18.Text = b.ToString();
            label12.Text = c.ToString();
            label11.Text = d.ToString();

            if(Convert.ToInt32(label21.Text) > Convert.ToInt32(label18.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }

            if(Convert.ToInt32(label18.Text) > Convert.ToInt32(label21.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label21.Text) == Convert.ToInt32(label18.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if(Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            
            if(Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label11.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.BackColor = Color.Red;
            button3.Enabled = false;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label31.Text = a.ToString();
            label30.Text = b.ToString();
            label26.Text = c.ToString();
            label25.Text = d.ToString();

            if(Convert.ToInt32(label31.Text) > Convert.ToInt32(label30.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if(Convert.ToInt32(label30.Text) > Convert.ToInt32(label31.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) == Convert.ToInt32(label30.Text))
            {
                gspuan = gspuan + 1;
                tspuan = tspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }

            if(Convert.ToInt32(label26.Text) > Convert.ToInt32(label25.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if(Convert.ToInt32(label25.Text) > Convert.ToInt32(label26.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label26.Text) == Convert.ToInt32(label25.Text))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(labelgspuan.Text) >Convert.ToInt32(labelfbpuan.Text)&&Convert.ToInt32(labelgspuan.Text) >Convert.ToInt32(labeltspuan.Text)&&Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                label35.ForeColor = Color.Red;
                label35.Text = "ŞAMPİYON GALATASARAY!";
                pictureBox1.ImageLocation = "C:\\Users\\efeka\\Desktop\\gs.jpg";

            }
            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                label35.ForeColor = Color.Blue;
                label35.Text = "ŞAMPİYON FENERBAHÇE!";
                pictureBox1.ImageLocation = "C:\\Users\\efeka\\Desktop\\fb.jpg";

            }
            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text))
            {
                label35.ForeColor = Color.White;
                label35.Text = "ŞAMPİYON BEŞİKTAŞ!";
                pictureBox1.ImageLocation = "C:\\Users\\efeka\\Desktop\\bjk.jpg";


            }
            if(Convert.ToInt32(labeltspuan.Text) >Convert.ToInt32(labelfbpuan.Text)&&Convert.ToInt32(labeltspuan.Text) >Convert.ToInt32(labelgspuan.Text)&&Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                label35.ForeColor = Color.Magenta;
                label35.Text = "ŞAMPİYON TRABZONSPOR!";
                pictureBox1.ImageLocation = "C:\\Users\\efeka\\Desktop\\ts.jpg";
            }
        }
    }
}
