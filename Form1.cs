using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{

        public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.BalloonTipText = "Loading.";
            //notifyIcon1.BalloonTipTitle = "Title";
            //notifyIcon1.ShowBalloonTip(2000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string timeoutput = "";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = label1.Text;
            notifyIcon1.BalloonTipTitle = "The time";
            notifyIcon1.ShowBalloonTip(2000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime nowish = DateTime.Now;
            int roundup = 0;
            int nearfifteen = 0;
            if (nowish.Minute >= 38) { roundup = 1; }
            else { roundup = 0; }
            string strHour = "NaN";
            string strMinute = "NaN";
            string strMorNoonNight = "NaN";

            if (nowish.Minute <= 7 || nowish.Minute > 53) { nearfifteen = 0; }
            else { nearfifteen = 9; }
            
            if (nowish.Minute >7 && nowish.Minute <= 22) { nearfifteen = 1; }
            if (nowish.Minute >22 && nowish.Minute <=37) { nearfifteen = 2; }
            if (nowish.Minute >37 && nowish.Minute <=53) { nearfifteen = 3; }
           
           
            switch(nearfifteen)
            {
                case 0:
                    strMinute = "It's ";
                    break;
                case 1:
                    strMinute = "It's quarter past ";
                    break;
                case 2:
                    strMinute = "It's half past ";
                    break;
                case 3:
                    strMinute = "It's quarter till ";
                    break;
                case 9:
                    strMinute = "Time is broken.";
                    break;
            }

            switch ((nowish.Hour + roundup))
            {
                case 1: 
                    strHour = "one";
                    strMorNoonNight = " in the Morning";
                    break;
                case 2:
                    strHour = "two";
                    strMorNoonNight = " in the Morning";
                    break;
                case 3:
                    strHour = "three";
                    strMorNoonNight = " in the Morning";
                    break;
                case 4:
                    strHour = "four";
                    strMorNoonNight = " in the Morning";
                    break;
                case 5:
                    strHour = "five";
                    strMorNoonNight = " in the Morning";
                    break;
                case 6:
                    strHour = "six";
                    strMorNoonNight = " in the Morning";
                    break;
                case 7:
                    strHour = "seven";
                    strMorNoonNight = " in the Morning";
                    break;
                case 8:
                    strHour = "eight";
                    strMorNoonNight = " in the Morning";
                    break;
                case 9:
                    strHour = "nine";
                    strMorNoonNight = " in the Morning";
                    break;
                case 10:
                    strHour = "ten";
                    strMorNoonNight = " in the Morning";
                    break;
                case 11:
                    strHour = "eleven";
                    strMorNoonNight = " in the Morning";
                    break;
                case 12:
                    strHour = "noon";
                    strMorNoonNight = "";
                    break;
                case 13:
                    strHour = "one";
                    strMorNoonNight = " in the afternoon";
                    break;
                case 14:
                    strHour = "two";
                    strMorNoonNight = " in the afternoon";
                    break;
                case 15:
                    strHour = "three";
                    strMorNoonNight = " in the afternoon";
                    break;
                case 16:
                    strHour = "four";
                    strMorNoonNight = " in the afternoon";
                    break;
                case 17:
                    strHour = "five";
                    strMorNoonNight = " in the afternoon";
                    break;
                case 18:
                    strHour = "six";
                    strMorNoonNight = " in the afternoon";
                    break;
                case 19:
                    strHour = "seven";
                    strMorNoonNight = " in the evening";
                    break;
                case 20:
                    strHour = "eight";
                    strMorNoonNight = " in the evening";
                    break;
                case 21:
                    strHour = "nine";
                    strMorNoonNight = " at night";
                    break;
                case 22:
                    strHour = "ten";
                    strMorNoonNight = " at night";
                    break;
                case 23:
                    strHour = "eleven";
                    strMorNoonNight = " at night";
                    break;
                case 24:
                    strHour = "midnight";
                    strMorNoonNight = "";
                    break;
                default:
                    strHour = nowish.Hour.ToString();
                    break;
            }

            lblTime.Text = strMinute + strHour + strMorNoonNight;
            label1.Text = strMinute + strHour;
            notifyIcon1.Text = strMinute + strHour;
           // output = strMinute + strHour;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
