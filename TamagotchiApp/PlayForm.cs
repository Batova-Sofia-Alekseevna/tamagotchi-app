using TamagotchiApp.Pets;
using TamagotchiApp.Pets.Animals;

namespace TamagotchiApp
{
    public partial class PlayForm : Form
    {
        private readonly Pet _pet;

        public event Action? Played;

        public PlayForm(Pet pet)
        {
            InitializeComponent();
            _pet = pet;
        }


        private void PlayForm_Load(object sender, EventArgs e)
        {
            switch (_pet.Type)
            {
                case PetType.Dog:
                    btnPlay1.BackgroundImage = Properties.Resources.ball;
                    btnPlay2.BackgroundImage = Properties.Resources.wand;
                    btnPlay3.BackgroundImage = Properties.Resources.catch_up;
                    break;

                case PetType.Cat:
                    btnPlay1.BackgroundImage = Properties.Resources.ball;
                    btnPlay2.BackgroundImage = Properties.Resources.игрушка_кошка;
                    btnPlay3.BackgroundImage = Properties.Resources.игрушка_кошка_2;
                    break;

                case PetType.Hamster:
                    btnPlay1.BackgroundImage = Properties.Resources.игрушка_хомяк;
                    btnPlay2.BackgroundImage = Properties.Resources.игрушка_хомяк_2;
                    btnPlay3.BackgroundImage = Properties.Resources.игрушка_хомяк_3;
                    break;

                case PetType.Parrot:
                    btnPlay1.BackgroundImage = Properties.Resources.игрушка_попугай;
                    btnPlay2.BackgroundImage = Properties.Resources.игрушка_попугай_2;
                    btnPlay3.BackgroundImage = Properties.Resources.игрушка_попугай_3;
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void BtnPlay1_Click(object sender, EventArgs e)
        {
            Played?.Invoke();
            Close();
        }

        private void BtnPlay2_Click(object sender, EventArgs e)
        {
            Played?.Invoke();
            Close();
        }

        private void BtnPlay3_Click(object sender, EventArgs e)
        {
            Played?.Invoke();
            Close();
        }
    }
}
