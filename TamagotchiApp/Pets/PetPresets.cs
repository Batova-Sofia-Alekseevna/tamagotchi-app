using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
    public static class PetConfigPresets
    {
        public static PetConfig Dog => new()
        {
            Discipline = new Stat(0, 5000, 5000, 1),
            Energy = new Stat(0, 6000, 6000, 1),
            Health = new Stat(0, 10000, 10000, 1),
            Satiety = new Stat(0, 7000, 7000, 1),
            Mood = new Stat(0, 8000, 8000, 1),
            Hygiene = new Stat(0, 9000, 9000, 1)
        };

        public static PetConfig Cat => new()
        {
            Discipline = new Stat(0, 5000, 5000, 1),
            Energy = new Stat(0, 6000, 6000, 1),
            Health = new Stat(0, 10000, 10000, 1),
            Satiety = new Stat(0, 7000, 7000, 1),
            Mood = new Stat(0, 8000, 8000, 1),
            Hygiene = new Stat(0, 9000, 9000, 1)
        };

        public static PetConfig Humster => new()
        {
            Discipline = new Stat(0, 5000, 5000, 1),
            Energy = new Stat(0, 6000, 6000, 1),
            Health = new Stat(0, 10000, 10000, 1),
            Satiety = new Stat(0, 7000, 7000, 1),
            Mood = new Stat(0, 8000, 8000, 1),
            Hygiene = new Stat(0, 9000, 9000, 1)
        };

        public static PetConfig Parrot => new()
        {
            Discipline = new Stat(0, 5000, 5000, 1),
            Energy = new Stat(0, 6000, 6000, 1),
            Health = new Stat(0, 10000, 10000, 1),
            Satiety = new Stat(0, 7000, 7000, 1),
            Mood = new Stat(0, 8000, 8000, 1),
            Hygiene = new Stat(0, 9000, 9000, 1)
        };
    }

}
