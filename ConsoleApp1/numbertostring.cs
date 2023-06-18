using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class numbertostring
    {

       static void Main(string[] args)
        {
            int n, sum = 0, r;

            Console.WriteLine("Enter the number to convert into string: ");
            n=int.Parse(Console.ReadLine());

            while (n > 0)
            {
                r = n % 10;
             
                sum = sum * 10 + r;
                n=n / 10;
            }
            n = sum;
            Console.WriteLine(n);
            while (n > 0)
            {
               r=n % 10;
               

                switch (r) { 
                    case 1:
                        Console.Write("one");
                        break;

                        case 2: 
                        Console.Write("two");       
                        break;
                        case 3:
                        Console.Write("three");
                        break;  
                        case 4:
                        Console.Write("four");
                        break;
                        case 5:
                        Console.Write("five");
                        break;
                        case 6:
                        Console.Write("six");
                        break;
                        case 7:
                        Console.Write("seven"); 
                        break;
                         case 8:
                        Console.Write("eight");

                        break;
                        case 9:
                        Console.Write("nine");
                        break;
                        case 0:
                        Console.Write("zero");
                        break;
                    default:
                        Console.Write("ttt");
                        break;


                }

                n = n / 10;
            }
        }
    }
}
