namespace Animals
{

    public class Tomcat : Cat
    {
        private const string DefaultTomcatGender = "Male";

        public Tomcat(string name, int age)
            : base(name, age, DefaultTomcatGender)
        {

        }


        public override string ProduceSound()
        {
            return $"MEOW";
        }
    }
}
