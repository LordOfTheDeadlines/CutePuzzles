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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.levels = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.levelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.puzzle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gallery = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.levels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(811, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 418);
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
            this.levels.Maximum = 2;
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
            this.levelName.Size = new System.Drawing.Size(56, 17);
            this.levelName.TabIndex = 11;
            this.levelName.Text = "Низкий";
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
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(806, 417);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(46, 17);
            this.timerLabel.TabIndex = 15;
            this.timerLabel.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.timerLabel);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.levels)).EndInit();
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
        private System.Windows.Forms.Label timerLabel;
    }
}

