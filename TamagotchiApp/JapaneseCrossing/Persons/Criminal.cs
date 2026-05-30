using System.Drawing.Drawing2D;

namespace TamagotchiApp.JapaneseCrossing.Persons
{
    public class Criminal : Person
    {
        public Criminal(int leftX, int leftY, int rightX, int rightY)
            : base(leftX, leftY, rightX, rightY)
        {
        }

        public override string Name => "Преступник";
        public override bool CanOperateBoat => false;

        public override Bitmap Image => TamagotchiApp.Properties.Resources.criminal;
    }
}
