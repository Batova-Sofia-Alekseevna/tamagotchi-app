namespace TamagotchiApp
{
    partial class MainForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            lblNameAndAge = new Label();
            pbImage = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pbHealth = new ProgressBar();
            pbSatiety = new ProgressBar();
            pbMood = new ProgressBar();
            pbEnergy = new ProgressBar();
            pbDiscipline = new ProgressBar();
            pbHygiene = new ProgressBar();
            panel2 = new Panel();
            btnFeed = new Button();
            btnPlay = new Button();
            btnStroke = new Button();
            btnHeal = new Button();
            btnClean = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1211, 763);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(pbImage, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 186F));
            tableLayoutPanel2.Size = new Size(599, 757);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNameAndAge);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 54);
            panel1.TabIndex = 0;
            // 
            // lblNameAndAge
            // 
            lblNameAndAge.AutoSize = true;
            lblNameAndAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNameAndAge.Location = new Point(9, 5);
            lblNameAndAge.Name = "lblNameAndAge";
            lblNameAndAge.Size = new Size(110, 45);
            lblNameAndAge.TabIndex = 0;
            lblNameAndAge.Text = "label1";
            // 
            // pbImage
            // 
            pbImage.BackgroundImageLayout = ImageLayout.Stretch;
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(3, 63);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(593, 505);
            pbImage.TabIndex = 1;
            pbImage.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 2);
            tableLayoutPanel3.Controls.Add(label5, 0, 3);
            tableLayoutPanel3.Controls.Add(label6, 0, 4);
            tableLayoutPanel3.Controls.Add(label7, 0, 5);
            tableLayoutPanel3.Controls.Add(pbHealth, 1, 0);
            tableLayoutPanel3.Controls.Add(pbSatiety, 1, 1);
            tableLayoutPanel3.Controls.Add(pbMood, 1, 2);
            tableLayoutPanel3.Controls.Add(pbEnergy, 1, 3);
            tableLayoutPanel3.Controls.Add(pbDiscipline, 1, 4);
            tableLayoutPanel3.Controls.Add(pbHygiene, 1, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 574);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(593, 180);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 0;
            label2.Text = "Здоровье";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(161, 30);
            label3.TabIndex = 1;
            label3.Text = "Сытость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(161, 30);
            label4.TabIndex = 2;
            label4.Text = "Настроение";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 90);
            label5.Name = "label5";
            label5.Size = new Size(161, 30);
            label5.TabIndex = 3;
            label5.Text = "Энергия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 120);
            label6.Name = "label6";
            label6.Size = new Size(161, 30);
            label6.TabIndex = 4;
            label6.Text = "Дисциплина";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 150);
            label7.Name = "label7";
            label7.Size = new Size(161, 30);
            label7.TabIndex = 5;
            label7.Text = "Гигиена";
            // 
            // pbHealth
            // 
            pbHealth.Dock = DockStyle.Fill;
            pbHealth.Location = new Point(170, 3);
            pbHealth.Name = "pbHealth";
            pbHealth.Size = new Size(420, 24);
            pbHealth.TabIndex = 6;
            // 
            // pbSatiety
            // 
            pbSatiety.Dock = DockStyle.Fill;
            pbSatiety.Location = new Point(170, 33);
            pbSatiety.Name = "pbSatiety";
            pbSatiety.Size = new Size(420, 24);
            pbSatiety.TabIndex = 7;
            // 
            // pbMood
            // 
            pbMood.Dock = DockStyle.Fill;
            pbMood.Location = new Point(170, 63);
            pbMood.Name = "pbMood";
            pbMood.Size = new Size(420, 24);
            pbMood.TabIndex = 8;
            // 
            // pbEnergy
            // 
            pbEnergy.Dock = DockStyle.Fill;
            pbEnergy.Location = new Point(170, 93);
            pbEnergy.Name = "pbEnergy";
            pbEnergy.Size = new Size(420, 24);
            pbEnergy.TabIndex = 9;
            // 
            // pbDiscipline
            // 
            pbDiscipline.Dock = DockStyle.Fill;
            pbDiscipline.Location = new Point(170, 123);
            pbDiscipline.Name = "pbDiscipline";
            pbDiscipline.Size = new Size(420, 24);
            pbDiscipline.TabIndex = 10;
            // 
            // pbHygiene
            // 
            pbHygiene.Dock = DockStyle.Fill;
            pbHygiene.Location = new Point(170, 153);
            pbHygiene.Name = "pbHygiene";
            pbHygiene.Size = new Size(420, 24);
            pbHygiene.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnFeed);
            panel2.Controls.Add(btnPlay);
            panel2.Controls.Add(btnStroke);
            panel2.Controls.Add(btnHeal);
            panel2.Controls.Add(btnClean);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(608, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 757);
            panel2.TabIndex = 1;
            // 
            // btnFeed
            // 
            btnFeed.Location = new Point(24, 384);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(554, 58);
            btnFeed.TabIndex = 4;
            btnFeed.Text = "Кормить";
            btnFeed.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(24, 291);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(554, 58);
            btnPlay.TabIndex = 3;
            btnPlay.Text = "Играть";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay_Click;
            // 
            // btnStroke
            // 
            btnStroke.Location = new Point(24, 198);
            btnStroke.Name = "btnStroke";
            btnStroke.Size = new Size(554, 58);
            btnStroke.TabIndex = 2;
            btnStroke.Text = "Погладить";
            btnStroke.UseVisualStyleBackColor = true;
            btnStroke.Click += BtnStroke_Click;
            // 
            // btnHeal
            // 
            btnHeal.Location = new Point(24, 105);
            btnHeal.Name = "btnHeal";
            btnHeal.Size = new Size(554, 58);
            btnHeal.TabIndex = 1;
            btnHeal.Text = "Лечить";
            btnHeal.UseVisualStyleBackColor = true;
            btnHeal.Click += BtnHeal_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(24, 12);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(554, 58);
            btnClean.TabIndex = 0;
            btnClean.Text = "Навести порядок";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += BtnClean_Click;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1211, 763);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тамагочи";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label lblNameAndAge;
        private PictureBox pbImage;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ProgressBar pbHealth;
        private ProgressBar pbSatiety;
        private ProgressBar pbMood;
        private ProgressBar pbEnergy;
        private ProgressBar pbDiscipline;
        private ProgressBar pbHygiene;
        private Panel panel2;
        private Button btnFeed;
        private Button btnPlay;
        private Button btnStroke;
        private Button btnHeal;
        private Button btnClean;
        private System.Windows.Forms.Timer timer1;
    }
}