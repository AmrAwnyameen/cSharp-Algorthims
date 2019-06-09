using System;
using System.Collections.Generic;
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
            //result = CheckCharApprenace();
            //result = countOfTwoSubstring();
            //CreateIndexString();
            //result = CheckModulo();
            //result = CheckWhether();
            //CheckRightmost();
            //ReverseArry();
            //result = ComputArryNums();
            //Console.WriteLine(string.Format("The Result  :  {0}", result));
            Console.ReadLine();


        }
        //--------------------------------------------- Algorithms-----------------------------------

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

    }
}

