using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

        //Override Class Methods

        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }
    }


    //Inheritance
    class Dog : Animal
    {
        public string favFood { get; set; }

        public Dog() : base() //Call Superclass Methods
        {
            this.favFood = "No favorite Food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(height,weight,name,sound)
        {
            this.favFood = favFood;
        }

        new public string toString() //Override Class Methods
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}.", name, height, weight,
                sound, favFood);
        }
    }


    //Shapes/////////////////////////////////

    abstract class Shape
    {
        public abstract double area();

        public void Hi()
        {
            Console.WriteLine("Hello"); //cialo funkcji
        }
    }

    public interface ShapeItem
    {
        double area();
    }

    class Rectangle : Shape
    {
        private double lenght;
        private double width;

        public Rectangle(double num1, double num2)
        {
            lenght = num1;
            width = num2;
        }

        public override double area()
        {
            return lenght * width;
        }

        //Operator Overloading
        public static Rectangle operator +(Rectangle rect1, Rectangle rect2) //public static Rectangle Dodaj(Rectangle rect1, Rectangle rect2)
        {
            double rectLenght = rect1.lenght + rect2.lenght;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLenght, rectWidth);
        }
    }

    class Triangle : Shape
    {
        private double theBase;
        private double width;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            width = num2;
        }

        public override double area()
        {
            return 0.5 *(theBase * width);
        }
    }

    //Generics
    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }
    }

    //Enums

    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    //Structs
    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        public void createCust(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCust()
        {
            Console.WriteLine("Name {0}", name);
            Console.WriteLine("Balance {0}", balance);
            Console.WriteLine("ID {0}", id);
        }
    }
}
