//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    internal class CSFeatures
//    {
//        public static void Main()
//        {
//            Action<string> action = (string name) => { Console.WriteLine($"Hai {name}"); };

//            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hai {s1}, " + $" you said {s2}"); };

//            //Action<string, string, string> action2 = (string s1, string s2, string s3) => { Console.WriteLine( $" Hai {s1}, ")}

//            action.Invoke("Mary");
//            action1.Invoke("Mary", "am in BGLR");

//            Func<int, int, long> multiply = (x, y) =>
//            {
//                return x * y;
//            };
//            long result = multiply(100, 100);
//            Console.WriteLine(result);
//        }
//    }
//}
