//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    //public class Linq
//    //{
//        //public static void Main()
//        //{
//        //    //three parts in linq query
//        //    //1. data source
//        //    List<int> numbers = new List<int>();
//        //    numbers.Add(110);
//        //    numbers.Add(200);
//        //    numbers.Add(300);
//        //    numbers.Add(400);

//        //    //2. query creation
//        //   // var numQuery = from num in numbers
//        //     //              where num>200
//        //    //             select num;
//        //    //var numQuery = (from num in numbers
//        //     //             select num).ToList();

//        //    // lambda expr
//        //    var numQuery = numbers.Where(x=>x>200);

//        //    numbers.Add(500);


//        //    foreach (int num in numQuery)
//        //    {
//        //        Console.WriteLine("{0}", num);
//        //    }
//        //    Console.ReadLine();

//       // public static void Main()
//        //    {
//        //    int[] numbers = { 2, 5, 3, 9 };
//        //    var result = numbers.Reverse();
//        //    //var result = numbers.OrderByDescending(x => x);
//        //    //var result = numbers.OrderBy(x => x);
//        //    Console.WriteLine("List of numbers: ");
//        //     foreach (int number in result)
//        //        Console.WriteLine(number);


//        //}

//        //{
//        //    int[] numbers = { 2, 5, 3, 9 };

//        //    var result = numbers.OrderBy(d => d).ThenByDescending(d => d);

//        //    Console.WriteLine("List of numbera first ordered by year descending, and then by month descending:");
//        //    foreach (int number in result)
//        //        Console.WriteLine(result);
//        //}



//       // {
//            //string[] words = { "circle", "square", "rect", "polygon", "abcd" };
//            //string[] empty = { };
//            //string[] word1 = { "triangle" };

//            //var result = words.Skip(4);

//            //Console.WriteLine("Skips the first 4 words:");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);



//            //var result = words.SkipWhile(w => w.Length == 6);

//            //Console.WriteLine("Skips words while the condition is met:");
//            //foreach (string word in result)
//            //    Console.WriteLine(word);



//            //var result = words.Take(3);

//            //Console.WriteLine("Takes the first 3 words only:");
//            //foreach (var word in result)
//            //    Console.WriteLine(word);





//            //var result = words.TakeWhile(n => n.Length < 7);

//            //Console.WriteLine("Takes words one by one, and stops when condition is no longer met:");
//            //foreach (var word in result)
//            //    Console.WriteLine(word);



//            //                                       var numbers = new int[] { 7, 1, 2, 2, 3, 2, 3 };
//            //var numbers1 = new int[] { 3, 4 };

//            //var result = numbers.Aggregate((a, b) => a * b);

//            //Console.WriteLine("Aggregated numbers by multiplication:");
//            //Console.WriteLine(result);



//            //var result = numbers.Average();

//            //Console.WriteLine("Average is:");
//            //Console.WriteLine(result);



//            //var result = words.Count();

//            //Console.WriteLine("Counting words gives:");
//            //Console.WriteLine(result);



//            //var result = numbers.Max();

//            //Console.WriteLine("Highest number is:");
//            //Console.WriteLine(result);



//            //var result = numbers.Min();

//            //Console.WriteLine("Lowest number is:");
//            //Console.WriteLine(result);




//            //var result = numbers.Sum();

//            //Console.WriteLine("Sum of numbers:");
//            //Console.WriteLine(result);




//            //var result = words.ElementAt(1);

//            //Console.WriteLine("Element at index 1 in the array is:");
//            //Console.WriteLine(result);





//            //var resultIndex2 = words.ElementAtOrDefault(2);

//            //var resultIndex20 = words.ElementAtOrDefault(20);

//            //Console.WriteLine("Element at index 1 in the array contains:");
//            //Console.WriteLine(resultIndex2);

//            //Console.WriteLine("Element at index 20 in the array does not exist:");
//            //Console.WriteLine(resultIndex20 == null);






//            //var result = words.First();

//            //Console.WriteLine("First element in the array is:");
//            //Console.WriteLine(result);




//            //var result = words.First(c => c.Length == 4);

//            //Console.WriteLine("First element with a length of 5 characters:");
//            //Console.WriteLine(result);





//            //var result = words.FirstOrDefault();

//            //var resultEmpty = empty.FirstOrDefault();

//            //Console.WriteLine("First element in the countries array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("First element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);




//            //var result = numbers.Last();

//            //Console.WriteLine("Last number in array is:");
//            //Console.WriteLine(result);




//            //var result = words.LastOrDefault();

//            //var resultEmpty = empty.LastOrDefault();

//            //Console.WriteLine("Last element in the words array contains:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array does not exist:");
//            //Console.WriteLine(resultEmpty == null);





//            //var result = words.LastOrDefault(w => w.Length > 4);

//            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

//            //Console.WriteLine("Last element in the words array having a length of 3:");
//            //Console.WriteLine(result);

//            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
//            //Console.WriteLine(resultNoMatch == null);







//            //var result1 = word1.Single();

//            //Console.WriteLine("The only name in the array is:");
//            //Console.WriteLine(result1);

//            //try
//            //{
//            //    // This will throw an exception because array contains no elements
//            //    var resultEmpty = empty.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}

//            //try
//            //{
//            //    // This will throw an exception as well because array contains more than one element
//            //    var result3 = words.Single();
//            //}
//            //catch (Exception e)
//            //{
//            //    Console.WriteLine(e.Message);
//            //}








//            //    var result1 = word1.SingleOrDefault();

//            //    var resultEmpty = empty.SingleOrDefault();

//            //    Console.WriteLine("The only name in the array is:");
//            //    Console.WriteLine(result1);

//            //    Console.WriteLine("As array is empty, SingleOrDefault yields null:");
//            //    Console.WriteLine(resultEmpty == null);

//            //    try
//            //    {
//            //        // This will throw an exception as well because array contains more than one element
//            //        var result3 = words.SingleOrDefault();
//            //    }
//            //    catch (Exception e)
//            //    {
//            //        Console.WriteLine(e.Message);
//            //    }










//            //var result = words.All(n => n.StartsWith("B"));

//            //Console.WriteLine("Does all of the names start with the letter 'B':");
//            //Console.WriteLine(result);





//            //var result = words.Any(n => n.StartsWith("c"));

//            //Console.WriteLine("Does any of the names start with the letter 'c':");
//            //Console.WriteLine(result);





//            //var result = numbers.Contains(9);

//            //Console.WriteLine("sequence contains the value 9:");
//            //Console.WriteLine(result);




//            //var result = numbers.Distinct();

//            //Console.WriteLine("Distinct removes duplicate elements:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);





//            //var result = numbers.Except(numbers1);

//            //Console.WriteLine("Except creates a single sequence from numbers and removes the duplicates found in numbers1:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);





//            //var result = numbers.Intersect(numbers1);

//            //Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);




//            //var result = numbers.Union(numbers1);

//            //Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
//            //foreach (int number in result)
//            //    Console.WriteLine(number);


//            //string[] Names = { "John ", "Peter", "Jacob", "Harry", "Jackson" };
//            //var n = Names.ToList();
//            //n.ForEach(x => x.Contains("o")); Console.WriteLine(n);


//            //    var result = n.Contains("o");

//            //    Console.WriteLine("sequence contains the value o:");
//            //    Console.WriteLine(result);



//            //string[] words = { "believe", "relief", "receipt", "field" };
//            //var result = from word in words
//            //             select word;
//            //foreach (var word in result)
//            //    Console.WriteLine($"{word} --- {word.Length}");





//            public static void String_Groupby()
//            {
//                List<string> words = new List<string> { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

//                var wordGroups = words.GroupBy(x => x[0]).Select
//                    (y => new { FirstLetter = y.Key, Words = y });

//                foreach (var item in wordGroups)
//                {
//                    Console.WriteLine("words that start with the" + "letter '{0}':", item.FirstLetter);

//                    foreach (var w in item.Words)
//                    {
//                        Console.WriteLine(w);
//                    }
//                }
//            }



//                private static void String_GroupBy()
//                 {
//                    List<string> words = new List<string> { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

//                    var wordGroups = words.GroupBy(x => x.Length).Select
//                                            (y => new { FirstLetter = y.Key, Words = y });

//                    foreach (var item in wordGroups)
//                     {
//                         Console.WriteLine("words that start with the" + "letter '{0}':", item.FirstLetter);
//                     }
//                            foreach (var w in item.Words)
//                            {
//                                 Console.WriteLine(w);
//                            }
//                 }
//    }
//    //}


