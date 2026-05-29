namespace TamagotchiApp.JapaneseCrossing
{
    public class RiverSide
    {
        private readonly List<Person> _passengers = new();  //список пассажиров

        public RiverSide(SideKind side)  //сторона реки
        {
            Side = side;
        }

        public SideKind Side { get; }
        public IReadOnlyList<Person> Passengers => _passengers;

        public void Add(Person person) //добавить одного поссажира
        {
            if (!_passengers.Contains(person))
            {
                _passengers.Add(person);
            }
        }

        public void AddRange(IEnumerable<Person> passengers)  //добаввить несколько пассажиров
        {
            foreach (var passenger in passengers)
            {
                Add(passenger);
            }
        }

        public void Remove(Person person) //удаление пассажиров
        {
            _passengers.Remove(person);
        }
    }

}
