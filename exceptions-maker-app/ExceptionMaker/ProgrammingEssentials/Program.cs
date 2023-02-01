using System.Diagnostics.CodeAnalysis;
using ProgrammingEssentials.Models;

namespace ProgrammingEssentials
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-----------------APPLICATION STARTED--------------\n");

            //VARIABLES
            //integer-double-decimal-byte - string-char - bool 
            //int value1 = 4;
            //int value2 = 14;

            //Console.WriteLine($"Result: {value1 + value2}");

            //int result = value1 + value2;

            //Console.WriteLine($"Result: {result}");

            //EXECUTING SUM FUNCTION
            //sum(1, 4);


            //EXECUTING SUBSTRACT FUNCTION
            //Console.WriteLine($"Result: {substract(10, 4)}");

            //---------------------------------------------------------------------------

            //CREATING OBJECTS 
            Person person1 = new Person("Jonnathan", 22, "Rios");
            Person person2 = new Person("Kevin", 17, "Viquez");
            Person person3 = new Person("Yerelin", 40, "Contreras");
            Person person4 = new Person("Yerelin", 40, "Contreras");
            Person person5 = new Person("Yerelin", 40, "Contreras");
            Person person6 = new Person("Yerelin", 40, "Contreras");
            Person person7 = new Person("Yerelin", 40, "Contreras");
            Person person8 = new Person("Yerelin", 40, "Contreras");
            Person person9 = new Person("Yerelin", 40, "Contreras");
            Person person10 = new Person("Yerelin", 40, "Contreras");
            Person person11 = new Person("Yerelin", 40, "Contreras");
            Person person12 = new Person("Yerelin", 40, "Contreras");

            Person[] people = { person1, person2, person3, person4, person5, person6 };
            //Person[] people = new Person[3];

            //Console.WriteLine(person1.age + 2);

            //Console.WriteLine("\n-------------------------------");
            //Console.WriteLine(person2.ToString());
            //Console.Writ//Console.WriteLine(person1.ToString());
            //ConsoleLine("\n-------------------------------");
            //Console.WriteLine(person3.ToString());

            //Console.WriteLine(people[0]);

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine(people[i].ToString());
            //    Console.WriteLine("\n-------------------------------");
            //}

            //int i = 0;
            //while (i < people.Length)
            //{
            //    Console.WriteLine(people[i].ToString());
            //    Console.WriteLine("\n-------------------------------");
            //    i++;
            //}

            Console.WriteLine(person2.legalAge);
            Console.WriteLine(person1.legalAge);


            Console.WriteLine("\n-----------------APPLICATION ENDED--------------");
        }

        //VOID FUNCTIONS
        public static void sum(int parameter1, int parameter2)
        {
            Console.WriteLine($"RESULT: {parameter1 + parameter2}");


        }

        //RETURNING FUNCTIONS
        public static int substract(int parameter1, int parameter2)
        {
            return parameter1 - parameter2;
        }

    }
}