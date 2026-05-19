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
            btnDryFood = new Button();
            btnTreat = new Button();
            btnMeat = new Button();
            SuspendLayout();
            // 
            // btnDryFood
            // 
            btnDryFood.BackgroundImage = Properties.Resources.корм;
            btnDryFood.BackgroundImageLayout = ImageLayout.Stretch;
            btnDryFood.Location = new Point(33, 34);
            btnDryFood.Name = "btnDryFood";
            btnDryFood.Size = new Size(200, 200);
            btnDryFood.TabIndex = 0;
            btnDryFood.UseVisualStyleBackColor = true;
            // 
            // btnTreat
            // 
            btnTreat.BackgroundImage = Properties.Resources.лакомство;
            btnTreat.BackgroundImageLayout = ImageLayout.Stretch;
            btnTreat.Location = new Point(286, 34);
            btnTreat.Name = "btnTreat";
            btnTreat.Size = new Size(200, 200);
            btnTreat.TabIndex = 1;
            btnTreat.UseVisualStyleBackColor = true;
            // 
            // btnMeat
            // 
            btnMeat.BackgroundImage = Properties.Resources.мясо;
            btnMeat.BackgroundImageLayout = ImageLayout.Stretch;
            btnMeat.Location = new Point(543, 34);
            btnMeat.Name = "btnMeat";
            btnMeat.Size = new Size(200, 200);
            btnMeat.TabIndex = 2;
            btnMeat.UseVisualStyleBackColor = true;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 275);
            Controls.Add(btnMeat);
            Controls.Add(btnTreat);
            Controls.Add(btnDryFood);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите еду:";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDryFood;
        private Button btnTreat;
        private Button btnMeat;
    }
}