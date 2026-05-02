using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
    public abstract class Pet(string name, double age)
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
    }
}