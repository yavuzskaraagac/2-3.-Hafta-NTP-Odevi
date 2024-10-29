namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_ground = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipe = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipeDown = new System.Windows.Forms.PictureBox();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerGameControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ground
            // 
            this.pictureBox_ground.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.pictureBox_ground.Location = new System.Drawing.Point(-5, 556);
            this.pictureBox_ground.Name = "pictureBox_ground";
            this.pictureBox_ground.Size = new System.Drawing.Size(709, 92);
            this.pictureBox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ground.TabIndex = 0;
            this.pictureBox_ground.TabStop = false;
            // 
            // pictureBox_pipe
            // 
            this.pictureBox_pipe.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pictureBox_pipe.Location = new System.Drawing.Point(348, 352);
            this.pictureBox_pipe.Name = "pictureBox_pipe";
            this.pictureBox_pipe.Size = new System.Drawing.Size(100, 208);
            this.pictureBox_pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipe.TabIndex = 0;
            this.pictureBox_pipe.TabStop = false;
            // 
            // pictureBox_pipeDown
            // 
            this.pictureBox_pipeDown.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pictureBox_pipeDown.Location = new System.Drawing.Point(450, -1);
            this.pictureBox_pipeDown.Name = "pictureBox_pipeDown";
            this.pictureBox_pipeDown.Size = new System.Drawing.Size(100, 162);
            this.pictureBox_pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeDown.TabIndex = 0;
            this.pictureBox_pipeDown.TabStop = false;
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.pictureBox_bird.Location = new System.Drawing.Point(54, 224);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(83, 74);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 0;
            this.pictureBox_bird.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORE ";
            // 
            // timerGameControl
            // 
            this.timerGameControl.Enabled = true;
            this.timerGameControl.Interval = 20;
            this.timerGameControl.Tick += new System.EventHandler(this.gameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(699, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_ground);
            this.Controls.Add(this.pictureBox_pipe);
            this.Controls.Add(this.pictureBox_pipeDown);
            this.Controls.Add(this.pictureBox_bird);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_pipeDown;
        private System.Windows.Forms.PictureBox pictureBox_pipe;
        private System.Windows.Forms.PictureBox pictureBox_ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerGameControl;
    }
}

