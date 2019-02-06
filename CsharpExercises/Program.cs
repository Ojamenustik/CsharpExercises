using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* 
            Console.WriteLine("What is your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello "+name);
            Console.ReadLine();
            
            int maxInt = int.MaxValue;
            long maxLong = long.MaxValue;
            decimal maxDec = decimal.MaxValue;
            float maxFloat = float.MaxValue;
            double maxDouble = double.MaxValue;

            Console.WriteLine(maxInt);
            Console.WriteLine(maxLong);
            Console.WriteLine(maxDec);
            Console.WriteLine(maxFloat);
            Console.WriteLine(maxDouble);
           
            var anotherName = "Tom";
            Console.WriteLine("Another name is a {0}", anotherName);

            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) "+ (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1) "+ (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1) "+ (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1, number2) "+ (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2) "+ (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1)//podnoszenie do potegi "+ (Math.Pow(number1,2)));
            Console.WriteLine("Math.Round(number1) "+ (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) "+ (Math.Sqrt(number1)));
            

            //Random Numbers

            Random rand = new Random();


            //Relational Operators: > < >= <= == !=
            //Logical Operators: && || ^ !

            int age = rand.Next(1, 19);
            Console.WriteLine("Random Number between 1 and 18: " + age);

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elemantary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go home");
            }

            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                    Console.WriteLine("Toddler");
                    break;
                default:
                    Console.WriteLine("Child");
                    break;
            }

            string guess;
            do
            {
                Console.WriteLine("Guess a Number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));


            for (int i = 0; i < 10; i++)
            {
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
            }

            string randStr = " Uh oh ah random krach";
            foreach (char a in randStr)
            {
                Console.WriteLine(a);
            }

            /* \'  \"  \\  \b  \n  \t  */
            
            /*
            Console.WriteLine("Empty? " + String.IsNullOrEmpty(randStr));
            Console.WriteLine("Empty or just white spaces? " + String.IsNullOrWhiteSpace(randStr));
            Console.WriteLine("Length: " + randStr.Length);

            Console.WriteLine("Index of \"oh\" {0}", randStr.IndexOf("oh"));
            Console.WriteLine("2nd word: {0}", randStr.Substring(3, 4));

            bool b = randStr.StartsWith("a");
            bool b2 = randStr.EndsWith("h");

            Console.WriteLine("Trim:{0}", randStr.Trim()); //TrimEnd(), TrimStart()
            Console.WriteLine("Replace: {0}", randStr.Replace("random", "super"));
            Console.WriteLine("Remove: {0}", randStr.Remove(0, 3));
            */
            string[] names = new string[3] {"Matt", "Joe", "Paul"};
            int[] MyArray = {1, 2, 3, 4};

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, MyArray[i]);
            }

            foreach(int a in MyArray)
            {

                Console.WriteLine(a);
            }

            //Multidimential arrays

            int[,] multArray = new int[5, 3];
            int[,] multArray2 = {{1, 2}, {3, 4}, {5, 6}, {7, 8}};

            for (int i = 0; i < multArray2.GetLength(0); i++)
            {
                for (int j = 0; j < multArray2.GetLength(1); j++)
                {
                    Console.WriteLine("{0} | {1} : {2}", i,j, multArray2[i,j]);
                }
            }

            //List - resize for you

            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(25);
            numList.Add(35);

            int[] randArray = {1, 2, 3, 4, 5};
            numList.AddRange(randArray);

            List<int> numList2 = new List<int>(randArray);
            List<int> numList3 = new List<int>(new int[]{1,2,3,4,4,5,6,7});
            numList.Insert(5,10);
            //numList.Remove(5);

            for (int i = 0; i< numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            Console.WriteLine("4 is in index: "+numList.IndexOf(4));
            Console.WriteLine("5 in List: "+numList.Contains(5));

            List<string> strList = new List<string>(new String[] { "Tom", "Jerry" });

            Console.WriteLine("Tom in list "+strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            strList.Sort(); //alfabetycznie

            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine(strList[i]);
            }

            //Exceptions

            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10 / num));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero!");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
      
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            //Classes

            Animal spot = new Animal(15,10,"Spot", "Woof");
            Console.WriteLine("{0} says {1}.",spot.name, spot.sound);
            Console.WriteLine("Number of animals: " + Animal.getNumOfAnimals());
            Console.WriteLine(spot.toString());

            Animal Burczek = new Animal()
            {
                name = "Burczek",
                height = 12,
                weight = 6,
                sound = "Grrrr"
            };

            Dog burek = new Dog();
            Console.WriteLine(burek.toString());
            burek = new Dog(20,15,"Burek", "Woof", "Chicken");
            Console.WriteLine(burek.toString());

            Console.WriteLine(spot.getSum(num1: 1.4, num2: 2.7));
            Console.WriteLine("Number of animals: " + Animal.getNumOfAnimals());

          //Shapes////////////////

            Shape rect = new Rectangle(5,5);
            Shape tri = new Triangle(5,5);

            Console.WriteLine("Rectangle area: "+rect.area());
            Console.WriteLine("Triangle area: "+tri.area());

            Rectangle combRect = new Rectangle(5,5)+new Rectangle(5,5);
            Console.WriteLine("combRect area: "+combRect.area());

          //Generics

            KeyValue<string, string> superman = new KeyValue<string, string>("","");
            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0,"");
            samsungTV.key = 1234;
            samsungTV.value = "A 50\" Samsung TV";

            superman.showData();
            samsungTV.showData();

          //Enums

            Temperature microwaveTemp = Temperature.Low;

            switch(microwaveTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }

          //Structs
            
            Customers bob = new Customers();

            bob.createCust("BoB", 15.60, 12345);
            bob.showCust();

          //Anonymous Methods

            GetSum sum = delegate (double num1, double num2)
                { return num1 + num2; };
            Console.WriteLine("5+ 10 = " + sum(5, 10));

          //Lambda Expressions

            Func<int, int, int> getSum = (x, y) => x + y;
            Console.WriteLine("5 + 3 = "+ getSum.Invoke(5,3));

            List<int> CoolNumList = new List<int>() {5, 10, 15, 20, 25};
            List<int> OddNums = CoolNumList.Where(n => n % 2 == 1).ToList();

            foreach (var q in OddNums)
            {
                Console.WriteLine(q);
            }

            Console.ReadLine();
        }
    }
}
