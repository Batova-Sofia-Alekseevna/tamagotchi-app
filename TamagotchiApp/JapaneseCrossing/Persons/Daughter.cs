using System.Drawing.Drawing2D;

namespace TamagotchiApp.JapaneseCrossing.Persons
{
    public class Daughter : Person
    {
        public Daughter(int leftX, int leftY, int rightX, int rightY)  //позиция на левом и правом берегу
            : base(leftX, leftY, rightX, rightY) //передаем в конструктор базового класса
        {
        }

        public override Bitmap Image => Properties.Resources.dauther;

        public override string Name => "Дочь";
        public override bool CanOperateBoat => false;
    }
}
