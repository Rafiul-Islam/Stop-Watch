using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int second = 1;
        int minute = 0;
        int hour = 0;
        int miliSecond = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startButton.Enabled = false;
            stopButton.Enabled = true;
            resumeButton.Enabled = false;
            resetButton.Enabled = false;


        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            startButton.Enabled = false;
            stopButton.Enabled = false;
            resumeButton.Enabled = true;
            resetButton.Enabled = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            miliSecond++;

            if (miliSecond > 10)
            {
                second++;
                miliSecond = 0;
            }

            if (second > 59)
            {
                minute++;
                second = 0;
            }

            if (minute > 59)
            {
                hour++;
                minute = 0;
            }

            label1.Text = hour.ToString() + " : " + minute.ToString() + " : " + second.ToString();
            label2.Text = miliSecond.ToString();


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            second = 00;
            minute = 00;
            hour = 00;
            miliSecond = 00;

            label1.Text = "0 : 0 : 0";
            label2.Text = "00";

            startButton.Enabled = true;
            stopButton.Enabled = false;
            resumeButton.Enabled = false;
            resetButton.Enabled = false;

        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startButton.Enabled = false;
            stopButton.Enabled = true;
            resumeButton.Enabled = false;
            resetButton.Enabled = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            resumeButton.Enabled = false;
            resetButton.Enabled = false;

        }

        private void pauseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
