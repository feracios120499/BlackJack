using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        Gamer me = new Gamer();
        Gamer enemy = new Gamer();
        public Form1()
        {
            InitializeComponent();
            me.ChangeMoney += ChangeMyMoney;
            enemy.ChangeMoney += ChangeEnemyMoney;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.numericUpDown1.Maximum = me.Money;
        }

        private void buttonDeal_MouseEnter(object sender, EventArgs e)
        {
            var button = (sender as Button);
            button.FlatAppearance.BorderColor = Color.White;
            button.FlatAppearance.BorderSize = 2;
        }

        private void buttonDeal_MouseLeave(object sender, EventArgs e)
        {
            var button = (sender as Button);
            button.FlatAppearance.BorderColor = Color.White;
            button.FlatAppearance.BorderSize = 0;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ChangeMyMoney(object sender,GamerEventArgs e)
        {
            labelMyMoney.Text = $"Me:{e.Money}$";
        }
        private void ChangeEnemyMoney(object sender, GamerEventArgs e)
        {
            labelEnemyMoney.Text = $"Enemy:{e.Money}$";
        }

        private void buttonDeal_Click(object sender, EventArgs e)
        {
            buttonDeal.Visible = false;
            buttonHit.Visible = true;
            buttonStand.Visible = true;
            if (enemy.Money < numericUpDown1.Value)
            {
                game.SetBet(Convert.ToInt32(numericUpDown1.Value) + enemy.Money);
                enemy.Money = 0;
                me.Money -= Convert.ToInt32(numericUpDown1.Value);
            }
            else
            {
                game.SetBet(Convert.ToInt32(numericUpDown1.Value) * 2);
                me.Money -= Convert.ToInt32(numericUpDown1.Value);
                enemy.Money-= Convert.ToInt32(numericUpDown1.Value);
            }
            labelBet.Visible = true;
            labelBet.Text = $"Bet:{game.GetBet()}";
            labelPoint.Visible = true;
            
            Card card;
            card = game.GetCard();
            me.SetCard(card);
            AddPicture(card.ImageCard, panelMyCards);
            card = game.GetCard();
            me.SetCard(game.GetCard());
            AddPicture(card.ImageCard, panelMyCards);
            labelPoint.Text = $"Point:{me.GetPoints()}";
            if (me.GetPoints() == 21)
            {
                MessageBox.Show("You win", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                me.Money += game.GetBet();
                NewGame();
            }
        }
        private void AddPicture(Image image,Panel panel)
        {
            PictureBox picture = new PictureBox();
            picture.Image = image;
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Dock = DockStyle.Left;
            panel.Controls.Add(picture);
        }
        private void NewGame()
        {
            game.NewGame();
            me.Clear();
            enemy.Clear();
            labelBet.Visible = false;
            buttonDeal.Visible = true;
            buttonHit.Visible = false;
            buttonStand.Visible = false;
            labelPoint.Visible = false;
            panelEnemyCards.Controls.Clear();
            panelMyCards.Controls.Clear();
        }

        private void buttonHit_Click(object sender, EventArgs e)
        {
            Card card;
            card = game.GetCard();
            me.SetCard(card);
            AddPicture(card.ImageCard, panelMyCards);
            if (me.GetPoints() == 21)
            {
                MessageBox.Show("You win", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                me.Money += game.GetBet();
                NewGame();
            }
            if (me.GetPoints() > 21)
            {
                MessageBox.Show("You Lose", "ez!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enemy.Money += game.GetBet();
                NewGame();
            }
            labelPoint.Text = $"Point{me.GetPoints()}";
        }

        private void buttonStand_Click(object sender, EventArgs e)
        {
            Card card;
            card = game.GetCard();
            enemy.SetCard(card);
            AddPicture(card.ImageCard, panelEnemyCards);
            card = game.GetCard();
            enemy.SetCard(game.GetCard());
            AddPicture(card.ImageCard, panelEnemyCards);
            if (enemy.GetPoints() == 21)
            {
                MessageBox.Show("You Lose", "ez!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enemy.Money += game.GetBet();
                NewGame();
            }
            if (enemy.GetPoints() <= 17)
            {
                card = game.GetCard();
                enemy.SetCard(card);
                AddPicture(card.ImageCard, panelEnemyCards);
            }
            if (enemy.GetPoints() <= me.GetPoints())
            {
                MessageBox.Show("You win", "Nice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                me.Money += game.GetBet();
                NewGame();
            }
            else
            {
                MessageBox.Show("You Lose", "ez!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                enemy.Money += game.GetBet();
                NewGame();
            }
        }
    }
}
