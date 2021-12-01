using System;
using System.Collections.Generic;
using System.Text;

namespace N_Factorial
{
    public class Factorial_Calculator
    {
        
        
        

        public int Calculator(int n=5)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n>0 && n!=0)
                {
                    result *= i;
                }
                else
                {
                    Console.WriteLine("Don't Enter 0 or Negative Number");
                }
            }
             return result;
            Console.WriteLine(result);
            
        }

    } 
}
   
