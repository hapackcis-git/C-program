//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Armstrong
//    {
//        static void Main(string[] args)
//        {
//            int n,r,sum=0;
//            Console.WriteLine("Enter the number to check: ");
//            n=int.Parse(Console.ReadLine());
//            int temp = n;

//            while(n>0)
//            {
//                r = n % 10;
//                sum = sum + (r * r * r);
//                n = n / 10;
                
//            }
//            if (temp == sum)
//            {
//                Console.WriteLine("The is armstrong number");
//            }
//            else
//            {
//                Console.WriteLine("The  number is not armstrong number");
//            }
//        }
//    }
//}
