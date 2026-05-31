namespace TamagotchiApp.Pets.Animals
{
    public class Cat(string name, double age) : Pet(name, age, PetConfigPresets.Cat)  //создание класса кошки, на основе Pet
    {
        public override Dictionary<PetState, Image> Images => new()  //словарь изображений
{
  { PetState.Base,  Properties.Resources.cat_base},
  { PetState.Sleeping, Properties.Resources.cat_sleeping},
  { PetState.Singing,  Properties.Resources.cat_singing},
  { PetState.Sad, Properties.Resources.cat_sad},
  { PetState.Angry,  Properties.Resources.cat_angry},
  { PetState.Happy, Properties.Resources.cat_happy},
  { PetState.Crying,  Properties.Resources.cat_crying},
  { PetState.Enamored, Properties.Resources.cat_enamored},
  { PetState.Sick, Properties.Resources.cat_sick}
};

        public override PetType Type => PetType.Cat;  // тип питомца
    }
}
