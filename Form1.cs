using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        private int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            timer1.Start();
            RedLight();
        }

        private void GreenLight()
        {
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Green;
        }

        private void YellowLight()
        {
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.Yellow;
            panel3.BackColor = Color.Black;
        }

        private void RedLight()
        {
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Black;
            panel3.BackColor = Color.Black;
        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;

            if (time <= 10)
                RedLight();
            else if ((time > 10) & (time <= 15))
                GreenLight();
            else if ((time >= 15) & (time <= 17))
                YellowLight();
            else
                time = 0;
        }
    }
}
