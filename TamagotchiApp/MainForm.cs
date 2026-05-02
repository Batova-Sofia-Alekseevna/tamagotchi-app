using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TamagotchiApp.Pets;

namespace TamagotchiApp
{
    public partial class MainForm : Form
    {
        private readonly StartupForm _startupForm;
        private readonly Pet _pet;
        private int _count = 0;

        public MainForm(Pet pet, StartupForm startupForm)
        {
            _startupForm = startupForm;
            _pet = pet;

            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
