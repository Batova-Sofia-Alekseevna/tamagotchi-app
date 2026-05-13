namespace TamagotchiApp.Pets
{
    public class Dog(string name, double age) : Pet(name, age, PetConfigPresets.Dog)
    {
        public override Dictionary<PetState, Image> Images => new()
{
  { PetState.Base,  Properties.Resources.dog_base},
  { PetState.Sleeping, Properties.Resources.dog_sleeping},
  { PetState.Singing,  Properties.Resources.dog_singing},
  { PetState.Sad, Properties.Resources.dog_sad},
  { PetState.Angry,  Properties.Resources.dog_angry},
  { PetState.Happy, Properties.Resources.dog_happy},
  { PetState.Crying,  Properties.Resources.dog_crying},
  { PetState.Enamored, Properties.Resources.dog_enamored},
  { PetState.Sick, Properties.Resources.dog_sick}
};
    }
}
