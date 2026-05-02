namespace TamagotchiApp
{
    partial class SettingsForm
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            cbTypes = new ComboBox();
            btnStart = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 0;
            label1.Text = "Имя питомца:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 1;
            label2.Text = "Вид питомца:";
            // 
            // txtName
            // 
            txtName.Location = new Point(195, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(572, 39);
            txtName.TabIndex = 2;
            // 
            // cbTypes
            // 
            cbTypes.FormattingEnabled = true;
            cbTypes.Items.AddRange(new object[] { "Собака", "Кошка", "Хомяк", "Попугай " });
            cbTypes.Location = new Point(195, 109);
            cbTypes.Name = "cbTypes";
            cbTypes.Size = new Size(572, 40);
            cbTypes.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = Properties.Resources.играть;
            btnStart.BackgroundImageLayout = ImageLayout.Center;
            btnStart.Location = new Point(425, 196);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(227, 136);
            btnStart.TabIndex = 4;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.назаддд;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.Location = new Point(132, 196);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(227, 136);
            btnBack.TabIndex = 5;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += BtnBack_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 365);
            Controls.Add(btnBack);
            Controls.Add(btnStart);
            Controls.Add(cbTypes);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройка игры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private ComboBox cbTypes;
        private Button btnStart;
        private Button btnBack;
    }
}