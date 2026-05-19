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

            _pet.Discipline.Reduce();
            _pet.Satiety.Reduce();
            _pet.Mood.Reduce();
            _pet.Hygiene.Reduce();
            _pet.Sleep();
            _pet.StayAwake();

            pbDiscipline.Value = _pet.Discipline.Value;
            pbSatiety.Value = _pet.Satiety.Value;
            pbMood.Value = _pet.Mood.Value;
            pbEnergy.Value = _pet.Energy.Value;
            pbHygiene.Value = _pet.Hygiene.Value;

            // Каждые 1000 тиков возраст увеличиваем на 0,2
            if (_tickCount % 1000 == 0)
            {
                _pet.IncreaseAge();
                lblNameAndAge.Text = _pet.ToString();
            }

            // Каждые 2000 тиков питомец может заболеть
            if (_tickCount % 2000 == 0)
            {
                _pet.UpdateHealth();
                pbHealth.Value = _pet.Health.Value;
            }

            _pet.UpdateState();
            pbImage.BackgroundImage = _pet.Images[_pet.State];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblNameAndAge.Text = _pet.ToString();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startupForm.Close();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            _pet.Hygiene.SetMax();
            pbHygiene.Value = _pet.Hygiene.Value;
        }

        private void BtnHeal_Click(object sender, EventArgs e)
        {
            _pet.Health.SetMax();
            pbHealth.Value = _pet.Health.Value;
        }

        private void BtnStroke_Click(object sender, EventArgs e)
        {
            _pet.Mood.SetMax();
            pbMood.Value = _pet.Mood.Value;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            var form = new PlayForm();
            form.ShowDialog();
        }
    }
}
