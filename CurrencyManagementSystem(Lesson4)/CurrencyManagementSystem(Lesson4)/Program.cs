using System;

namespace New_Home_task__Lesson_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Məbləğ(AZN) : 
            int Budget = 10000;

            double USD = 1.7000;
            double EUR = 1.6833;
            double RUB = 0.0282;

            Console.WriteLine(Budget * USD);
            Console.WriteLine(Budget * EUR);
            Console.WriteLine(Budget * RUB);



            //Task2 
            long governmentBudget = 20000000000;
            double MinistryOfDefense = governmentBudget * (0.2);
            double MinistryOfHighTechnologcy = governmentBudget * (0.1);
            double RestofBudget = governmentBudget - MinistryOfDefense - MinistryOfHighTechnologcy;
            Console.WriteLine("GovernmentBudget" + governmentBudget);
            Console.WriteLine("MinistryOfDefense:" + MinistryOfDefense);
            Console.WriteLine("MinistryOfHighTechnologcy" + MinistryOfHighTechnologcy);
            Console.WriteLine("RestofBudget:" + RestofBudget);

            ;
            //Task3

            int Adidas = 200;
            int Gucci = 1000;
            int Nike = 150;


            string : Firma:
            Adidas
            Ayaqqabı sayı:
            4
            Birinin qiyməti($) :
            200
            Hamısının birlikdə qiyməti($) :
            
                800

        }
    }
}
