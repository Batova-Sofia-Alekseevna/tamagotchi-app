using TamagotchiApp.Pets;
using TamagotchiApp.Pets.Animals;

namespace TamagotchiApp
{
    public partial class FoodForm : Form
    {
        private readonly Pet _pet;

        public event Action? Fed;

        public FoodForm(Pet pet)
        {
            InitializeComponent();    //инициализация формы
            _pet = pet;
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            switch (_pet.Type)
            {
                case PetType.Dog:
                    btnFood1.BackgroundImage = Properties.Resources.корм;
                    btnFood2.BackgroundImage = Properties.Resources.лакомство;
                    btnFood3.BackgroundImage = Properties.Resources.мясо;
                    break;

                case PetType.Cat:
                    btnFood1.BackgroundImage = Properties.Resources.корм;
                    btnFood2.BackgroundImage = Properties.Resources.лакомство_кошка;
                    btnFood3.BackgroundImage = Properties.Resources.трава_кошка;
                    break;

                case PetType.Hamster:
                    btnFood1.BackgroundImage = Properties.Resources.корм_хомяк;
                    btnFood2.BackgroundImage = Properties.Resources.лакомство_хомяк;
                    btnFood3.BackgroundImage = Properties.Resources.трава_хомяк;
                    break;

                case PetType.Parrot:
                    btnFood1.BackgroundImage = Properties.Resources.корм_хомяк;
                    btnFood2.BackgroundImage = Properties.Resources.лакомство_попугай;
                    btnFood3.BackgroundImage = Properties.Resources.трава_хомяк;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void BtnFood1_Click(object sender, EventArgs e)  //вызывает события, покормили питомца
        {
            Fed?.Invoke();
            Close();
        }

        private void BtnFood2_Click(object sender, EventArgs e)
        {
            Fed?.Invoke();
            Close();
        }

        private void BtnFood3_Click(object sender, EventArgs e)
        {
            Fed?.Invoke();
            Close();
        }
    }
}
