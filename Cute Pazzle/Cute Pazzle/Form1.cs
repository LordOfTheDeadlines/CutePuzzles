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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            levels.Scroll += levelsScroll;
            
        }
        
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
                    label1.Text = "1000";
                    current = 4;
                    break;
                case 1:
                    levelName.Text = "Средний";
                    counter.Text = "400";
                    actionCounts = 400;
                    levelTime = DateTime.Now.AddSeconds(750);
                    label1.Text = "750";
                    current = 16;
                    break;
                case 2:
                    levelName.Text = "Сложный";
                    counter.Text = "250";
                    actionCounts = 250;
                    levelTime = DateTime.Now.AddSeconds(5);
                    label1.Text = "5";
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
       
        private void CreateBitmapImage2(Image image, Image[] images, int index, int numRow, int numColumn, int unitX, int unitY)
        {

            images[index] = new Bitmap(unitX,unitY);
            Graphics picture = Graphics.FromImage(images[index]);
            picture.Clear(Color.Purple);
            picture.DrawImage(image, 
                new Rectangle(0, 0, unitX, unitY),
                new Rectangle(unitX*(index%numColumn),unitY*(index/numRow),unitX,unitY),
                GraphicsUnit.Pixel);
            picture.Flush();
        }
        PictureBox[] picBoxes = null;
        Image[] images = null;
       
       
        private void startButton_Click(object sender, EventArgs e)
        {
            timer2.Start();
            CreateLevel(current);
        }

        private void Random(int[] arr)//перемешивает кусочки пазла
        {
            Random random = new Random();
            int l = arr.Length;
            while (l > 1)
            {
                int n = random.Next(l);
                l--;
                int copy = arr[l];
                arr[l] = arr[n];
                arr[n] = copy;
            }
        }
        private void CreateLevel(int levelNum)
        {
            int currentLevel = levelNum;
            if (picBox!=null)
            {
                puzzle.Controls.Remove(picBox);
                picBox.Dispose();
                picBox = null;
            }
            if(picBoxes==null)
            {
                images = new Image[currentLevel];
                picBoxes = new PictureBox[currentLevel];
            }
           
           
            int numRow = (int)Math.Sqrt(currentLevel);
            int numColumn = numRow;
            int unitX = puzzle.Width / numRow;
            int unitY = puzzle.Height / numColumn;
            int[] indexArr = new int[currentLevel];

            for (int i = 0; i < currentLevel; i++)
            {
                indexArr[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new PictureBox();
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

                CreateBitmapImage2(image, images, i, numRow, numColumn, unitX, unitY);
                picBoxes[i].Location = new Point(unitX * (i % numColumn), unitY * (i / numColumn));
                if (!puzzle.Controls.Contains(picBoxes[i])) puzzle.Controls.Add(picBoxes[i]);
            }

            Random(indexArr);
            for (int i = 0; i < currentLevel; i++)
                picBoxes[i].Image = images[indexArr[i]];
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

      

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            var dateTime = DateTime.Now;
            if (dateTime < levelTime)
            {
                var timeSpan = levelTime - dateTime;
                if(timeSpan.Seconds!=0)
                label1.Text =string.Format("{0:00}", (int)timeSpan.TotalSeconds);
                else
                {
                    ////timer2.Stop();
                    //this.Hide();
                    //GameOverForm gameOver = new GameOverForm();
                    //gameOver.Show();
                }
            }
            
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
    }
}
