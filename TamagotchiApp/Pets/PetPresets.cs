using System;
using System.Collections.Generic;
using System.Text;

namespace TamagotchiApp.Pets
{
    public static class PetConfigPresets
    {
        public static PetConfig Dog => new()
        {
            Discipline = new Stat(0, 100, 100, 1),
            Energy = new Stat(0, 500, 500, 1),
            Health = new Stat(0, 5000, 5000, 1),
            Satiety = new Stat(0, 500, 500, 1),
            Mood = new Stat(0, 500, 500, 1),
            Hygiene = new Stat(0, 500, 500, 1)
        };

        public static PetConfig Cat => new()
        {
            Discipline = new Stat(0, 100, 100, 1),
            Energy = new Stat(0, 300, 300, 1),
            Health = new Stat(0, 5000, 5000, 1),
            Satiety = new Stat(0, 100, 100, 1),
            Mood = new Stat(0, 200, 200, 1),
            Hygiene = new Stat(0, 500, 500, 1)
        };

        public static PetConfig Humster => new()
        {
            Discipline = new Stat(0, 100, 100, 1),
            Energy = new Stat(0, 500, 500, 1),
            Health = new Stat(0, 5000, 5000, 1),
            Satiety = new Stat(0, 500, 500, 1),
            Mood = new Stat(0, 500, 500, 1),
            Hygiene = new Stat(0, 500, 500, 1)
        };

        public static PetConfig Parrot => new()
        {
            Discipline = new Stat(0, 100, 100, 1),
            Energy = new Stat(0, 300, 300, 1),
            Health = new Stat(0, 5000, 5000, 1),
            Satiety = new Stat(0, 100, 100, 1),
            Mood = new Stat(0, 200, 200, 1),
            Hygiene = new Stat(0, 500, 500, 1)
        };
    }

}
