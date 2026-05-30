namespace TamagotchiApp
{
    partial class MiniGameForm
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            textBoxProcess = new TextBox();
            toolTip1 = new ToolTip(components);
            buttonToRight = new Button();
            buttonToLeft = new Button();
            btnRules = new Button();
            btnHint = new Button();
            btnRestart = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // textBoxProcess
            // 
            textBoxProcess.Location = new Point(617, 1);
            textBoxProcess.Multiline = true;
            textBoxProcess.Name = "textBoxProcess";
            textBoxProcess.Size = new Size(442, 87);
            textBoxProcess.TabIndex = 0;
            // 
            // buttonToRight
            // 
            buttonToRight.Location = new Point(36, 917);
            buttonToRight.Name = "buttonToRight";
            buttonToRight.Size = new Size(150, 46);
            buttonToRight.TabIndex = 1;
            buttonToRight.Text = "Туда";
            buttonToRight.UseVisualStyleBackColor = true;
            buttonToRight.Click += ButtonToRight_Click;
            // 
            // buttonToLeft
            // 
            buttonToLeft.Location = new Point(1482, 917);
            buttonToLeft.Name = "buttonToLeft";
            buttonToLeft.Size = new Size(150, 46);
            buttonToLeft.TabIndex = 2;
            buttonToLeft.Text = "Обратно";
            buttonToLeft.UseVisualStyleBackColor = true;
            buttonToLeft.Click += ButtonToLeft_Click;
            // 
            // btnRules
            // 
            btnRules.Location = new Point(1482, 12);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(150, 46);
            btnRules.TabIndex = 3;
            btnRules.Text = "Правила";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += ButtonRules_Click;
            // 
            // btnHint
            // 
            btnHint.Location = new Point(1482, 64);
            btnHint.Name = "btnHint";
            btnHint.Size = new Size(150, 46);
            btnHint.TabIndex = 4;
            btnHint.Text = "Подсказка";
            btnHint.UseVisualStyleBackColor = true;
            btnHint.Click += ButtonHint_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(1482, 116);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(150, 46);
            btnRestart.TabIndex = 5;
            btnRestart.Text = "Заново";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += ButtonRestart_Click;
            // 
            // MiniGameForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1662, 983);
            Controls.Add(btnRestart);
            Controls.Add(btnHint);
            Controls.Add(btnRules);
            Controls.Add(buttonToLeft);
            Controls.Add(buttonToRight);
            Controls.Add(textBoxProcess);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MiniGameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Мини-игра: Японская переправа";
            Paint += MiniGameForm_Paint;
            MouseDown += MiniGameForm_MouseDown;
            MouseMove += MiniGameForm_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TextBox textBoxProcess;
        private ToolTip toolTip1;
        private Button buttonToRight;
        private Button buttonToLeft;
        private Button btnRules;
        private Button btnHint;
        private Button btnRestart;
    }
}