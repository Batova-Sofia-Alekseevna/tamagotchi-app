namespace TamagotchiApp.Pets
{
    public class Hamster(string name, double age) : Pet(name, age, PetConfigPresets.Humster)
    {
        public override Dictionary<PetState, Image> Images => new()
{
  { PetState.Base,  Properties.Resources.hamster_base},
  { PetState.Sleeping, Properties.Resources.hamster_sleeping},
  { PetState.Singing,  Properties.Resources.hamster_singing},
  { PetState.Sad, Properties.Resources.hamster_sad},
  { PetState.Angry,  Properties.Resources.hamster_angry},
  { PetState.Happy, Properties.Resources.hamster_happy},
  { PetState.Crying,  Properties.Resources.hamster_crying},
  { PetState.Enamored, Properties.Resources.hamster_enamored},
  { PetState.Sick, Properties.Resources.hamster_sick}
};
    }
}
