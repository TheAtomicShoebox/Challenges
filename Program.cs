using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Adam";
            string lastName = "Schubach";
            int age = 23;

            string[] favorites = { "Shadow of the Conqueror", "V for Vendetta", "The Martian", "Life of Brian" };

            List<DateTime> dateList = new List<DateTime>()
            {
                DateTime.Now,
                new DateTime(1444, 11, 11),
                new DateTime(2020, 11, 03)
            };

            Console.WriteLine(age + 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age + 7);
            Console.WriteLine(age % 7);
            Console.WriteLine(age / 7);

            Console.WriteLine("How many hours of sleep did you get?");
            int hoursSleep = Convert.ToInt32(Console.ReadLine());

            if (hoursSleep >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursSleep > 8 && hoursSleep < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursSleep > 4 && hoursSleep < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man get some sleep");
            }

            Console.WriteLine("How was your day?");
            string dayQuality = Console.ReadLine();

            switch (dayQuality)
            {
                case "Great":
                    Console.WriteLine("Awesome!");
                    break;
                case "Good":
                    Console.WriteLine("Good! You can make it even better!");
                    break;
                case "Okay":
                    Console.WriteLine("That's OK! Let's make it better.");
                    break;
                case "Bad":
                    Console.WriteLine("Unfortunate. Let's see if we can improve it.");
                    break;
                default:
                    Console.WriteLine("Response unrecognized. Your day has been terminated.");
                    break;
            }

            string longword = "Supercalifragilisticexpialidocious";

            for (int i = 0; i < longword.Length; i++)
            {
                Console.WriteLine(longword[i]);
            }

            for (int i = 0; i < longword.Length; i++)
            {
                if (longword[i] == 'i')
                {
                    Console.WriteLine(longword[i]);
                }
                else if (longword[i] == 'l')
                {
                    Console.WriteLine(longword[i]);
                }
                else
                {
                    Console.WriteLine("Not an i or l");
                }
            }

            Console.WriteLine($"The number of letters in the word is {longword.Length}");

            Greeter greet = new Greeter();

            greet.Greets("Adam");
            greet.Farewell("Adam");
            greet.TimeGreets("Adam");
            Console.ReadLine();


            //Week 4
            Samsung samsung = new Samsung()
            {
                BluetoothCapable = true,
                Height = 8,
                ID = "21198621986",
                OS = "Android Q",
                Resolution = 2160
            };

            Apple apple = new Apple()
            {
                BluetoothCapable = true,
                Height = 8,
                ID = "216821684621",
                OS = "iOS 12",
                Resolution = 2160,
                IsBad = true
            };
        }
    }
}
