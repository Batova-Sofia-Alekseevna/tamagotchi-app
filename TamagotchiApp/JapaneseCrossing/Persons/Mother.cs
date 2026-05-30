using System.Drawing.Drawing2D;

namespace TamagotchiApp.JapaneseCrossing.Persons
{
    public class Mother : Person
    {
        public Mother(int leftX, int leftY, int rightX, int rightY)
            : base(leftX, leftY, rightX, rightY)
        {
        }

        public override Bitmap Image => Properties.Resources.mother;
        public override string Name => "Мать";
        public override bool CanOperateBoat => true;
    }
}
