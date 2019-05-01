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
        private int actionCounts;
        private void levelsScroll(object sender, EventArgs e)
        {
            switch (levels.Value)
            {
                case 0:
                    levelName.Text = "Низкий";
                    counter.Text = "1000";
                    actionCounts = 1000;
                    levelTime = DateTime.Now.AddSeconds(1000);
                    break;
                case 1:
                    levelName.Text = String.Format("Средний");
                    counter.Text = "400";
                    actionCounts = 400;
                    levelTime = DateTime.Now.AddSeconds(10);
                    break;
                case 2:
                    levelName.Text = String.Format("Сложный");
                    counter.Text = "250";
                    actionCounts = 250;
                    levelTime = DateTime.Now.AddSeconds(500);
                    break;
            }
        }
        private void GameOver()
        {
            if(actionCounts==0||levelTime== DateTime.MinValue)
            {
                GameOverForm newForm = new GameOverForm();
                newForm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            if (dateTime < levelTime)
            {
                var timeSpan = (levelTime - dateTime);

                label1.Text = string.Format("\r{0:00}", (int)timeSpan.TotalSeconds);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            levels.Refresh();
            timer1.Start();
        }
    }
    public class Timer
    {
       
    }
}
