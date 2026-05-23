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
            btnPlay1 = new Button();
            btnPlay3 = new Button();
            btnPlay2 = new Button();
            SuspendLayout();
            // 
            // btnPlay1
            // 
            btnPlay1.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay1.Location = new Point(44, 31);
            btnPlay1.Name = "btnPlay1";
            btnPlay1.Size = new Size(200, 200);
            btnPlay1.TabIndex = 0;
            btnPlay1.UseVisualStyleBackColor = true;
            btnPlay1.Click += BtnPlay1_Click;
            // 
            // btnPlay3
            // 
            btnPlay3.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay3.Location = new Point(546, 31);
            btnPlay3.Name = "btnPlay3";
            btnPlay3.Size = new Size(200, 200);
            btnPlay3.TabIndex = 0;
            btnPlay3.UseVisualStyleBackColor = true;
            btnPlay3.Click += BtnPlay3_Click;
            // 
            // btnPlay2
            // 
            btnPlay2.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay2.Location = new Point(296, 31);
            btnPlay2.Name = "btnPlay2";
            btnPlay2.Size = new Size(200, 200);
            btnPlay2.TabIndex = 0;
            btnPlay2.UseVisualStyleBackColor = true;
            btnPlay2.Click += BtnPlay2_Click;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 261);
            Controls.Add(btnPlay2);
            Controls.Add(btnPlay3);
            Controls.Add(btnPlay1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите игру:";
            Load += PlayForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay1;
        private Button btnPlay3;
        private Button btnPlay2;
    }
}