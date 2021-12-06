using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomnumbercalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
           Random rnd = new Random();
           int uretilensayi = rnd.Next(0, 100);
           label1.Text= Convert.ToString(uretilensayi);

           Random rnda = new Random();
           int usayi = rnda.Next(0,1000);
           label2.Text = Convert.ToString(usayi);

           label1.ForeColor = Color.Red;
           label2.ForeColor = Color.Red;

           label1.Visible = true;
           label2.Visible = true;
           button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
         /* label1.Text = Convert.ToInt32();
            label2.Text = Convert.ToInt32(); */
            panel1.Visible = true;

            double say1, say2,topla,carp,bol,fark;
        
            say1 = Convert.ToDouble(label1.Text);
            say2 = Convert.ToDouble(label2.Text);

            topla = say1 + say2;
            carp = say1 * say2;
            bol = say1 / say2;
            fark = say1 - say2;

            if (say1<say2)
            {
                bol = say2 / say1;
                fark = say2 - say1;
            }

            label4.Text = Convert.ToString(fark);
            label6.Text = Convert.ToString(topla);
            label10.Text = Convert.ToString(carp);
            label8.Text = Convert.ToString(bol);

            label4.ForeColor = Color.Blue;
            label6.ForeColor = Color.Blue;
            label8.ForeColor = Color.Blue;
            label10.ForeColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
