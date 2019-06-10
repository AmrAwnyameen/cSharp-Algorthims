using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic result;

            // result = ComputeNumbers(x, y);
            //result = AbsoulteDiffrience();
            // result = RemoveChar();
            //result = ExchangeCharchters();
            //result = CreateNewString();
            //result = IndexOfString();
            //MaxtNumber();
            //result = FindAbsNumber();
            // FindLargeValue();
            //MakeFileName()
            //result = CheckCharApprenace();
            //result = countOfTwoSubstring();
            //CreateIndexString();
            //result = CheckModulo();
            //result = CheckWhether();
            //WriteFileName();
            //CheckRightmost();
            //ReverseArry();
            //result = ComputArryNums();
            //Console.WriteLine(string.Format("The Result  :  {0}", result));
            Console.ReadLine();


        }

        /// <summary>
        /// /Basics
        /// </summary>
        /// 
        // Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
        private static void CreateIndexString()
        {
            Console.WriteLine("Please Enter Your string");
            var word = Console.ReadLine();
            var positions = new List<int>() { 0, 1, 4, 5, 8, 9 };
            var result = new List<string>();
            var wordToCharArr = word.ToCharArray();
            for (int i = 0; i < word.Count(); i++)
            {
                if (positions.Contains(i))
                {
                    if (wordToCharArr[i] != null)
                    {
                        var subResult = word.Substring(i, 1);
                        result.Add(subResult);
                    }
                }
            }
            foreach (var charc in result)
            {
                Console.Write(charc);
            }
            Console.ReadLine();
        }

        //Write a C# Sharp program to check if the first appearance of "a" 
        // in a given string is immediately followed by another "a"
        private static bool CheckCharApprenace()
        {
            Console.WriteLine("Please Enter Your string");

            var word = Console.ReadLine();

            if (word.Contains("a"))
            {
                var positionOfChar = word.IndexOf('a');

                var result = word.Substring(positionOfChar + 1, 1);

                if (result.Equals("a"))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //Write a C# Sharp program to compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum//

        private static int ComputeNumbers()
        {
            Console.WriteLine("Please Enter Two Numbers");
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            return y == x ? (y + x) * 3 : y + x;
        }

        //   Write a C# Sharp program to get the absolute difference between n and 51.
        //If n is greater than 51 return triple the absolute difference

        private static int AbsoulteDiffrience()
        {
            const int constNumber = 51;
            Console.WriteLine("Please Enter n Number");
            var n = int.Parse(Console.ReadLine());
            return n > constNumber ? (n - 51) * 3 : constNumber - n;
        }

        //Write a C# Sharp program to remove the character in a given position of a given string.
        //The given position will be in the range 0.. string length -1 inclusive

        private static string RemoveChar()
        {
            Console.WriteLine("Please Enter Word");
            var word = Console.ReadLine();
            Console.WriteLine("Please Enter Poistion");
            var position = int.Parse(Console.ReadLine());
            if (position < word.Length)
            {
                var result = word.Remove(position, 1);
                //Return Result
                return result;
            }

            return "Please Enter Valid Position";
        }

        //Write a C# Sharp program to exchange the first and last characters 
        //in a given string and return the new string.
        private static string ExchangeCharchters()
        {
            Console.WriteLine("Please Enter Word");
            var word = Console.ReadLine();
            //get firstCahr
            var firstCahr = word.Substring(0, 1);
            //get lastCahr
            var lastCahr = word.Substring(word.Length - 1, 1);
            //word Between Chars and Subtract two positions -2
            var wordBetweenChars = word.Substring(1, word.Length - 2);
            //result
            return lastCahr + wordBetweenChars + firstCahr;

        }

        //Write a C# Sharp program to create a new string taking the first 3 characters 
        //of a given string and return the string with the 3 characters added at both the front and back.
        //If the given string length is less than 3, use whatever characters are there.

        private static string CreateNewString()
        {
            Console.WriteLine("Please Enter string");
            var word = Console.ReadLine();
            if (word.Length > 3)
            {
                var first3Characters = word.Substring(0, 3);
                var result = first3Characters + word + first3Characters;
                return result;
            }
            return "Please Enter Valid String";
        }

        //Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
        //   If it appears return a string without 'yt' otherwise return the original string

        private static string IndexOfString()
        {
            Console.WriteLine("Please Enter Your string");
            var word = Console.ReadLine();
            if (word.Length > 0 && word.Substring(1, 2).Equals("yt"))
            {
                var result = word.Remove(1, 2);
                return result;
            }
            return word;
        }

        //Write a C# Sharp program to check the largest number
        //among three given integers
        private static void MaxtNumber()
        {

            var numbers = new int[] { 13, 42, 3, 8, 2 };
            var maxNumber = numbers[0];
            var minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxNumber < numbers[i])
                {
                    maxNumber = numbers[i];
                }

                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }

            }
            Console.Write(string.Format("The Max  :  {0} , Min {1}", maxNumber, minNumber));
        }

        //Write a C# Sharp program to check which number nearest to the 
        //value [100] among two given integers. Return 0 if the two numbers are equal by using Max.Abs.
        private static int FindAbsNumber()
        {
            var nValue = 100;
            Console.WriteLine("Please Enter First Number");
            var fistrNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Seconde Number");
            var secondeNum = int.Parse(Console.ReadLine());
            return fistrNum == secondeNum ? 0 :
                (Math.Abs(nValue - fistrNum) < Math.Abs(nValue - secondeNum)
                ? fistrNum : secondeNum);
        }

        //Write a C# Sharp program to find the larger value from two positive integer values that
        //is in the range 20..30 inclusive, or return 0 if neither is in that range.

        private static void FindLargeValue()
        {
            Console.WriteLine("Please Enter First Number");
            var fistrNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Seconde Number");
            var secondeNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Third Number");
            var thirdNum = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            numbers.Add(fistrNum);
            numbers.Add(secondeNum);
            numbers.Add(thirdNum);
            foreach (var number in numbers)
            {
                if (number > 20 && number < 30)
                {
                    Console.WriteLine("Number" + number);
                }
            }

        }

        //Write a C# Sharp program to count a substring of length 2 appears 
        //in a given string and also as the last 2 characters of the string. Do not count the end substring

        private static int CountOfTwoSubstring()
        {
            Console.WriteLine("Please Enter Your First string");
            var word = Console.ReadLine();
            var firstTwoChars = word.Substring(0, 2);
            var lastTwoChars = word.Substring(word.Length - 2, 2);
            if (firstTwoChars.Equals(lastTwoChars))
            {
                return 1;
            }
            return 0;
        }

        //Write a C# Sharp program to test if a
        //given non-negative number is a multiple of 13 or it is one more than a multiple of 13 

        private static bool CheckModulo()
        {
            Console.WriteLine("Please Enter Your Number");

            var number = int.Parse(Console.ReadLine());
            return number % 13 == 0 ? true : false;
        }

        //Write a C# Sharp program to check whether
        //a given string starts with "F" or ends with "B". If the string starts with 
        //"F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with 
        //"F" and ends with "B" return "FizzBuzz". In other cases return the original string.

        private static string CheckWhether()
        {
            Console.WriteLine("Please Enter Your First string");
            var word = Console.ReadLine();
            var firstChar = word.Substring(0, 1);
            var lastChar = word.Substring(word.Length - 1, 1);
            return firstChar.Equals("F") && lastChar.Equals("B") ? "FizzBuzz" :
                firstChar.Equals("F") && !lastChar.Equals("B") ? "Fizz" :
                !firstChar.Equals("F") && lastChar.Equals("B") ? "Buzz" : word;

        }

        //Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.
        private static bool CheckRightmost()
        {
            Console.WriteLine("Please Enter Your Number");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Seconde Number");
            var secondeNumber = int.Parse(Console.ReadLine());
            var modulesOfNumber = firstNumber % 10;
            var modulesOfSecondeNumber = secondeNumber % 10;
            if (modulesOfNumber == modulesOfSecondeNumber) return true;
            return false;
        }
        //Write a C# Sharp program to compute the sum of the elements of an given array of integers. 

        private static int ComputArryNums()
        {
            int[] array = new int[] { 1, 2, 3, 4, 4 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //Write a C# Sharp program to reverse a given array of integers and length 5

        private static void ReverseArry()
        {
            int[] array = new int[] { 1, 2, 3, 4, 4, 8, 9, 8 };
            int[] arrayResult = new int[array.Length];
            int indexe = 0;
            for (int i = array.Length - 1; i < array.Length; i--)
            {
                if (indexe == array.Length)
                {
                    break;
                }
                arrayResult[indexe] = array[i];
                indexe++;
            }
            for (int i = 0; i < arrayResult.Length; i++)
            {
                Console.Write(arrayResult[i]);
            }
        }
        //Write a program in C# Sharp to read n number of 
        //values in an array and display it in reverse order. Go to the editor

        public static void ReverseArray()
        {
            int[] arr = new int[] { 2, 5, 7 };
            int[] arr2 = new int[arr.Length];
            int init = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr2[init] = arr[i];

                if (init <= arr.Length)
                {
                    init++;
                }
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }

        //Write a program in C# Sharp to sort elements of array in ascending order. Go to the editor
        //Test Data : 

        public static void SortArray()
        {
            int[] arr = new[] { 2, 7, 4, 5, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }



        public static void DateYear()
        {
            DateTime dec31 = new DateTime(2000, 12, 31);

            for (int ctr = 0; ctr <= 20; ctr++)
            {
                DateTime dateToDisplay = dec31.AddYears(ctr);
                Console.WriteLine("{0:d}: day {1} of {2} {3}", dateToDisplay,
                    dateToDisplay.DayOfYear,
                    dateToDisplay.Year,
                    DateTime.IsLeapYear(dateToDisplay.Year) ? "(Leap Year)" : "");
            }
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTimeOffset.Now);
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames =
            {
                "en-IE", "en-ZA", "fr-CA",
                "de-CH", "ro-RO"
            };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}", localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                    utcDate.ToString(culture), utcDate.Kind);
            }
        }

        //Write a program in C# Sharp to merge two arrays of same size sorted in ascending order. Go to the editor
        //    Test Data : 

        public static void MergTwoArray()
        {
            int[] firstArr = new int[7] { 1, 4, 5, 6, 9, 3, 2 };
            int[] twotArr = new int[7] { 18, 15, 17, 22, 18, 19, 33 };
            List<int> threeArr = new List<int>();

            for (int i = 0; i < firstArr.Length; i++)
            {
                threeArr.Add(firstArr[i]);
            }

            for (int i = 0; i < twotArr.Length; i++)
            {
                threeArr.Add(twotArr[i]);
            }

            threeArr.Sort();

            foreach (var item in threeArr)
            {
                Console.WriteLine(item);
            }

        }
        //Write a C# Sharp program to get a DateTime value that represents the current date and time 
        //on the local computer. 

        public static void GetDateTimes()
        {

            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames =
            {
                "en-JM", "en-NZ", "fr-BE",
                "de-CH", "nl-NL"
            };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("Local date and time: {0}, {1:G}", localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("UTC date and time: {0}, {1:G}\n",
                    utcDate.ToString(culture), utcDate.Kind);
            }
        }
        /// <summary>
        /// /Files -------------------------------------------------------------------------------------
        /// </summary>


        //Write a program in C# Sharp to create a blank file in the disk newly
        //

        public static void MakeFileName()
        {
            string fileName = @"E:\mytest3.txt";
            try
            {
                Console.Write("\n\n Create a file named mytest.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");
                // File.Create(fileName);
                File.WriteAllText(@"E:\mytest.txt7", "Root");

            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }

        }

        public static void WriteFileName()
        {
            string fileName = @"mytest2.txt";
            try
            {
                File.Create(fileName);
                var fs = new FileStream(@"C:\mytest2.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write("Hi.. This is the sample text file you have created using FileStream Class.");
                writer.Close();
                Console.Write("\n\n Create a file named mytest.txt in the disk :\n");
                Console.Write("------------------------------------------------\n");
                File.Create(fileName);
                File.Create(@"D\:mytest.txt");

            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }

        }
        /// <summary>
        /// //Recursion -------------------------------------------------------------------------------
        /// </summary>
        // Write a program in C# Sharp to print the first n natural number using recursion
        public static void NaturalNumbers(int init, int number)
        {
            if (init < number)
            {
                init++;
                Console.WriteLine(init);
                NaturalNumbers(init, number);
            }
            else
            {
                Console.WriteLine("Finish Natural Numbers");
            }
        }

        static void NaturalNumbersReverse(int number)
        {
            if (number != 0)
            {
                number--;
                Console.WriteLine(number);
                NaturalNumbersReverse(number);
            }
            else
            {
                Console.WriteLine("Finish Natural Numbers Reverse");
            }
        }

        public static int SumNumbersReverse(int number)
        {
            if (number == 0)
            {
                return number;
            }
            return number + SumNumbersReverse(number - 1);
        }
       // Write a program in C# Sharp to convert a decimal number to binary using recursion

        public static int GetDigits(int n1, int nodigits)
        {
            if (n1 == 0)
                return nodigits;

            nodigits++;
            return GetDigits(n1 / 10, nodigits);

        }
       // Write a program in C to print even or odd numbers in a given range using recursion

        public static int OddAndEven(int initValue, int number)
        {


            if (initValue == number)
            {
                Console.WriteLine("Finish");

                return 0;
            }
            initValue++;

            if (initValue % 2 == 0)
            {
                Console.Write("ODD" + initValue);
            }

            if (initValue % 2 != 0)
            {
                Console.Write("Even" + initValue);
            }

            return OddAndEven(initValue, number);

        }


    }
}

