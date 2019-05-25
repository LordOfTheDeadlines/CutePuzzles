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
                    counter.Text = "10";
                    actionCounts = 10;
                    levelTime = DateTime.Now.AddSeconds(15);
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
            timer1.Start();
            CreateLevel(current);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var dateTime = DateTime.Now;
            if (dateTime < levelTime)
            {
                var timeSpan = levelTime - dateTime;
                if (timeSpan.Seconds != 0)
                    label1.Text = string.Format("{0:00}", (int)timeSpan.TotalSeconds);
                else
                {
                    GameOver();
                }
            }

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
            if (picBox != null)
            {
                puzzle.Controls.Remove(picBox);
                picBox.Dispose();
                picBox = null;
            }
            if (picBoxes == null)
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
                    picBoxes[i] = new CutePictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;
                ((CutePictureBox)picBoxes[i]).Index = i;
                CreateBitmapImage2(image, images, i, numRow, numColumn, unitX, unitY);
                picBoxes[i].Location = new Point(unitX * (i % numColumn), unitY * (i / numColumn));
                if (!puzzle.Controls.Contains(picBoxes[i])) puzzle.Controls.Add(picBoxes[i]);
            }

            Random(indexArr);
            for (int i = 0; i < currentLevel; i++)
            {
                picBoxes[i].Image = images[indexArr[i]];
                ((CutePictureBox)picBoxes[i]).ImageIndex = indexArr[i];
            }
        }

        CutePictureBox first = null;
        CutePictureBox second = null;

        public void OnPuzzleClick(object sender, EventArgs e)
        {
            if(first==null)
            {
                first = (CutePictureBox)sender;
                first.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (second == null && actionCounts > 0)
            {
                second = (CutePictureBox)sender;
                second.BorderStyle = BorderStyle.FixedSingle;
                first.BorderStyle = BorderStyle.Fixed3D;
                ChangeImageLocation(first, second);
                actionCounts--;
                counter.Text = (Convert.ToString(actionCounts));
                first = null;
                second = null;
            }
            else 
            {
                GameOver();
            }
        }

        private void ChangeImageLocation(CutePictureBox box1, CutePictureBox box2)
        {
            int index2 = box2.ImageIndex;
            box2.Image = images[box1.ImageIndex];
            box2.ImageIndex = box1.ImageIndex;
            box1.Image = images[index2];
            box1.ImageIndex = index2;
            if(IsWin())
            {
                //timer1.Stop();
                //Hide();
                //var win = new YouWinForm();
                //win.Show();
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            Hide();
            GameOverForm newForm = new GameOverForm();
            newForm.Show();
            
        }

        private bool IsWin()
        {
            for(int i=0; i<current;i++)
            {
                if (((CutePictureBox)picBoxes[i]).ImageIndex != ((CutePictureBox)picBoxes[i]).Index)
                    return false;
            }
            return true;
        }

    }
   
}
