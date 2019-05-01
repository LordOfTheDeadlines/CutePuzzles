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
        private void levelsScroll(object sender, EventArgs e)//установка уровня сложности
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
                    levelName.Text = "Средний";
                    counter.Text = "400";
                    actionCounts = 400;
                    levelTime = DateTime.Now.AddSeconds(750);
                    break;
                case 2:
                    levelName.Text = "Сложный";
                    counter.Text = "250";
                    actionCounts = 250;
                    levelTime = DateTime.Now.AddSeconds(500);
                    break;
            }
        }

        //Image image = Image.FromFile();


        private void timer1_Tick(object sender, EventArgs e)//вынести в класс Timer
        {
            var dateTime = DateTime.Now;
            if (dateTime < levelTime)
            {
                var timeSpan = (levelTime - dateTime);

                label1.Text = string.Format("\r{0:00}", (int)timeSpan.TotalSeconds);
            }
        }

       
        PictureBox[] picBoxes = null;
        Image[] images = null;
        // const int easyLevelNum = 4;
       
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //ползунок должен стать недоступным для изменений  
            int current = 4;//зависит от сложности
         
            #region вынести в класс Bitmap как метод
            picBoxes = new PictureBox[current];
            images = new Image[current];
            int numRow = (int)Math.Sqrt(current);
            int numColumn = numRow;
            int unitX = puzzle.Width / numRow;
            int unitY = puzzle.Height / numColumn;
            int[] indexArr = new int[current];

            for(int i=0;i<current;i++)
            {
                indexArr[i] = i;
                if (picBoxes[i] == null) picBoxes[i] = new PictureBox();
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

               // CreateBitmapImage();


            }
            #endregion

        }

        public void OnPuzzleClick(object sender, EventArgs e)
        {

        }
        private void GameOver()
        {
            if (actionCounts == 0 || levelTime == DateTime.MinValue)
            {
                GameOverForm newForm = new GameOverForm();
                newForm.Show();
            }
        }
        private bool IsWin()
        {
            return false;
        }
    }

    public class Bitmap
    {
        private void CreateLevel()
        {

        }
        private Bitmap CreateBitmapImage(Image image)
        {
            Bitmap bitmap = new Bitmap();
            return bitmap;
        }

        private void Random(int[] arr)//перемешивает кусочки пазла
        {

        }
    }
    public class Timer
    {
       
    }
}
