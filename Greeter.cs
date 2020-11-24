using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneChallenges
{
    public class Greeter
    {
        TimeSpan noon = new TimeSpan(12, 0, 0);
        TimeSpan eve = new TimeSpan(18, 0, 0);
        TimeSpan night = new TimeSpan(22, 0, 0);
        TimeSpan now;

        public Greeter()
        {
            now = DateTime.Now.TimeOfDay;
        }

        public void Greets(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void Farewell(string name)
        {
            Console.WriteLine($"Farewell, {name}");
        }

        public void TimeGreets(string name)
        {
            now = DateTime.Now.TimeOfDay;
            if (now < noon)
            {
                Console.WriteLine($"Good morning, {name}!");
            }
            else if (now > noon && now < eve)
            {
                Console.WriteLine($"Good afternoon, {name}!");
            }
            else if(now > eve && now < night)
            {
                Console.WriteLine($"Good evening, {name}!");
            }
            else if(now > night)
            {
                Console.WriteLine($"Good night, {name}!");
            }
        }
    }
}
