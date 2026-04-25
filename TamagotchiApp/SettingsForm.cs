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
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

        }
    }
}
