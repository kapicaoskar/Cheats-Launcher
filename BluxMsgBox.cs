using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BluxScript
{
    public partial class BluxMsgBox : Form
    {


        public BluxMsgBox(string title, string message, int fontsize)
        {
            InitializeComponent();
            label1.Text = title;
            label2.Text = message;
            label2.Font = new Font(label2.Font.Name, fontsize);
        }



        private void label3_Click(object sender, EventArgs e)
        {
            Opacity = 100;      //first the opacity is 0

            t2.Interval = 30;  //we'll increase the opacity every 10ms
            t2.Tick += new EventHandler(fadeOut);  //this calls the function that changes opacity 
            t2.Start();


        }



        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(41, 0, 195);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }


        Timer t1 = new Timer();
        Timer t2 = new Timer();
        private void BluxMsgBox_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 30;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                t2.Stop();   //this stops the timer if the form is completely displayed
                this.Hide();
            }
            else
            {
                Opacity -= 0.05;
            }



        }


    }
}
