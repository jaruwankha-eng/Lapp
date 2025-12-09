using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            //TODO: calculate birth year of user and display to console
            //-----------------------------------------------------------------------------------
            //convert string to int
            try
            {
                int age = Int32.Parse(ageInput);
                int birthYear = 2025 - age;
                Console.WriteLine("Oh! " + ageInput + " So your birth year is " + birthYear);
                //if/else/switch
                /*Generation X(Gen X) 1965-1980
                 *Generation Y(Millennials) 1981-1996
                 *Generation Z 1997-2012
                 *Generation Alpha 2013-present
                 */
                if (birthYear >= 1965 && birthYear <= 1980)
                    Console.WriteLine("You are from Generation X.");
                if (birthYear >= 1981 && birthYear <= 1996)
                    Console.WriteLine("You are from Generation Y.");
                if (birthYear >= 1997 && birthYear <= 2012)
                    Console.WriteLine("You are from Generation Z.");
                if (birthYear >= 2013)
                    Console.WriteLine("You are from Generation Alpha.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("You input wrong number.");
            }

        }
    }
}
