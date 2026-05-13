using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.AxHost;

namespace TamagotchiApp.Pets
{
    public abstract class Pet(string name, double age, PetConfig config)
    {
        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name { get; } = name;

        /// <summary>
        /// Возраст персонажа
        /// </summary>
        public double Age { get; private set; } = age;

        /// <summary>
        /// Состояние питомца
        /// </summary>
        public PetState State { get; private set; } = PetState.Base;
        
        /// <summary>
        /// Изображение питомца
        /// </summary>
        public abstract Dictionary<PetState, Image> Images { get; }

        /// <summary>
        /// Здоровье
        /// </summary>
        public Stat Health { get; } = new Stat(
            config.Health.Min,
            config.Health.Max,
            config.Health.Value,
            config.Health.Delta);

        /// <summary>
        /// Сытость
        /// </summary>
        public Stat Satiety { get; } = new Stat(
            config.Satiety.Min,
            config.Satiety.Max,
            config.Satiety.Value,
            config.Satiety.Delta);

        /// <summary>
        /// Настроение
        /// </summary>
        public Stat Mood { get; } = new Stat(
            config.Mood.Min,
            config.Mood.Max,
            config.Mood.Value,
            config.Mood.Delta);

        /// <summary>
        /// Энергия
        /// </summary>
        public Stat Energy { get; } = new Stat(
            config.Energy.Min,
            config.Energy.Max,
            config.Energy.Value,
            config.Energy.Delta);

        /// <summary>
        /// Дисциплина
        /// </summary>
        public Stat Discipline { get; } = new Stat(
            config.Discipline.Min,
            config.Discipline.Max,
            config.Discipline.Value,
            config.Discipline.Delta);

        /// <summary>
        /// Гигиена
        /// </summary>
        public Stat Hygiene { get; } = new Stat(
            config.Hygiene.Min,
            config.Hygiene.Max,
            config.Hygiene.Value,
            config.Hygiene.Delta);

        /// <summary>
        /// Увеличить возраст
        /// </summary>
        public void IncreaseAge()
        {
            Age += 0.2;
        }

        public override string ToString()
        {
            return $"{Name}, {Age} лет";
        }

        /// <summary>
        /// Изменить здоровье, питомец может заболеть
        /// </summary>
        public virtual void UpdateHealth()
        {
            var random = new Random();
            var maySick = random.NextDouble();

            // Заболел
            if (maySick > 0.6)
            {
                var health = random.Next(0, (Health.Max - Health.Min) / 4);
                Health.Update(-health);
            }
        }

        public virtual void UpdateState()
        {
            if (Health.Value != Health.Max)
            {
                State = PetState.Sick;
                return;
            }
        }
    }
}