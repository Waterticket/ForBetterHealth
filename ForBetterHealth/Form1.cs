using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ForBetterHealth
{
    public partial class Form1 : Form
    {
        static Notification[] notification;
        static SoundPlayer simpleSound;
        static Screen scrn;
        private static Timer aTimer;

        public Form1()
        {
            InitializeComponent();
            simpleSound = new SoundPlayer(@"C:\Windows\Media\Windows Logon.wav");
            SetTimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void openNotificationButton_Click(object sender, EventArgs e)
        {
            
        }

        public static void closeNotification()
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if(notification[i] != null)
                    notification[i].Close();
            }
            aTimer.Enabled = true;
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new Timer();
            // Hook up the Elapsed event for the timer. 
            aTimer.Interval = (1 * 60 * 60 * 1000);
            aTimer.Tick += new EventHandler(OnTimedEvent);
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, EventArgs e)
        {
            simpleSound.Play();

            notification = new Notification[Screen.AllScreens.Length];
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                scrn = Screen.AllScreens[i];
                notification[i] = new Notification();
                notification[i].StartPosition = FormStartPosition.Manual;
                notification[i].Location = new Point(scrn.Bounds.Right - notification[i].Width, scrn.Bounds.Top + 100);
                notification[i].Show();
            }
            aTimer.Enabled = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
                //Hide();
                //notifyIcon.Visible = true;
            //}
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Show();
            //this.WindowState = FormWindowState.Normal;
            //notifyIcon.Visible = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private void changeTimerStatMenuItem_Click(object sender, EventArgs e)
        {
            if(aTimer.Enabled)
            {
                changeTimerStatMenuItem.Text = "타이머 시작하기";
            }
            else
            {
                changeTimerStatMenuItem.Text = "타이머 정지하기";
            }

            aTimer.Enabled = !aTimer.Enabled;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
