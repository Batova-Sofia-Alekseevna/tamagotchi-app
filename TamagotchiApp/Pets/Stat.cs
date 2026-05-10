using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
    public sealed class Stat
    {
        private int _value;
        private int _delta;

        /// <summary>
        /// Минимальное значение
        /// </summary>
        public int Min { get; }

        /// <summary>
        /// Минимальное значение
        /// </summary>
        public int Max { get; }

        /// <summary>
        /// Текущее значение
        /// </summary>
        public int Value
        {
            get => _value;
            set => _value = Math.Clamp(value, Min, Max);
        }

        /// <summary>
        /// Величина изменения параметра
        /// </summary>
        public int Delta
        {
            get => _delta;
            set => _delta = Math.Clamp(value, Min, Max);
        }

        public Stat(int min, int max, int value, int delta)
        {
            if (min >= max)
            {
                throw new ArgumentException("Минимум не может быть больше или равен максимуму");
            }

            if (max % delta != 0)
            {
                throw new ArgumentException("Изменение значения должно быть кратно максимальному значению");
            }

            Min = min;
            Max = max;
            Value = value;
            Delta = delta;
        }

        public void Increase()
        {
            Value += Delta;
        }

        public void Reduce()
        {
            Value -= Delta;
        }

        public void Update(int value)
        {
            Value += value;
        }
    }
}
