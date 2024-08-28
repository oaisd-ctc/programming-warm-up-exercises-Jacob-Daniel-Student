using System;
using System.Runtime.InteropServices;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] ints = {4, 3, 16, 17, 829};
            Console.WriteLine(Add(1, 17));
            Console.WriteLine(IsEven(15));
            Console.WriteLine(IsEven(14));
            Console.WriteLine(MaxOfThree(4, 5, 6));
            Console.WriteLine(StringLength("123456789"));
            Console.WriteLine(StartsHello("Hello World"));
            Console.WriteLine(StartsHello("Hell No World"));
            Console.WriteLine(ReverseString("daeR naC I"));
            Console.WriteLine(Factorial(10));
            System.Console.WriteLine(IsPrime(16));
            System.Console.WriteLine(IsPrime(5));
            System.Console.WriteLine(Fibonacci(10));
            System.Console.WriteLine(LargestInArray(ints));
            System.Console.WriteLine(IsPalindrome("Door"));
            System.Console.WriteLine(IsPalindrome("Noon"));
            Console.WriteLine(ArraySum(ints));
            Console.WriteLine(CharCount("aaad", 'a'));
            Console.WriteLine(ConcatenateStrings("booh", "yah"));
            Console.WriteLine(SwapEnds("asdf"));
            */
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            int total = a + b;
            return total;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            int d = Math.Max(a, b);
            int max = Math.Max(d, c);
            return max;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            int length = s.Length;
            return length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            if(s.StartsWith("Hello"))
            {
                return true;
            }
            return false;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            int fact = 1;
            if (n == 0) return 1;
            for(int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            if(number % number == 0)
            {
                return true;
            }
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        { 
            // TODO: Calculate the nth Fibonacci number.
        if (n <= 1) 
        {
            return n;
        }
        else 
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // TODO: Find the largest number in the array.
                if(numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            // TODO: Determine if the string is a palindrome.
            char[] some = s.ToCharArray();
            Array.Reverse(some);
            string newStr = new string(some);
            if(newStr.ToLower() == s.ToLower())
            {
                return true;
            }
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // TODO: Calculate the sum of the array's elements.
            for(int i = 0; i <= numbers.Length - 1; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            foreach(char letter in s)
            {
                if(letter == c)
                {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            string newString = str1 + " " + str2;
            return newString;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.
            char[] chars = s.ToArray();
            chars[0] = lastChar;
            chars[s.Length - 1] = firstChar;
            return new string(chars);
        }
    }
}
