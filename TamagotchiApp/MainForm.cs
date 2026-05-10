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
        private int _tickCount = 0;

        public MainForm(Pet pet, StartupForm startupForm)
        {
            _startupForm = startupForm;
            _pet = pet;

            InitializeComponent();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            _tickCount++;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ConfigureProgress();
        }

        private void ConfigureProgress()
        {
            pbHealth.Minimum = _pet.Health.Min;
            pbHealth.Maximum = _pet.Health.Max;
            pbHealth.Value = _pet.Health.Value;

            pbSatiety.Minimum = _pet.Satiety.Min;
            pbSatiety.Maximum = _pet.Satiety.Max;
            pbSatiety.Value = _pet.Satiety.Value;

            pbEnergy.Minimum = _pet.Energy.Min;
            pbEnergy.Maximum = _pet.Energy.Max;
            pbEnergy.Value = _pet.Energy.Value;

            pbMood.Minimum = _pet.Mood.Min;
            pbMood.Maximum = _pet.Mood.Max;
            pbMood.Value = _pet.Mood.Value;

            pbDiscipline.Minimum = _pet.Discipline.Min;
            pbDiscipline.Maximum = _pet.Discipline.Max;
            pbDiscipline.Value = _pet.Discipline.Value;

            pbHygiene.Minimum = _pet.Hygiene.Min;
            pbHygiene.Maximum = _pet.Hygiene.Max;
            pbHygiene.Value = _pet.Hygiene.Value;
        }

    }
}
