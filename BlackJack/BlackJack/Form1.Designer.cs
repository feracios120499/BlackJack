namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelMyMoney = new System.Windows.Forms.Label();
            this.labelEnemyMoney = new System.Windows.Forms.Label();
            this.pictureBoxMinimizate = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.panelMyCards = new System.Windows.Forms.Panel();
            this.panelEnemyCards = new System.Windows.Forms.Panel();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.labelMyMoney);
            this.panelHeader.Controls.Add(this.labelEnemyMoney);
            this.panelHeader.Controls.Add(this.pictureBoxMinimizate);
            this.panelHeader.Controls.Add(this.pictureBoxClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(763, 41);
            this.panelHeader.TabIndex = 0;
            // 
            // labelMyMoney
            // 
            this.labelMyMoney.AutoSize = true;
            this.labelMyMoney.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyMoney.ForeColor = System.Drawing.Color.White;
            this.labelMyMoney.Location = new System.Drawing.Point(150, 9);
            this.labelMyMoney.Name = "labelMyMoney";
            this.labelMyMoney.Size = new System.Drawing.Size(88, 21);
            this.labelMyMoney.TabIndex = 2;
            this.labelMyMoney.Text = "Me:1000$";
            // 
            // labelEnemyMoney
            // 
            this.labelEnemyMoney.AutoSize = true;
            this.labelEnemyMoney.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnemyMoney.ForeColor = System.Drawing.Color.White;
            this.labelEnemyMoney.Location = new System.Drawing.Point(12, 9);
            this.labelEnemyMoney.Name = "labelEnemyMoney";
            this.labelEnemyMoney.Size = new System.Drawing.Size(113, 21);
            this.labelEnemyMoney.TabIndex = 2;
            this.labelEnemyMoney.Text = "Enemy:1000$";
            // 
            // pictureBoxMinimizate
            // 
            this.pictureBoxMinimizate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMinimizate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimizate.Image")));
            this.pictureBoxMinimizate.Location = new System.Drawing.Point(679, 0);
            this.pictureBoxMinimizate.Name = "pictureBoxMinimizate";
            this.pictureBoxMinimizate.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxMinimizate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizate.TabIndex = 1;
            this.pictureBoxMinimizate.TabStop = false;
            this.pictureBoxMinimizate.Click += new System.EventHandler(this.pictureBoxMinimizate_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(721, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(42, 41);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Black;
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.numericUpDown1);
            this.panelBottom.Controls.Add(this.buttonStand);
            this.panelBottom.Controls.Add(this.buttonHit);
            this.panelBottom.Controls.Add(this.buttonDeal);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 541);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(763, 57);
            this.panelBottom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bet";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(647, 21);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonStand
            // 
            this.buttonStand.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStand.FlatAppearance.BorderSize = 0;
            this.buttonStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStand.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStand.ForeColor = System.Drawing.Color.White;
            this.buttonStand.Location = new System.Drawing.Point(350, 0);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(175, 57);
            this.buttonStand.TabIndex = 2;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = true;
            this.buttonStand.Visible = false;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            this.buttonStand.MouseEnter += new System.EventHandler(this.buttonDeal_MouseEnter);
            this.buttonStand.MouseLeave += new System.EventHandler(this.buttonDeal_MouseLeave);
            // 
            // buttonHit
            // 
            this.buttonHit.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHit.FlatAppearance.BorderSize = 0;
            this.buttonHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHit.ForeColor = System.Drawing.Color.White;
            this.buttonHit.Location = new System.Drawing.Point(175, 0);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(175, 57);
            this.buttonHit.TabIndex = 1;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            this.buttonHit.Visible = false;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            this.buttonHit.MouseEnter += new System.EventHandler(this.buttonDeal_MouseEnter);
            this.buttonHit.MouseLeave += new System.EventHandler(this.buttonDeal_MouseLeave);
            // 
            // buttonDeal
            // 
            this.buttonDeal.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeal.FlatAppearance.BorderSize = 0;
            this.buttonDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeal.ForeColor = System.Drawing.Color.White;
            this.buttonDeal.Location = new System.Drawing.Point(0, 0);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(175, 57);
            this.buttonDeal.TabIndex = 0;
            this.buttonDeal.Text = "Deal";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            this.buttonDeal.MouseEnter += new System.EventHandler(this.buttonDeal_MouseEnter);
            this.buttonDeal.MouseLeave += new System.EventHandler(this.buttonDeal_MouseLeave);
            // 
            // panelMyCards
            // 
            this.panelMyCards.BackColor = System.Drawing.Color.Transparent;
            this.panelMyCards.Location = new System.Drawing.Point(63, 344);
            this.panelMyCards.Name = "panelMyCards";
            this.panelMyCards.Size = new System.Drawing.Size(626, 156);
            this.panelMyCards.TabIndex = 2;
            // 
            // panelEnemyCards
            // 
            this.panelEnemyCards.BackColor = System.Drawing.Color.Transparent;
            this.panelEnemyCards.Location = new System.Drawing.Point(63, 91);
            this.panelEnemyCards.Name = "panelEnemyCards";
            this.panelEnemyCards.Size = new System.Drawing.Size(626, 156);
            this.panelEnemyCards.TabIndex = 2;
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.BackColor = System.Drawing.Color.Transparent;
            this.labelBet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBet.Location = new System.Drawing.Point(563, 281);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(47, 23);
            this.labelBet.TabIndex = 3;
            this.labelBet.Text = "Bet:";
            this.labelBet.Visible = false;
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.BackColor = System.Drawing.Color.Transparent;
            this.labelPoint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint.Location = new System.Drawing.Point(563, 304);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(63, 23);
            this.labelPoint.TabIndex = 3;
            this.labelPoint.Text = "Point:";
            this.labelPoint.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources._34750167_реалистичная_poker_table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 598);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.panelEnemyCards);
            this.Controls.Add(this.panelMyCards);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxMinimizate;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.Panel panelMyCards;
        private System.Windows.Forms.Panel panelEnemyCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelMyMoney;
        private System.Windows.Forms.Label labelEnemyMoney;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelPoint;
    }
}

