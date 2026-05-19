namespace TamagotchiApp
{
    partial class PlayForm
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
            btnWand = new Button();
            btnCatchUp = new Button();
            btnBall = new Button();
            SuspendLayout();
            // 
            // btnWand
            // 
            btnWand.BackgroundImage = Properties.Resources.wand;
            btnWand.BackgroundImageLayout = ImageLayout.Stretch;
            btnWand.Location = new Point(44, 31);
            btnWand.Name = "btnWand";
            btnWand.Size = new Size(200, 200);
            btnWand.TabIndex = 0;
            btnWand.UseVisualStyleBackColor = true;
            btnWand.Click += BtnWand_Click;
            // 
            // btnCatchUp
            // 
            btnCatchUp.BackgroundImage = Properties.Resources.catch_up;
            btnCatchUp.BackgroundImageLayout = ImageLayout.Stretch;
            btnCatchUp.Location = new Point(546, 31);
            btnCatchUp.Name = "btnCatchUp";
            btnCatchUp.Size = new Size(200, 200);
            btnCatchUp.TabIndex = 0;
            btnCatchUp.UseVisualStyleBackColor = true;
            btnCatchUp.Click += BtnCatchUp_Click;
            // 
            // btnBall
            // 
            btnBall.BackgroundImage = Properties.Resources.ball;
            btnBall.BackgroundImageLayout = ImageLayout.Stretch;
            btnBall.Location = new Point(296, 31);
            btnBall.Name = "btnBall";
            btnBall.Size = new Size(200, 200);
            btnBall.TabIndex = 0;
            btnBall.UseVisualStyleBackColor = true;
            btnBall.Click += BtnBall_Click;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 261);
            Controls.Add(btnBall);
            Controls.Add(btnCatchUp);
            Controls.Add(btnWand);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите игру:";
            ResumeLayout(false);
        }

        #endregion

        private Button btnWand;
        private Button btnCatchUp;
        private Button btnBall;
    }
}