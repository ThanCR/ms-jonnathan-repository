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

            //int value1 = 4;
            //int value2 = 10;

            //Console.WriteLine($"Result: {value1 + value2 }");

            //int result = value1+ value2;

            //Console.WriteLine($"Result: {result}");

            //EXECUTING SUM FUNCTION
            //sum(1, 4);

            //EXECUTING SUBSTRACT FUNCTION
            //Console.WriteLine($"Result: {substract(10,4)}"

            //---------------------------------------------------------------------------

            //CREATING OBJECTS 
            Person person1 = new Person("Jonnathan", 22, "Rios");
            Person person2 = new Person("Kevin", 17, "Viquez");
            Person person3 = new Person("Ana", 29, "Alvarado");

            Person[] people = { person1, person2, person3 };
            //Person[] people = new Person[3];

            //Console.WriteLine(person1.ToString());
            //Console.WriteLine("\n-------------------------------");
            //Console.WriteLine(person2.ToString());
            //Console.WriteLine("\n-------------------------------");
            //Console.WriteLine(person3.ToString());

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine(people[i].ToString());
            //    Console.WriteLine("\n-------------------------------");
            //}

            //Console.WriteLine(person2.legalAge);
            //Console.WriteLine(person1.legalAge);


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