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

        CuteTimer cuteTimer = new CuteTimer();

        private DateTime levelTime = DateTime.Now.AddSeconds(1000);
        private int actionCounts = 1000;
        int current = 4;
        private void levelsScroll(object sender, EventArgs e)//установка уровня сложности
        {
            switch (levels.Value)
            {
                case 0:
                    levelName.Text = "Низкий";
                    counter.Text = "1000";
                    actionCounts = 1000;
                    levelTime = DateTime.Now.AddSeconds(1000);
                    current = 4;
                    break;
                case 1:
                    levelName.Text = "Средний";
                    counter.Text = "400";
                    actionCounts = 400;
                    levelTime = DateTime.Now.AddSeconds(750);
                    current = 16;
                    break;
                case 2:
                    levelName.Text = "Сложный";
                    counter.Text = "250";
                    actionCounts = 250;
                    levelTime = DateTime.Now.AddSeconds(500);
                    current =36;
                    break;
            }
        }

        Image image;
        OpenFileDialog openFileDialog = null;
        PictureBox picBox = null;

        private void gallery_Click(object sender, EventArgs e)//выбор изображения для пазла
        {
            if (openFileDialog == null) openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = CreateBitmapImage(Image.FromFile(openFileDialog.FileName));
                if (picBox == null)
                {
                    picBox = new PictureBox();
                    picBox.Height = puzzle.Height;
                    picBox.Width = puzzle.Width;
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    puzzle.Controls.Add(picBox);
                }
                picBox.Image = image;
            }
        }

        private Bitmap CreateBitmapImage(Image image)
        {

            Bitmap bitmap = new Bitmap(puzzle.Width, puzzle.Height);
            Graphics picture = Graphics.FromImage(bitmap);
            picture.Clear(Color.Purple);
            picture.DrawImage(image, new Rectangle(0, 0, puzzle.Width, puzzle.Height));
            picture.Flush();
            return bitmap;
        }

        PictureBox[] picBoxes = null;
        Image[] images = null;
       
       
        private void startButton_Click(object sender, EventArgs e)
        { 
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
            if (actionCounts == 0)
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

    
    public class CuteBitmap 
    {
        private int height;
        private int width;

        public CuteBitmap(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private void CreateLevel()
        {

        }
       

        private void Random(int[] arr)//перемешивает кусочки пазла
        {

        }
    }

    public class CuteTimer
    {
        public void CuteTimerTick(object sender, EventArgs e, DateTime levelTime, Label label)
        {
            var dateTime = new DateTime();
            if (dateTime < levelTime)
            {
                var time = (levelTime - dateTime);

                label.Text = string.Format("\r{0:00}", (int)time.TotalSeconds);
            }
        }

        private void TimeOver(TimeSpan time)
        {
            if(time==TimeSpan.Zero)
            {
                GameOverForm newForm = new GameOverForm();
                newForm.Show();
            }
        }
    }
}
