using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            player.Play();
            timeLabel.Text = "";
            counter.Text = "";
            pictureBox1.Hide();
            timerPictureBox.Hide();
            gallaryListBox.Hide();
            gallaryLinkLabel.Hide();
            resetButton.Hide();
        }

        SoundPlayer player = new SoundPlayer(Properties.Resources.sound1);
        SoundPlayer newPlayer = new SoundPlayer(Properties.Resources.oaoaoaoa);
        private DateTime levelTime;
        private int actionCounts;
        private int current;
        private int sec;
 
        private void levelsScroll(object sender, EventArgs e)//установка уровня сложности
        {
            switch (levels.Value)
            {
                case 0:
                    levelName.Text = "?";
                    timeLabel.Text = "?";
                    counter.Text = "?";
                    break;
                case 1:
                    sec = 45;
                    timeLabel.Text = "45";
                    levelName.Text = "Низкий";
                    counter.Text = "200";
                    actionCounts = 200;
                    levelTime = DateTime.Now.AddSeconds(sec);
                    current = 9;
                    break;
                case 2:
                    sec = 50;
                    timeLabel.Text = "50";
                    levelName.Text = "Средний";
                    counter.Text = "100";
                    actionCounts = 100;
                    levelTime = DateTime.Now.AddSeconds(sec);
                    current = 16;
                    break;
                case 3:
                    sec = 60;
                    timeLabel.Text = "60";
                    levelName.Text = "Сложный";
                    counter.Text = "50";
                    actionCounts = 50;
                    levelTime = DateTime.Now.AddSeconds(sec);
                    current = 25;
                    break;
            }
        }

        Image image;
        OpenFileDialog openFileDialog = null;
        private PictureBox picBox = null;

        private void gallery_Click(object sender, EventArgs e)//выбор изображения для пазла
        {
            gallaryListBox.Show();
            gallaryLinkLabel.Show();
        }

        private void GallaryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//выбор изображения с устройства
        {
            if (openFileDialog == null) openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = CreateBitmapImage(Image.FromFile(openFileDialog.FileName));
                CopyImageInPictureBox();
            }
        }

        private void gallaryListBox_SelectedIndexChanged(object sender, EventArgs e)//выбор изображения из галереи
        {
            switch (gallaryListBox.SelectedIndex)
            {
                case 0:
                    image = CreateBitmapImage(Properties.Resources.image);
                    CopyImageInPictureBox();
                    break;
                case 1:
                    image = CreateBitmapImage(Properties.Resources.sad_owl);
                    CopyImageInPictureBox();
                    break;
                case 2:
                    image = CreateBitmapImage(Properties.Resources.lama);
                    CopyImageInPictureBox();
                    break;
                case 3:
                    image = CreateBitmapImage(Properties.Resources.cute_owl);
                    CopyImageInPictureBox();
                    break;
                case 4:
                    image = CreateBitmapImage(Properties.Resources.Panda);
                    CopyImageInPictureBox();
                    break;
            }
        }

        private void CopyImageInPictureBox()//копируем картинку в pictureBox
        { 
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

        private Bitmap CreateBitmapImage(Image image)
        {
            Bitmap bitmap = new Bitmap(puzzle.Width, puzzle.Height);
            Graphics picture = Graphics.FromImage(bitmap);
            picture.DrawImage(image, new Rectangle(0, 0, puzzle.Width, puzzle.Height));
            return bitmap;
        }

        private void CreateBitmapImage2(Image image, Image[] images, int index, int numRow, int numColumn, int unitX, int unitY)
        {

            images[index] = new Bitmap(unitX, unitY);
            Graphics picture = Graphics.FromImage(images[index]);
            picture.Clear(Color.Purple);
            picture.DrawImage(image,
                new Rectangle(0, 0, unitX, unitY),
                new Rectangle(unitX * (index % numColumn), unitY * (index / numRow), unitX, unitY),
                GraphicsUnit.Pixel);
        }

        PictureBox[] picBoxes = null;//кусочки пазла
        Image[] images = null;//изображения на каждом из кусочков пазла

        private void startButton_Click(object sender, EventArgs e)
        {
            if (levels.Value == 0)
            {
                MessageBox.Show(
                  "Выберите уровень сложности",
                  ":3",
                  MessageBoxButtons.OK);
            }
           else if (picBox == null)
            {
                MessageBox.Show(
                   "Выберите картинку",
                   ":3",
                   MessageBoxButtons.OK);
            }
            else
            {
                timeLabel.Hide();
                gallaryListBox.Hide();
                gallaryLinkLabel.Hide();
                levels.Hide();
                gallery.Hide();
                resetButton.Show();
                timer1.Start();
                CreateLevel(current);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var dateTime = DateTime.Now;
            if (dateTime < levelTime)
            {
                TimeSpan timeSpan = levelTime - dateTime;
                if (timeSpan.Seconds != 0)
                {
                    if (timeSpan.Seconds == 10)
                    {
                        TimePanic();
                    }
                    label1.Text = string.Format("{0:00}", (int)timeSpan.TotalSeconds);
                }
                else
                {
                    Reset();
                    GameOver();
                }
            }
        }

        private void TimePanic()
        {
            player.Stop();
            newPlayer.Play();
            pictureBox1.Show();
            timerPictureBox.Show();
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
            if (first == null)
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
                Reset();
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
            if (IsWin())
            {
                Reset();
                var win = new YouWinForm();
                win.ShowDialog();
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            picBox = null;
            GameOverForm newForm = new GameOverForm();
            newForm.ShowDialog();
        }

        private bool IsWin()
        {
            for (int i = 0; i < current; i++)
            {
                if (((CutePictureBox)picBoxes[i]).ImageIndex != ((CutePictureBox)picBoxes[i]).Index)
                    return false;
            }
            return true;
        }

        private void Reset()
        {
            if (newPlayer.IsLoadCompleted)
            {
                pictureBox1.Hide();
                timerPictureBox.Hide();
                newPlayer.Stop();
                player.Play();
            }
            puzzle.BackgroundImage = image;
            puzzle.Controls.Clear();
            picBox = null;
            picBoxes = null;
            images = null;
            resetButton.Hide();
            levels.Show();
            gallery.Show();
            timer1.Stop();
            levelTime = DateTime.Now.AddSeconds(sec);
        }

        private int pauseClickCount = 0;
        private void musicPictureBox_Click(object sender, EventArgs e)//включить/выключить музыку
        {

            if (pauseClickCount % 2 == 0)
            {
                musicPictureBox.Image = Properties.Resources.musicNo;
                player.Stop();
                pauseClickCount++;
            }
            else
            {
               // image = null;
                musicPictureBox.Image = Properties.Resources.music;
                player.Play();
                pauseClickCount++;
            }
        }

        private int nextSongClickCount = 0;
        private void nextSongPictureBox_Click(object sender, EventArgs e)//смена песни
        {
            switch (nextSongClickCount % 2)
            {
                case 1:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.sound1);
                    player.Play();
                    nextSongClickCount++;
                    break;
                case 0:
                    player.Stop();
                    player = new SoundPlayer(Properties.Resources.sound2);
                    player.Play();
                    nextSongClickCount++;
                    break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
