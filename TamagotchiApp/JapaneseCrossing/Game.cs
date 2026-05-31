using TamagotchiApp.JapaneseCrossing.Persons;

namespace TamagotchiApp.JapaneseCrossing
{
    public class Game
    {
        private SideKind? _targetSide;    //сторона куда переправляемся

        public Game()
        {
            Passengers = CreatePassengers();   //задаем персонажей

            LeftSide = new RiverSide(SideKind.Left);   //левый берег
            RightSide = new RiverSide(SideKind.Right); //правый берег

            LeftSide.AddRange(Passengers);  //старт на левом берегу

            Boat = new Boat(   //создаем лодку
                GameConstants.BoatLeftX,  //коорд х и у
                GameConstants.BoatY);
        }

        public RiverSide LeftSide { get; }

        public RiverSide RightSide { get; }

        public Boat Boat { get; }

        public List<Person> Passengers { get; }  //свойство персонажей, список

        public int MoveCount { get; private set; }  //кол-во ходов

        public SideKind ActiveSide =>  //сейчас находимся
            Boat.IsOnLeftSide
                ? SideKind.Left
                : SideKind.Right;

        public bool IsAnimationRunning { get; private set; }  //включена анимация

        public bool IsSuccess =>    //если нет пассажиров на лев берегу и в лодке-игра закончена
            LeftSide.Passengers.Count == 0 &&
            Boat.Passengers.Count == 0;

        public void Embark(Person person)   //посадить в лодку
        {
            if (IsAnimationRunning)
                return;

            if (person.InBoat)
                return;

            var personSide = GetSideByPerson(person); //проверка персонажа, на какой сторне реки

            if (personSide != ActiveSide)
            {
                throw new InvalidOperationException(
                    "Персонаж находится на другом берегу");
            }

            if (!Boat.TryEmbark(    //посадка в лодку
                    person,
                    out var seatPosition,
                    out var seat))
            {
                throw new InvalidOperationException(
                    "В лодке нет больше места");
            }

            var targetSide = ActiveSide == SideKind.Left   //берег
                ? SideKind.Right
                : SideKind.Left;

            person.MoveToBoatSeat(seatPosition, seat, targetSide);  //направление куда едем

            GetRiverSide(ActiveSide).Remove(person);  //удаляем с берега
        }

        public void Disembark(Person person)   //высаживаем
        {
            if (IsAnimationRunning)
                return;

            if (!person.InBoat)
                return;

            Boat.Disembark(person);

            if (ActiveSide == SideKind.Left)
            {
                person.MoveToLeftSide();  //устанавливаем координаты на лев берегу
                LeftSide.Add(person);  //добавляем 
            }
            else
            {
                person.MoveToRightSide();  //устанавливаем координаты на прав берегу
                RightSide.Add(person);  //добавляем 
            }
        }

        public void StartMove(SideKind targetSide)  //начало движения
        {
            if (IsAnimationRunning)
                return;

            if (targetSide == ActiveSide)
            {
                throw new InvalidOperationException(
                    "Лодка уже находится на выбранном берегу");
            }

            GameRules.ValidateBoatCanMove(Boat.Passengers);  //проверка что в лодке находится хотя бы один, кто будет управлять

            GameRules.ValidateRiverSide(GetRiverSide(ActiveSide).Passengers);  //правила нахождения

            _targetSide = targetSide;

            Boat.StartMove(targetSide);

            IsAnimationRunning = true;

            MoveCount++;
        }

        public void AnimationStep()  //анимация по шагам
        {
            if (!IsAnimationRunning || _targetSide is null)
                return;

            var delta = _targetSide == SideKind.Right  //дельта - передвижение по пикселям
                ? GameConstants.BoatMoveStep
                : -GameConstants.BoatMoveStep;

            Boat.Move(delta);  //лодка едет, смещается на дельту

            if (_targetSide == SideKind.Right &&   //проверка что лодка доехала и устанавл позицию
                Boat.Right >= GameConstants.BoatRightX)
            {
                Boat.SetPosition(GameConstants.BoatRightX - Boat.Width);

                IsAnimationRunning = false;

                _targetSide = null;

                GameRules.ValidateRiverSide(LeftSide.Passengers);  //проверка на правила игры
            }
            else if (_targetSide == SideKind.Left &&    //проверка что лодка доехала и устанавл позицию
                     Boat.X <= GameConstants.BoatLeftX)
            {
                Boat.SetPosition(GameConstants.BoatLeftX);

                IsAnimationRunning = false;

                _targetSide = null;

                GameRules.ValidateRiverSide(RightSide.Passengers);  //проверка на правила игры
            }
        }

        public Person? FindPersonAt(int x, int y)   //ищем персонажа по координатам 
        {
            return Passengers.LastOrDefault(person => person.IsActive(x, y));   //при наложении, клик будет на вехненго персонажа
        }

        public void Draw(Graphics graphics)  //отрисовка
        {
            Boat.Draw(graphics);

            foreach (var passenger in Passengers)
            {
                passenger.Draw(graphics);
            }
        }

        private RiverSide GetRiverSide(SideKind side)  //сторона реки где находимся
        {
            return side == SideKind.Left
                ? LeftSide
                : RightSide;
        }

        private SideKind GetSideByPerson(Person person)
        {
            if (LeftSide.Passengers.Contains(person))
                return SideKind.Left;

            if (RightSide.Passengers.Contains(person))
                return SideKind.Right;

            return ActiveSide;
        }

        private static List<Person> CreatePassengers()   //создаем координаты пассажира, где он находится
        {
            return new List<Person>
            {
                new Police(100, 300, 1350, 350),

                new Criminal(160, 300, 1450 , 380),

                new Mother(50, 420, 1130, 540),

                new Son(40, 500, 1330, 540),
                new Son(0, 530, 1310, 580),

                new Daughter(40, 570, 1260, 500),
                new Daughter(5, 600, 1300, 500),

                new Father(120, 420, 1250, 560),
            };
        }

        public string GetCurrentMoveDescription(SideKind targetSide)   //описание движения лодки (история движения в верхнем окне)
        {
            var passengers = Boat.Passengers
                .Select(person => person.Name)
                .ToList();

            var direction = targetSide == SideKind.Right
                ? "→"
                : "←";

            return $"{MoveCount + 1}. {string.Join(" + ", passengers)} {direction}";
        }
    }
}
