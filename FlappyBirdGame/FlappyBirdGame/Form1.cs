using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        int pipeSpeed = -8;  // Boruların sola doğru hareket etmesi için negatif hız
        int gravity = 5;
        int jumpForce = 0;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            pictureBox_bird.Top += gravity - jumpForce;

            // Borular sola doğru hareket etsin
            pictureBox_pipe.Left += pipeSpeed;
            pictureBox_pipeDown.Left += pipeSpeed;

            label1.Text = "SCORE: " + score;

            // Zıplama kuvvetini azaltarak kuşun yukarı çıkmasını yavaşlatıyoruz
            if (jumpForce > 0)
            {
                jumpForce--;
            }

            // Borular ekrandan çıktıktan sonra yeniden başa döner ve skor artar
            if (pictureBox_pipe.Left < -150)
            {
                pictureBox_pipe.Left = 800;
                score++;
            }
            if (pictureBox_pipeDown.Left < -100)
            {
                pictureBox_pipeDown.Left = 950;
                score++;
            }

            // Çarpışma kontrolü
            if (pictureBox_bird.Bounds.IntersectsWith(pictureBox_pipe.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_pipeDown.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_ground.Bounds) ||
                pictureBox_bird.Top < -25)
            {
                EndGame();
            }
        }

        public void EndGame()
        {
            timerGameControl.Stop();
            label1.Text = "GAME OVER!";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumpForce = 15; // Zıplama kuvvetini ayarla
            }
        }

        private void game_up(object sender, KeyEventArgs e)
        {
            // Space bırakıldığında herhangi bir işlem yapılmıyor
        }
    }

}
