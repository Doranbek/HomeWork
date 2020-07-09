using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkN8

{
    
    class Program
    {
        static void Main(string[] args)
        {
            var daysOnWeek = new string[] 
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            
            decimal[] tempStat= new decimal [daysOnWeek.Length];
            for (int i = 0; i < daysOnWeek.Length; i++)
            {
                
                while (true)
                {
                    Console.Write($"Enter body temperature for {daysOnWeek[i]}\n>");
                    var input = ((Console.ReadLine()));
                    if (input == "") break;
                    else if ((decimal.Parse(input) < 41) && (decimal.Parse(input) > 30)) 
                    {
                        tempStat[i] = (decimal.Parse(input));
                        break;
                    }
                    else Console.WriteLine("Body temperature incorrect");
                }
            }
            Dictionary<string, decimal> TempStatDictionary = new Dictionary<string, decimal>();
            for (int i = 0; i < daysOnWeek.Length; i++)
            {
                TempStatDictionary.Add(daysOnWeek[i], tempStat[i]);
            }
        }
        

       
    }
}
