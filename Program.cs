using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkN8

{

    class Program
    {
        static void Main(string[] args)
        {


            List<decimal> tempStat = new List<decimal>();
            int numDay = 1;

            while (true)
            {
                Console.Write($"Enter for  view statistics or set body temperature for {numDay}th day\n>");
                var input = ((Console.ReadLine()));
                if (input == "") break;
                else if ((decimal.Parse(input) < 41) && (decimal.Parse(input) > 30))
                {
                    tempStat.Add(decimal.Parse(input));
                    numDay++;
                }
                else Console.WriteLine("Body temperature incorrect");
            }


            Console.WriteLine("Your statistics daily body temperature");
            numDay = 1;
            foreach (var i in tempStat)
            {
                Console.WriteLine($"On {numDay}th day your body temperature was {i:0.0} °C");
                numDay++;
            }

            decimal min = tempStat.Min();
            decimal max = tempStat.Max();
            decimal avr = tempStat.Average();
            
            Console.WriteLine($"Your statistics daily body temperature Min:{min:0.0} Max:{max:0.0} Average{avr:0.0}");
            //foreach (var dayCount in tempStat)
            //{
            //    NewMethod(tempStat, dayCount);
            //}

          
            decimal normsize = (from i in tempStat where i <= (decimal)37.5 select i).Count();
            Console.WriteLine($"You had a low body temperature {normsize} days");

            decimal maxsize = (from i in tempStat where i >= (decimal)37.5 && i <= (decimal)38.3 select i).Count();
            Console.WriteLine($"You had a high body temperature {maxsize} days");

            decimal veryMaxsize = (from i in tempStat where i >= (decimal)38.3 select i).Count();
            Console.WriteLine($"You had a very high body temperature {veryMaxsize} days");


            Console.ReadKey();
        }

        //private static void NewMethod(List<decimal> tempStat, decimal dayCount)
        //{
        //    dayCount.Where(dayCount => dayCount == tempStat.Min).Count();
        //}
    }
}
