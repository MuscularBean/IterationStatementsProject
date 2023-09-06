using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
           
            int num = 0;
          
            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);


            do
            {
                num++; 
               
                numbers.Add(num);    
     
            } while (num < 100);

            Console.WriteLine("Increase:");



            foreach(var items in numbers) 
            {
                Console.WriteLine(items);
            }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");
           
            for (var i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]); 
            }

            //------------End of exercise
        }
    }
}
