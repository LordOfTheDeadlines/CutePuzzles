namespace Cute_Pazzle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.levels = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.levelName = new System.Windows.Forms.Label();
            this.puzzle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gallery = new System.Windows.Forms.Button();
            this.gallaryListBox = new System.Windows.Forms.ListBox();
            this.gallaryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerPictureBox = new System.Windows.Forms.PictureBox();
            this.nextSongPictureBox = new System.Windows.Forms.PictureBox();
            this.musicPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.levels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextSongPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(811, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Времени осталось:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Попыток осталось:";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(811, 451);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(40, 17);
            this.counter.TabIndex = 6;
            this.counter.Text = "1000";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightCyan;
            this.startButton.Location = new System.Drawing.Point(668, 535);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // levels
            // 
            this.levels.Location = new System.Drawing.Point(668, 255);
            this.levels.Maximum = 3;
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(351, 56);
            this.levels.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выберите уровень сложности:";
            // 
            // levelName
            // 
            this.levelName.AutoSize = true;
            this.levelName.Location = new System.Drawing.Point(892, 221);
            this.levelName.Name = "levelName";
            this.levelName.Size = new System.Drawing.Size(0, 17);
            this.levelName.TabIndex = 11;
            // 
            // puzzle
            // 
            this.puzzle.Location = new System.Drawing.Point(34, 51);
            this.puzzle.Name = "puzzle";
            this.puzzle.Size = new System.Drawing.Size(520, 520);
            this.puzzle.TabIndex = 12;
            this.puzzle.TabStop = false;
            this.puzzle.Text = "puzzle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Галерея";
            // 
            // gallery
            // 
            this.gallery.BackColor = System.Drawing.Color.LightCyan;
            this.gallery.Location = new System.Drawing.Point(741, 317);
            this.gallery.Name = "gallery";
            this.gallery.Size = new System.Drawing.Size(117, 46);
            this.gallery.TabIndex = 14;
            this.gallery.Text = "Выбрать изображение";
            this.gallery.UseVisualStyleBackColor = false;
            this.gallery.Click += new System.EventHandler(this.gallery_Click);
            // 
            // gallaryListBox
            // 
            this.gallaryListBox.FormattingEnabled = true;
            this.gallaryListBox.ItemHeight = 16;
            this.gallaryListBox.Items.AddRange(new object[] {
            "Котик",
            "Грустная совушка",
            "Лама",
            "Ещё одна совушка",
            "Панда"});
            this.gallaryListBox.Location = new System.Drawing.Point(879, 317);
            this.gallaryListBox.Name = "gallaryListBox";
            this.gallaryListBox.Size = new System.Drawing.Size(155, 148);
            this.gallaryListBox.TabIndex = 19;
            this.gallaryListBox.SelectedIndexChanged += new System.EventHandler(this.gallaryListBox_SelectedIndexChanged);
            // 
            // gallaryLinkLabel
            // 
            this.gallaryLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.gallaryLinkLabel.AutoSize = true;
            this.gallaryLinkLabel.Location = new System.Drawing.Point(876, 472);
            this.gallaryLinkLabel.Name = "gallaryLinkLabel";
            this.gallaryLinkLabel.Size = new System.Drawing.Size(163, 17);
            this.gallaryLinkLabel.TabIndex = 20;
            this.gallaryLinkLabel.TabStop = true;
            this.gallaryLinkLabel.Text = "Загрузить с устройства";
            this.gallaryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GallaryLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cute_Pazzle.Properties.Resources.panic1;
            this.pictureBox1.Location = new System.Drawing.Point(880, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // timerPictureBox
            // 
            this.timerPictureBox.Image = global::Cute_Pazzle.Properties.Resources.timer4;
            this.timerPictureBox.Location = new System.Drawing.Point(655, 242);
            this.timerPictureBox.Name = "timerPictureBox";
            this.timerPictureBox.Size = new System.Drawing.Size(203, 187);
            this.timerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.timerPictureBox.TabIndex = 18;
            this.timerPictureBox.TabStop = false;
            // 
            // nextSongPictureBox
            // 
            this.nextSongPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("nextSongPictureBox.Image")));
            this.nextSongPictureBox.Location = new System.Drawing.Point(98, 3);
            this.nextSongPictureBox.Name = "nextSongPictureBox";
            this.nextSongPictureBox.Size = new System.Drawing.Size(35, 42);
            this.nextSongPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextSongPictureBox.TabIndex = 16;
            this.nextSongPictureBox.TabStop = false;
            this.nextSongPictureBox.Click += new System.EventHandler(this.nextSongPictureBox_Click);
            // 
            // musicPictureBox
            // 
            this.musicPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("musicPictureBox.Image")));
            this.musicPictureBox.Location = new System.Drawing.Point(34, 3);
            this.musicPictureBox.Name = "musicPictureBox";
            this.musicPictureBox.Size = new System.Drawing.Size(44, 42);
            this.musicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.musicPictureBox.TabIndex = 15;
            this.musicPictureBox.TabStop = false;
            this.musicPictureBox.Click += new System.EventHandler(this.musicPictureBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cute_Pazzle.Properties.Resources._75b53a69853253_5bbe0d80ddcb2;
            this.pictureBox2.Location = new System.Drawing.Point(668, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.LightCyan;
            this.resetButton.Location = new System.Drawing.Point(776, 535);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Заново";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(806, 403);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(46, 17);
            this.timeLabel.TabIndex = 22;
            this.timeLabel.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gallaryLinkLabel);
            this.Controls.Add(this.timerPictureBox);
            this.Controls.Add(this.gallaryListBox);
            this.Controls.Add(this.nextSongPictureBox);
            this.Controls.Add(this.musicPictureBox);
            this.Controls.Add(this.gallery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.puzzle);
            this.Controls.Add(this.levelName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.levels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextSongPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TrackBar levels;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelName;
        private System.Windows.Forms.GroupBox puzzle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gallery;
        private System.Windows.Forms.PictureBox musicPictureBox;
        private System.Windows.Forms.PictureBox nextSongPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox timerPictureBox;
        private System.Windows.Forms.ListBox gallaryListBox;
        private System.Windows.Forms.LinkLabel gallaryLinkLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label timeLabel;
    }
}

