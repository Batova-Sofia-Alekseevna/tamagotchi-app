using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TamagotchiApp
{
    public partial class SettingsForm : Form
    {
        private readonly StartupForm _startupForm;

        public SettingsForm(StartupForm startupForm)
        {
            InitializeComponent();
            
            _startupForm = startupForm;
            cbTypes.SelectedIndex = 0;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
            _startupForm.Show();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
