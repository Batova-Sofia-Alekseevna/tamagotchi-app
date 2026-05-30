using TamagotchiApp.JapaneseCrossing.Persons;

namespace TamagotchiApp.JapaneseCrossing
{
    public class Boat
    {
        private readonly Dictionary<Person, BoatSeat> _seats = new(); //места

        private readonly Bitmap _image = Properties.Resources.boat; //изображение

        public Boat(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }

        public int Y { get; }

        public int Width { get; } = 390;  //ширина лодки

        public int Height { get; } = 210;  //высота 

        public int Right => X + Width; //право 

        public int Capacity { get; } = 2;   //вместимость только 2

        public bool IsOnLeftSide => X <= GameConstants.BoatLeftX;

        public IReadOnlyCollection<Person> Passengers => _seats.Keys;  //список пассажиров

        public SideKind MovingToSide { get; private set; } = SideKind.Right; //куда едем

        public void Draw(Graphics graphics)  //отрисовка
        {
            if (MovingToSide == SideKind.Left)
            {
                graphics.TranslateTransform(X + Width, Y);  //развораичваем
                graphics.ScaleTransform(-1, 1);

                graphics.DrawImage(
                  _image,
                  0,
                  0,
                  Width,
                  Height);

                graphics.ResetTransform();

                return;
            }

            graphics.DrawImage(
              _image,
              X,
              Y,
              Width,
              Height);
        }

        public bool TryEmbark(   //посадить в лодку
          Person person,
          out Point seatPosition,
          out BoatSeat seat)
        {
            seatPosition = Point.Empty;  //пока пусто
            seat = BoatSeat.None;

            if (_seats.Count >= Capacity)  //не удалось посадить, места нет
                return false;

            seat = GetFreeSeat();  //получить место

            _seats.Add(person, seat);

            seatPosition = GetSeatPosition(seat);

            return true;
        }

        public void Disembark(Person person)
        {
            _seats.Remove(person);
        }

        public void Move(int delta)   //движение лодки
        {
            ValidateMove();  

            X += delta;

            UpdatePassengersPositions();
        }

        public void SetPosition(int x)
        {
            X = x;

            UpdatePassengersPositions();
        }

        private void ValidateMove()
        {
            if (_seats.Count == 0)
            {
                throw new InvalidOperationException(
                  "Лодка не может двигаться без пассажиров");
            }

            if (_seats.Keys.All(person => !person.CanOperateBoat))
            {
                throw new InvalidOperationException(
                  "Никто не может управлять лодкой");
            }
        }

        private void UpdatePassengersPositions()   //обновление позииций пассажира
        {
            foreach (var pair in _seats)
            {
                var person = pair.Key;
                var seat = pair.Value;

                var position = GetSeatPosition(seat);

                person.MoveToBoatSeat(
                  position,
                  seat,
                  MovingToSide);
            }
        }

        private BoatSeat GetFreeSeat()   //получение свободного места в лодке
        {
            if (!_seats.Values.Contains(BoatSeat.Left))
                return BoatSeat.Left;

            return BoatSeat.Right;
        }

        private Point GetSeatPosition(BoatSeat seat)
        {
            return seat switch
            {
                BoatSeat.Left => new Point(X + 35, Y - 60),
                BoatSeat.Right => new Point(X + 180, Y - 60),

                _ => throw new ArgumentOutOfRangeException(nameof(seat))
            };
        }

        public void StartMove(SideKind targetSide)  //начинаем движение
        {
            MovingToSide = targetSide;
        }
    }

}
