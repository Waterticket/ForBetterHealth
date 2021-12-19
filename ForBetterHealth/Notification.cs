using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForBetterHealth
{
    public partial class Notification : Form
    {
        Timer t1 = new Timer();

        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
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

        private void Notification_Click(object sender, EventArgs e)
        {
            Form1.closeNotification();
            this.Close();
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {
            this.Notification_Click(sender, e);
        }

        private void descLabel_Click(object sender, EventArgs e)
        {
            this.Notification_Click(sender, e);
        }
    }
}
