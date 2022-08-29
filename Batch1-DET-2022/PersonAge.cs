//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class PersonAge
//    {
//        public static void Main()
//        {
//            try
//            {
//                Console.WriteLine("enter age b.w 1 - 120");
//                int Age = Convert.ToInt32(Console.ReadLine());
//                if (Age < 1 || Age > 120)
//                    throw new InvalidAgeException("Entered Age is not in the range...");
//                else
//                    Console.WriteLine($"age is {Age}");
//            }
//            catch (InvalidAgeException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            catch (Exception e)
//            { }
//        }
//    }
//}
