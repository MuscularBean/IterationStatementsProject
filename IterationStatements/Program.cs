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
           
            int myNumber = 0;
          
            do
            {
                myNumber++;
                numbers.Add(myNumber);

            } while (myNumber < 100);

            while(myNumber < 200)
           
            {
                myNumber++; 
                numbers.Add(myNumber);    
     
            }

            Console.WriteLine("Increase:");



            foreach(var items in numbers) 
            {
                Console.WriteLine(items);
            }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");
           
            for (int i = 199; i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}"); 
            }

            //------------End of exercise
        }
    }
}
