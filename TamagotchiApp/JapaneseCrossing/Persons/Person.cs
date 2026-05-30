namespace TamagotchiApp.JapaneseCrossing.Persons
{
    public abstract class Person
    {
        protected Person(  //задаем конструктор класса
          int leftX,
          int leftY,
          int rightX,
          int rightY)
        {
            LeftSidePosition = new Point(leftX, leftY);    //позиция на левом берегу
            RightSidePosition = new Point(rightX, rightY); //позиция на правом берегу

            Position = LeftSidePosition;  //текущая позиция
        }

        public bool IsOnRightSide => Position == RightSidePosition;   //проверка на правом берегу

        public FacingDirection FacingDirection { get; private set; } = FacingDirection.Right;  //куда смотрят персонажи

        public int Width { get; } = 200;   //ширина персонажа
        public int Height { get; } = 200;  //высота персонажа

        public abstract Bitmap Image { get; }   //изображение

        public Point Position { get; private set; }  //текущая позиция персонажа

        public int X => Position.X;   //координата х
        public int Y => Position.Y;   //координата у

        protected Point LeftSidePosition { get; }   //позиция на лев берегу
        protected Point RightSidePosition { get; }  //позиция на прав берегк

        public abstract string Name { get; }

        public abstract bool CanOperateBoat { get; }  //может ли персонаж управлять лодкой

        public BoatSeat Seat { get; private set; } = BoatSeat.None;  //место в лодке

        public bool InBoat { get; private set; }  //находится ли он в лодке

        public void MoveToLeftSide()  //высадить на лев берег
        {
            Seat = BoatSeat.None;
            InBoat = false;

            Position = LeftSidePosition;   //позиция на лев берегу
            FacingDirection = FacingDirection.Right;  //лицо на право
        }

        public void MoveToRightSide()  //высадить на правв берег
        {
            Seat = BoatSeat.None;
            InBoat = false;

            Position = RightSidePosition;    //позиция на прав берегу
            FacingDirection = FacingDirection.Left;   // лицо на лево
        }

        public void MoveToBoatSeat(  //посадка в лодку
          Point seatPosition,
          BoatSeat seat,
          SideKind targetSide)
        {
            if (seat == BoatSeat.None)   //сидения в лодке
                throw new ArgumentException("Для посадки нужно указать место в лодке", nameof(seat));

            Seat = seat;
            InBoat = true;
            Position = seatPosition;

            FacingDirection = targetSide == SideKind.Right  //берег куда плывем
              ? FacingDirection.Right
              : FacingDirection.Left;
        }

        public void MoveBy(int dx, int dy = 0)  //перемещение 
        {
            Position = new Point(
              Position.X + dx,
              Position.Y + dy);
        }

        public virtual void Draw(Graphics graphics)  //отрисовка персонажа
        {
            if (FacingDirection == FacingDirection.Left)
            {
                graphics.TranslateTransform(X + Width, Y); //перевернуть
                graphics.ScaleTransform(-1, 1);
                graphics.DrawImage(Image, 0, 0, Width, Height);
                graphics.ResetTransform();
                return;
            }

            graphics.DrawImage(Image, X, Y, Width, Height);
        }

        public virtual bool IsActive(int x, int y)  //наличие пероснажа по коорд
            
        {
            if (x < X ||
              y < Y ||
              x >= X + Width ||
              y >= Y + Height)
            {
                return false;
            }

            int localX = x - X;
            int localY = y - Y;

            using var bitmap = new Bitmap(Image, Width, Height); 

            Color pixel = bitmap.GetPixel(localX, localY);

            return pixel.A > 10; //прозрачность(если тыкнули рядом, то засчитавется)
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
