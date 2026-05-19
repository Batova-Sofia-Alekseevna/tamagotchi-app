using TamagotchiApp.Pets;

namespace TamagotchiApp
{
    public partial class FoodForm : Form
    {
        private readonly Pet _pet;

        public FoodForm(Pet pet)
        {
            InitializeComponent();
            _pet = pet;
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            PetType type = _pet.Type switch
            {
                PetType.Dog => { },
                PetType.Cat => throw new NotImplementedException(),
                PetType.Hamster => throw new NotImplementedException(),
                PetType.Parrot => throw new NotImplementedException(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
