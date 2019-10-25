using System;
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


        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public string Name
        {
            get => this.name;

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
            }

        }

        public int Age
        {
            get => this.age;

            protected set
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.age = value;
            }

        }

        public string Gender
        {
            get => this.gender;

            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.gender = value;
            }

        }

        public virtual string ProduceSound()
        {
            return "Animal`s sound";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(this.ProduceSound());

            return sb.ToString().TrimEnd();
        }
    }
}
