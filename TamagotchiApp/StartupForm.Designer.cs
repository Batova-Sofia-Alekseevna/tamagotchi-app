namespace TamagotchiApp
{
    partial class StartupForm
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
            btnNewGame = new Button();
            btnLoad = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(25, 27);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(677, 68);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "Новая игра";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += BtnNewGame_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(26, 113);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(677, 68);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Загрузить из файла";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(24, 202);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(677, 68);
            btnExit.TabIndex = 0;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 301);
            Controls.Add(btnLoad);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Начать игру";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewGame;
        private Button btnLoad;
        private Button btnExit;
    }
}
