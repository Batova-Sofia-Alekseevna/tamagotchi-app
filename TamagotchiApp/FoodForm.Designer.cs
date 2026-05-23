namespace TamagotchiApp
{
    partial class FoodForm
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
            btnFood1 = new Button();
            btnFood2 = new Button();
            btnFood3 = new Button();
            SuspendLayout();
            // 
            // btnFood1
            // 
            btnFood1.BackgroundImageLayout = ImageLayout.Stretch;
            btnFood1.Location = new Point(33, 34);
            btnFood1.Name = "btnFood1";
            btnFood1.Size = new Size(200, 200);
            btnFood1.TabIndex = 0;
            btnFood1.UseVisualStyleBackColor = true;
            btnFood1.Click += BtnFood1_Click;
            // 
            // btnFood2
            // 
            btnFood2.BackgroundImageLayout = ImageLayout.Stretch;
            btnFood2.Location = new Point(286, 34);
            btnFood2.Name = "btnFood2";
            btnFood2.Size = new Size(200, 200);
            btnFood2.TabIndex = 1;
            btnFood2.UseVisualStyleBackColor = true;
            btnFood2.Click += BtnFood2_Click;
            // 
            // btnFood3
            // 
            btnFood3.BackgroundImageLayout = ImageLayout.Stretch;
            btnFood3.Location = new Point(543, 34);
            btnFood3.Name = "btnFood3";
            btnFood3.Size = new Size(200, 200);
            btnFood3.TabIndex = 2;
            btnFood3.UseVisualStyleBackColor = true;
            btnFood3.Click += BtnFood3_Click;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 275);
            Controls.Add(btnFood3);
            Controls.Add(btnFood2);
            Controls.Add(btnFood1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите еду:";
            Load += FoodForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnFood1;
        private Button btnFood2;
        private Button btnFood3;
    }
}