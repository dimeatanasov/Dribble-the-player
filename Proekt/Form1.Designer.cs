namespace Proekt
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lineBottom = new System.Windows.Forms.PictureBox();
            this.lineTop = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playerTop = new System.Windows.Forms.PictureBox();
            this.playerBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lineBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 12);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(152, 37);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lineBottom
            // 
            this.lineBottom.Image = global::Proekt.Properties.Resources.line;
            this.lineBottom.Location = new System.Drawing.Point(0, 548);
            this.lineBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineBottom.Name = "lineBottom";
            this.lineBottom.Size = new System.Drawing.Size(932, 12);
            this.lineBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineBottom.TabIndex = 5;
            this.lineBottom.TabStop = false;
            // 
            // lineTop
            // 
            this.lineTop.Image = global::Proekt.Properties.Resources.line;
            this.lineTop.Location = new System.Drawing.Point(0, 0);
            this.lineTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineTop.Name = "lineTop";
            this.lineTop.Size = new System.Drawing.Size(908, 12);
            this.lineTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lineTop.TabIndex = 4;
            this.lineTop.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::Proekt.Properties.Resources.ball__2_;
            this.ball.Location = new System.Drawing.Point(15, 233);
            this.ball.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(83, 75);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // playerTop
            // 
            this.playerTop.Image = global::Proekt.Properties.Resources.player;
            this.playerTop.Location = new System.Drawing.Point(346, -51);
            this.playerTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerTop.Name = "playerTop";
            this.playerTop.Size = new System.Drawing.Size(80, 190);
            this.playerTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerTop.TabIndex = 2;
            this.playerTop.TabStop = false;
            // 
            // playerBottom
            // 
            this.playerBottom.Image = global::Proekt.Properties.Resources.player;
            this.playerBottom.Location = new System.Drawing.Point(628, 324);
            this.playerBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerBottom.Name = "playerBottom";
            this.playerBottom.Size = new System.Drawing.Size(95, 267);
            this.playerBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerBottom.TabIndex = 1;
            this.playerBottom.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(845, 556);
            this.Controls.Add(this.lineBottom);
            this.Controls.Add(this.lineTop);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playerTop);
            this.Controls.Add(this.playerBottom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Game C#";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.lineBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox playerBottom;
        private System.Windows.Forms.PictureBox playerTop;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox lineTop;
        private System.Windows.Forms.PictureBox lineBottom;
    }
}

