//<HW4_4RT.cs>
//<C# Programming to Find if Rectangles Overlap>
//NCU.edu
//School of Business and Technology Management
//<TIM-6110>
//Author: <William Jenkins>
//Date: <12-19-20>
using System; 
      
class GFG  
{ 
    class Point  
    { 
        public int x, y; 
    } 
  
    // Returns true if two rectangles (l1, r1)  and (l2, r2) overlap.  
    static bool doOverlap(Point l1, Point r1, 
                          Point l2, Point r2)  
    { 
        // If one rectangle is on the left side of other.  
        if (l1.x >= r2.x || l2.x >= r1.x) 
        { 
            return false; 
        } 
        // If one rectangle is above the other.  
        if (l1.y <= r2.y || l2.y <= r1.y)  
        { 
            return false; 
        } 
        return true; 
    } 
    // Code for user input.
    public static void Main()  
    { 
        Point l1 = new Point(), r1 = new Point(), 
                l2 = new Point(), r2 = new Point(); 
        Console.WriteLine("Enter X and Y for corner 1 of rectangle 1.");
        l1.x = Convert.ToInt32(Console.ReadLine());
        l1.y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X and Y for corner 2 of rectangle 1.");
        r1.x = Convert.ToInt32(Console.ReadLine());
        r1.y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X and Y for corner 2 of rectangle 1.");
        l2.x = Convert.ToInt32(Console.ReadLine());
        l2.y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter X and Y for corner 2 of rectangle 1.");
        r2.x = Convert.ToInt32(Console.ReadLine());
        r2.y = Convert.ToInt32(Console.ReadLine());
        if (doOverlap(l1, r1, l2, r2)) 
        { 
            Console.WriteLine("The rectangles overlap in the 2D plane."); 
        } else
        { 
            Console.WriteLine("The rectangles do not overlap in the 2D plane."); 
        } 
    } 
} 
