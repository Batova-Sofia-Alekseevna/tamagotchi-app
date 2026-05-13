namespace TamagotchiApp.Pets
{
    public class Parrot(string name, double age) : Pet(name, age, PetConfigPresets.Parrot)
    {
        public override Dictionary<PetState, Image> Images => new()
{
  { PetState.Base,  Properties.Resources.parrot_base},
  { PetState.Sleeping, Properties.Resources.parrot_sleeping},
  { PetState.Singing,  Properties.Resources.parrot_singing},
  { PetState.Sad, Properties.Resources.parrot_sad},
  { PetState.Angry,  Properties.Resources.parrot_angry},
  { PetState.Happy, Properties.Resources.parrot_happy},
  { PetState.Crying,  Properties.Resources.parrot_crying},
  { PetState.Enamored, Properties.Resources.parrot_enamored},
  { PetState.Sick, Properties.Resources.parrot_sick}
};
    }
}
