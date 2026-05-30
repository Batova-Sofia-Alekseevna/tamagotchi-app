namespace TamagotchiApp.JapaneseCrossing.Persons
{
    public class Criminal : Person
    {
        public Criminal(int leftX, int leftY, int rightX, int rightY)   //позиция на левом и правом берегу
            : base(leftX, leftY, rightX, rightY)   //передаем в конструктор базового класса
        {
        }

        public override string Name => "Преступник";   //название персонажа
        public override bool CanOperateBoat => false;  //может ли управлять лодкой - нет

        public override Bitmap Image => Properties.Resources.criminal; //картинка персонажа
    }
}
