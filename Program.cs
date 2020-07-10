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
                    if (input == " ") break;
                    else if ((decimal.Parse(input) < 41) && (decimal.Parse(input) > 30))
                    {
                        tempStat[i] = (decimal.Parse(input)) ;
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
            Console.WriteLine("Your statistics daily body temperature");
            
            foreach (var i in TempStatDictionary)
               Console.WriteLine($"On {i.Key} your body temperature was {i.Value:0.0} °C");
            
            decimal min = tempStat.Min();
            decimal max = tempStat.Max();
            decimal avr = tempStat.Average();
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Your statistics daily body temperature Min:{min} Max:{max} Average{avr}");
            Console.ResetColor();
                                   
            decimal minsize = (from i in TempStatDictionary.Values where 36 > i select i).Count();
            Console.WriteLine($"You had a low body temperature for {minsize} days");
            
            decimal maxsize = (from i in TempStatDictionary.Values where 37 < i select i).Count();
            Console.WriteLine($"You had a high body temperature for {maxsize} days");
            
            Console.ReadKey();
        }

        
    }
}