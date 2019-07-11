namespace Animals
{

    public class Kitten :  Cat
    {
        private const string DefaultKittenGender = "female";

        public Kitten(string name, int age, string gender = null )
            :base(name, age, DefaultKittenGender)
        {

        }


        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
