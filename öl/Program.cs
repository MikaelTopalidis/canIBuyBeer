using System;

namespace canIBuyBeer
{
    class Program
    {
        static bool CanIBuyBeer(int age, string location, string legg, decimal promille)
        {
            if (legg != "J")
                return false;
            if (promille > 1.0m)
                return false;
            if (age > 15 && location == "skola")
                return true;
            if (age > 17 && location == "krogen")
                return true;
            if (location == "krogen")
                return true;
            return false;
            

        }
    }
    
        static void Main(string[] args)
        {
        //om ålder är > 17 och location == "krogen" OCH om leg == "j" OCH om prompille < 1.0
        // Om ålder > 19 och location == "systemet" OCH om leg == "j" OCH om prompille < 1.0
        Console.WriteLine("Superduper beer calculatorr 1.0");

            Console.Write("Mata in din ålder: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in din plats: ");
            string location = Console.ReadLine();
            location = location.ToLower();

            Console.Write("Har du leg (J/N):  ");
            string legg = Console.ReadLine();
            Console.Write("Vad är din promillehalt: ");
            decimal promille = Convert.ToDecimal(Console.ReadLine());

            

            bool canIBuyBear = false;


            //if (legg == "J" && promille < 1.0m)
            //{
            //    if (location == "krogen" && age > 17)
            //    {
            //        canIBuyBear = true;
            //    }
            //    else if (location == "systemet" && age > 19)
            //    {
            //        canIBuyBear = true;
            //    }
 
            //}
            if (canIBuyBear)
            {
                Console.WriteLine("du får köpa öl");
            }
            else
                Console.WriteLine("nej nej nej");

            //if (age > 17 && location == "krogen" && id == "J" && promille < 1.0m)

            //{
            //    Console.WriteLine("Du får köpa öl!");
            //}

            //else if (age > 19 && location == "systemet" && id == "J" && promille < 1.0m)
            //{
            //    Console.WriteLine("Du får handla på systemet");
            //}

            //else
            //    Console.WriteLine("NEJ NEJ NEJ");






        }
    
}
