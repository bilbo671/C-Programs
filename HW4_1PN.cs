//<HW4_3PN.cs>
//<C# Programming to Find if a Number is Prime>
//NCU.edu
//School of Business and Technology Management
//<TIM-6110>
//Author: <William Jenkins>
//Date: <12-19-20>
using System;

namespace PrimeNum {
   class HW4_3PNPN {
      public static void Main() {
         Console.WriteLine("Enter a Number!");
         int n = Convert.ToInt32(Console.ReadLine()), a = 0;
         for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
               a++;
            }
         }

         if (a == 2) {
            Console.WriteLine(n + " is a Prime Number.");
         } else {
            Console.WriteLine(n + " is not a Prime Number.");
         }
         Console.ReadLine();
      }
   }
}
