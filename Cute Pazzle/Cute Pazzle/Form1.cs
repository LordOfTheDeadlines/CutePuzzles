using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cute_Pazzle
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            levels.Scroll += levelsScroll;
        }
        private DateTime levelTime;
        private void levelsScroll(object sender, EventArgs e)
        {
            switch (levels.Value)
            {
                case 0:
                    levelName.Text = "Низкий";
                    counter.Text = "1000";
                    levelTime = DateTime.Now.AddMinutes(20);
                    break;
                case 1:
                    levelName.Text = String.Format("Средний");
                    counter.Text = "400";
                    levelTime = DateTime.Now.AddMinutes(15);
                    break;
                case 2:
                    levelName.Text = String.Format("Сложный");
                    counter.Text = "250";
                    levelTime = DateTime.Now.AddMinutes(10);
                    break;
            }
        }

#region
        private void timer1_Tick(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            if (dateTime < levelTime)
            {
                var timeSpan = (levelTime - dateTime);

                label1.Text = string.Format("\r{0:00}:{1:00}:{2:00}", (int)timeSpan.TotalHours, (int)timeSpan.TotalMinutes,
                                  (int)timeSpan.TotalSeconds);
            }
            else
            {
                button1_Click(null, EventArgs.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!timer1.Enabled)
            {
                levelTime = DateTime.Now.AddMinutes(1);
            }
            timer1.Enabled = !timer1.Enabled;
            button1.Text = timer1.Enabled ? "Stop" : "Start";
        }
        #endregion

        private void startGame_Click(object sender, EventArgs e)
        {

        }
    }
    public class Timer
    {
       
    }
}
