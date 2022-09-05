//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//        internal class RefTypPerson
//        {
//            String FirstName;
//            String LastName;
//            String Email;
//            DateTime DOB;
//            public RefTypPerson(string firstName, string lastName, string email, DateTime dOB)
//            {
//                FirstName = firstName;
//                LastName = lastName;
//                Email = email;
//                DOB = dOB;
//            }
//            RefTypPerson(string first, string last, string email)
//            {
//                FirstName = first;
//                LastName = last;
//                Email = email;


//            }
//            RefTypPerson(string first, string last, DateTime dob)
//            {
//                FirstName = first;
//                LastName = last;
//                DOB = dob;
//            }
//            public int GetAge()
//            {
//                return DateTime.Now.Year - DOB.Year;
//            }


//            public int BirthYear()
//            {
//                return DOB.Year;
//            }
//            public string GetInfo()
//            {
//                return $"{FirstName} {LastName}";
//            }

//            public string IsAdult()
//            {
//                int age = GetAge();
//                if (age > 18)
//                {
//                    return "Is Adult";
//                }
//                else
//                {
//                    return "Is not an Adult";
//                }
//            }
//            public string GetSunSign()
//            {
//                string str = string.Empty;
//                int month = DOB.Month;
//                int day = DOB.Day;
//                if (((month == 3) && (day >= 21 || day <= 31)) || ((month == 4) && (day >= 01 || day <= 20)))
//                {
//                    return "Libra";
//                }
//                if (((month == 4) && (day >= 21 || day <= 31)) || ((month == 5) && (day >= 01 || day <= 21)))
//                {
//                    return "Taurus";
//                }
//                if (((month == 5) && (day >= 21 || day <= 31)) || ((month == 6) && (day >= 01 || day <= 21)))
//                {
//                    return "Gemini";
//                }
//                if (((month == 6) && (day >= 22 || day <= 31)) || ((month == 7) && (day >= 01 || day <= 22)))
//                {
//                    return "Cancer";
//                }
//                if (((month == 7) && (day >= 23 || day <= 31)) || ((month == 8) && (day >= 01 || day <= 22)))
//                {
//                    return "leo";
//                }
//                if (((month == 8) && (day >= 23 || day <= 31)) || ((month == 9) && (day >= 01 || day <= 21)))
//                {
//                    return "Virgo";
//                }
//                else
//                {
//                    return "SUN SIGN UNKOWN";
//                }
//            }
//            public string BDayStatus()
//            {
//                var dateNow = DateTime.Now;
//                if (DOB == dateNow)
//                {
//                    return "IT IS THE PERSON'S BIRTHDAY";
//                }
//                else
//                {
//                    return "IT IS NOT THE PERSON'S BIRTHDAY";
//                }
//            }
//            public string DefaultUsername()
//            {
//                return $"{FirstName}{LastName}{DOB.Year}";
//            }
//            public string ChineseZodiac()
//            {
//                int year = DOB.Year;
//                if (year % 12 == 0) { return "Monkey"; }
//                else if (year % 12 == 1) { return "Rooster"; }
//                else if (year % 12 == 2) { return "Dog"; }
//                else if (year % 12 == 3) { return "Pig"; }
//                else if (year % 12 == 4) { return "Rat"; }
//                else if (year % 12 == 5) { return "Ox"; }
//                else if (year % 12 == 6) { return "Tiger"; }
//                else if (year % 12 == 7) { return "Rabbit"; }
//                else if (year % 12 == 8) { return "Dragon"; }
//                else if (year % 12 == 9) { return "Snake"; }
//                else if (year % 12 == 10) { return "Horse"; }
//                else { return "Sheep"; }
//            }
//        }
// }
