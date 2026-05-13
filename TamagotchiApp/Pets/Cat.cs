namespace TamagotchiApp.Pets
{
    public class Cat(string name, double age) : Pet(name, age, PetConfigPresets.Cat)
    {
        public override Dictionary<PetState, Image> Images => new()
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

    }
}
