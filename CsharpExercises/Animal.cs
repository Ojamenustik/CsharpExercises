using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "No sound";
            this.name = "No name";
            NumOfAnimals++;
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight =weight;
            this.sound = sound;
            this.name = name;
            NumOfAnimals++;
        }

        private static int NumOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return NumOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}.", name, height, weight,
                sound);
        }
    }
}
