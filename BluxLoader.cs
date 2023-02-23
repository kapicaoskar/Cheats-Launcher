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
    public partial class BluxLoader : Form
    {
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public BluxLoader()
        {
            InitializeComponent();
        }




        private void label2_Click(object sender, EventArgs e)
        {
            Form msg = new BluxMsgBox("Blux Products", "Exiting Loader!", 10);
            msg.ShowDialog();
            Application.Exit();
        }
    }
}
