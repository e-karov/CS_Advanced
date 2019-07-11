using System.Text;

namespace Animals
{

    public class Animal
    {
        private string name;

        private int age;

        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (value.Length < 1)
                {
                    throw new System.ArgumentException("Invalid input!");
                }

                this.name = value;
            }

        }

        public int Age
        {
            get
            {
                return this.age;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Invalid input!");
                }

                this.age = value;
            }
        }

        public virtual string Gender { get; protected set; }
       


        public virtual string ProduceSound()
        {
            return "Some sound";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.name} {this.age} {this.gender}");
            sb.AppendLine($"{ProduceSound()}");
            return sb.ToString().TrimEnd();
        }
    }
}
