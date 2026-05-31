namespace TamagotchiApp.Pets
{
    public static class PetConfigPresets   //задание настроик питомца
    {
        public static PetConfig Dog => new()
        {
            Discipline = new Stat(0, 5000, 5000, 10),
            Energy = new Stat(0, 6000, 6000, 10),
            Health = new Stat(0, 10000, 10000, 10),
            Satiety = new Stat(0, 7000, 7000, 10),
            Mood = new Stat(0, 8000, 8000, 10),
            Hygiene = new Stat(0, 9000, 9000, 10)
        };

        public static PetConfig Cat => new()
        {
            Discipline = new Stat(0, 5000, 5000, 20),
            Energy = new Stat(0, 6000, 6000, 20),
            Health = new Stat(0, 10000, 10000, 20),
            Satiety = new Stat(0, 7000, 7000, 20),
            Mood = new Stat(0, 8000, 8000, 20),
            Hygiene = new Stat(0, 9000, 9000, 20)
        };

        public static PetConfig Humster => new()
        {
            Discipline = new Stat(0, 5000, 5000, 20),
            Energy = new Stat(0, 6000, 6000, 20),
            Health = new Stat(0, 10000, 10000, 20),
            Satiety = new Stat(0, 7000, 7000, 20),
            Mood = new Stat(0, 8000, 8000, 20),
            Hygiene = new Stat(0, 9000, 9000, 20)
        };

        public static PetConfig Parrot => new()
        {
            Discipline = new Stat(0, 5000, 5000, 20),
            Energy = new Stat(0, 6000, 6000, 20),
            Health = new Stat(0, 10000, 10000, 20),
            Satiety = new Stat(0, 7000, 7000, 20),
            Mood = new Stat(0, 8000, 8000, 20),
            Hygiene = new Stat(0, 9000, 9000, 20)
        };
    }

}
