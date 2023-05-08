namespace TREX_endless_runner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            trex = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            textScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // trex
            // 
            trex.Image = Properties.Resources.running;
            trex.Location = new Point(89, 361);
            trex.Name = "trex";
            trex.Size = new Size(40, 43);
            trex.SizeMode = PictureBoxSizeMode.AutoSize;
            trex.TabIndex = 1;
            trex.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.obstacle_1;
            pictureBox3.Location = new Point(370, 358);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.obstacle_2;
            pictureBox4.Location = new Point(564, 371);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // textScore
            // 
            textScore.AutoSize = true;
            textScore.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textScore.Location = new Point(12, 9);
            textScore.Name = "textScore";
            textScore.Size = new Size(106, 24);
            textScore.TabIndex = 4;
            textScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(-6, 404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(913, 50);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(882, 447);
            Controls.Add(pictureBox1);
            Controls.Add(textScore);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(trex);
            Name = "Form1";
            Tag = "obstacle";
            Text = "TREX endless runner";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)trex).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox trex;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label textScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pictureBox1;
    }
}