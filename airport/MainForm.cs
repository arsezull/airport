using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            GameTime.Interval = 60000;
            GameTime.Enabled = true;

            BtnRun.Enabled = false;
            BtnPause.Enabled = true;
            BtnXRun.Enabled = true;
            BtnXXRun.Enabled = true;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            GameTime.Enabled = false;
            
            BtnRun.Enabled = true;
            BtnPause.Enabled = false;
            BtnXRun.Enabled = true;
            BtnXXRun.Enabled = true;
        }

        private void BtnXRun_Click(object sender, EventArgs e)
        {
            GameTime.Interval = 1000;
            GameTime.Enabled = true;

            BtnRun.Enabled = true;
            BtnPause.Enabled = true;
            BtnXRun.Enabled = false;
            BtnXXRun.Enabled = true;
        }

        private void BtnXXRun_Click(object sender, EventArgs e)
        {
            GameTime.Interval = 10;
            GameTime.Enabled = true;

            BtnRun.Enabled = true;
            BtnPause.Enabled = true;
            BtnXRun.Enabled = true;
            BtnXXRun.Enabled = false;
        }

        private void GameTime_Tick(object sender, EventArgs e)
        {
            int minute = Int32.Parse(TextMinutes.Text) + 1;
            if (minute == 60)
            {
                minute = 0;
                int hour = Int32.Parse(TextHours.Text) + 1;
                if (hour == 24)
                {
                    hour = 0;
                    TextDays.Text = String.Format("{0,2:D2}", Int32.Parse(TextDays.Text) + 1); ;
                }
                TextHours.Text = String.Format("{0,2:D2}", hour);
            }
            TextMinutes.Text = String.Format("{0,2:D2}", minute);

            ////////////////////////////////////
            //// проверка начала нового дня ////
            ////////////////////////////////////
            if ((TextHours.Text == "00") && (TextMinutes.Text == "00"))
            {
                //события смены дня
            }

            ///////////////////////////
            //// проверка прибытия ////
            ///////////////////////////

            //////////////////////////////
            //// проверка отправления ////
            //////////////////////////////
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            BtnRun.Enabled = true;
            BtnPause.Enabled = false;
            BtnXRun.Enabled = true;
            BtnXXRun.Enabled = true;
            BtnRestart.Enabled = true;
            BtnExit.Enabled = true;
            BtnStartGame.Enabled = false;
            MyCompanyPanel.Enabled = true;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            BtnRun.Enabled = true;
            BtnPause.Enabled = false;
            BtnXRun.Enabled = true;
            BtnXXRun.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            BtnRun.Enabled = false;
            BtnPause.Enabled = false;
            BtnXRun.Enabled = false;
            BtnXXRun.Enabled = false;
            BtnRestart.Enabled = false;
            BtnExit.Enabled = false;
            BtnStartGame.Enabled = true;
            MyCompanyPanel.Enabled = false;
        }
    }
}
