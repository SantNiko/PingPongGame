namespace Contactos
{
    partial class PingPong
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
            this.ms = new System.Windows.Forms.MenuStrip();
            this.msMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msMNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.msLenguages = new System.Windows.Forms.ToolStripMenuItem();
            this.msLEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.msLSpanish = new System.Windows.Forms.ToolStripMenuItem();
            this.pPlayground = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbRacket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ms.SuspendLayout();
            this.pPlayground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacket)).BeginInit();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMenu,
            this.msLenguages});
            this.ms.Location = new System.Drawing.Point(10, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(611, 28);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            // 
            // msMenu
            // 
            this.msMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMNewGame});
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(58, 24);
            this.msMenu.Text = "&Menu";
            // 
            // msMNewGame
            // 
            this.msMNewGame.Name = "msMNewGame";
            this.msMNewGame.Size = new System.Drawing.Size(157, 26);
            this.msMNewGame.Text = "&New Game";
            this.msMNewGame.Click += new System.EventHandler(this.msMNewGame_Click);
            // 
            // msLenguages
            // 
            this.msLenguages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLEnglish,
            this.msLSpanish});
            this.msLenguages.Name = "msLenguages";
            this.msLenguages.Size = new System.Drawing.Size(92, 24);
            this.msLenguages.Text = "&Lenguages";
            // 
            // msLEnglish
            // 
            this.msLEnglish.Name = "msLEnglish";
            this.msLEnglish.Size = new System.Drawing.Size(135, 26);
            this.msLEnglish.Text = "&English";
            this.msLEnglish.Click += new System.EventHandler(this.msLEnglish_Click);
            // 
            // msLSpanish
            // 
            this.msLSpanish.Name = "msLSpanish";
            this.msLSpanish.Size = new System.Drawing.Size(135, 26);
            this.msLSpanish.Text = "&Spanish";
            this.msLSpanish.Click += new System.EventHandler(this.msLSpanish_Click);
            // 
            // pPlayground
            // 
            this.pPlayground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pPlayground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPlayground.Controls.Add(this.lblPoints);
            this.pPlayground.Controls.Add(this.lblScore);
            this.pPlayground.Controls.Add(this.pbBall);
            this.pPlayground.Controls.Add(this.pbRacket);
            this.pPlayground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlayground.Location = new System.Drawing.Point(10, 28);
            this.pPlayground.Name = "pPlayground";
            this.pPlayground.Size = new System.Drawing.Size(611, 475);
            this.pPlayground.TabIndex = 1;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPoints.Location = new System.Drawing.Point(263, 50);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(51, 55);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblScore.Location = new System.Drawing.Point(57, 50);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(176, 55);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: ";
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Red;
            this.pbBall.Location = new System.Drawing.Point(370, 178);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(30, 30);
            this.pbBall.TabIndex = 1;
            this.pbBall.TabStop = false;
            // 
            // pbRacket
            // 
            this.pbRacket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbRacket.Location = new System.Drawing.Point(327, 360);
            this.pbRacket.Name = "pbRacket";
            this.pbRacket.Size = new System.Drawing.Size(200, 20);
            this.pbRacket.TabIndex = 0;
            this.pbRacket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 503);
            this.Controls.Add(this.pPlayground);
            this.Controls.Add(this.ms);
            this.MainMenuStrip = this.ms;
            this.Name = "PingPong";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.pPlayground.ResumeLayout(false);
            this.pPlayground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem msMenu;
        private System.Windows.Forms.ToolStripMenuItem msLenguages;
        private System.Windows.Forms.Panel pPlayground;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.PictureBox pbRacket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ToolStripMenuItem msMNewGame;
        private System.Windows.Forms.ToolStripMenuItem msLEnglish;
        private System.Windows.Forms.ToolStripMenuItem msLSpanish;
    }
}

