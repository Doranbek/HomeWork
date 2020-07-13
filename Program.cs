using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HomeWorkN8

{

    class Program
    {
        static void Main(string[] args)
        {

            bool boolMes;
            do
            {
                Start();
                BodyTemperatur();
                boolMes = End();
            } while (boolMes == false);
            

            static void Start()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\tHello, the BODYTEMPERATURE program welcomes you!\n" +
                    "\tIf you enter values below 30 and above 41, the program will warn you.\n " +
                    "\t\t\tDo not be ill! Wear a mask!\n\t\t\tTo start, press any key.");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }

            static void BodyTemperatur()
            {
                List<decimal> temStatInput = new List<decimal>();
                int numDay = 1;

                while (true)
                {
                    Console.Write($"Enter for  view statistics or set body temperature for {numDay}th day\n>");
                    var input = ((Console.ReadLine()));
                    if (input == "") break;
                    else if ((decimal.Parse(input) <= 41) && (decimal.Parse(input) >= 30))
                    {
                        temStatInput.Add(decimal.Parse(input));
                        numDay++;
                    }
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Body temperature incorrect");
                        Console.ResetColor();
                    }
                    
                }
                
                Console.Clear();

                Output(temStatInput);
                
                
                
            }
            static void Output(List<decimal> tempStat) 
            {
                int numDay = 1;
                foreach (var i in tempStat)
                {
                    Console.WriteLine($"\nOn {numDay}th day your body temperature was {i:0.0} °C");
                    numDay++;
                }

                decimal min = tempStat.Min();
                decimal max = tempStat.Max();
                decimal avr = tempStat.Average();

                Console.WriteLine($"\nYour statistics daily body temperature Min:{min:0.0} Max:{max:0.0} Average{avr:0.0}");

                decimal normsize = (from i in tempStat where i <= (decimal)37.5 select i).Count();
                Console.WriteLine($"You had a low body temperature {normsize} days");

                decimal maxsize = (from i in tempStat where i >= (decimal)37.5 && i <= (decimal)38.3 select i).Count();
                Console.WriteLine($"You had a high body temperature {maxsize} days");

                decimal veryMaxsize = (from i in tempStat where i >= (decimal)38.3 select i).Count();
                Console.WriteLine($"You had a very high body temperature {veryMaxsize} days");
            }
                        
            static bool End()
            {
                Console.WriteLine("\nTo continue press any key \nTo exit the program press \"Q\"");
                string exit =Console.ReadLine().ToUpper();
                bool message = exit == "Q";                         
                return message;
            }

            
        }

    }
}
