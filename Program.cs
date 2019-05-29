using System;
using System.Linq;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that to remove the nth index character from a nonempty string
            string name = "Smaranda";
            string name2 = name.Remove(2, 3);
            Console.WriteLine(name2);
            // Write a method that to remove the characters which have odd index values of a given string
            string text = "Ana are mere";
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i <= text.Length; i++)
            {
                if (GetOdd(i))
                {
                    Console.WriteLine(i);
                }
                
            }

            //Write a method that takes input from the user and displays that input back in upper and lower cases
            string user;
            Console.WriteLine("write something...");
            user = Console.ReadLine();
            Console.WriteLine(user.ToUpper());
            Console.WriteLine(user.ToLower());

            //Write a method that reverses a string if it's length is a multiple of 4
            string s = "Smaranda";
            Console.WriteLine(ReverseString(s));

            //Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
            //Write a method that to remove a newline
            string removeLine = "Irish culture has had a significant influence\n on other cultures, especially in the field of literature.";
            string concat = "Irish culture has had a significant influence" + " " + "on other cultures, especially in the field of literature.";
            Console.WriteLine(concat);

            //Write a method to display formatted text (width=50) as output.

            //Write a method that formats a number with a percentage
            int number = 42;
            string str = number.ToString("P");
            Console.WriteLine(str);

            //Write a method that reverses a string.

            string rev = "Game of Thrones";
            Console.WriteLine(ReverseStringRe(rev));

            //Write a method that transforms to lowercase first n characters in a string
            string txt = "Smaranda";
            string replaced = txt.Replace("S", "s");
            Console.WriteLine(replaced);

            //Write a method to compute sum of digits of a given string(if any).
            int num = 1034;
            Console.WriteLine(SumOfDigits(num));

            //Clean the text

            string someText = "Hi>there<<I’m telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            string clean = someText.Replace(">", " ").Replace("<", " ").Replace("%", " ").Replace("&", " ").Replace("$", " ").Replace("@", " ").Replace("^", "");
            Console.WriteLine(clean);

            //obfucate email
            string email = "awesome@dotnet.com";
            string correctString = email.Replace("awesome", "*******");
            Console.WriteLine(correctString);

            //Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
            Console.WriteLine("Enter something: ");
            string myString = Console.ReadLine();
            for (int i = 1; i < myString.Length; i++)
                if (myString[i] == myString[0])
                {
                    myString = myString.Insert(i, "$");
                    myString = myString.Remove(i + 1, 1);
                }
            Console.WriteLine(myString);

            //Write a method to swap comma and dot in a string.
            string value1 = "32.054,23";
            string swap1 = SwapCharacters(value1, 2, 6);
            Console.WriteLine(swap1);


        }
        //Write a method that reverses a string if it's length is a multiple of 4
        private static string ReverseString(string s)
        {
            char[] sToChar = s.ToCharArray();
            string result = string.Empty;
            int length = sToChar.Length;
            for (int i = length; i > 0; i--)
                if (s.Length % 4 == 0)
                {
                    result += sToChar[i - 1];
                }
           
            return result;
        }

        // Write a method that to remove the characters which have odd index values of a given string

        public static bool GetOdd(int value)
        {
            return value % 2 == 1;
        }

        //Write a method that reverses a string.
        public static string ReverseStringRe(string rev)
        {
            StringBuilder rs = new StringBuilder();
            for (int i = rev.Length - 1; i >= 0; i--)
                rs.Append(rev[i]);
            return rs.ToString();
        }
        //Write a method to compute sum of digits of a given string(if any).
        public static int SumOfDigits(int num)
        {
            string stringNum = num.ToString();
            int sum = 0;
            for (int i = 0; i < stringNum.Length; i++)
            {
                sum += int.Parse(Convert.ToString(stringNum[i]));

            }
            return sum;
        }
        //Write a method to swap comma and dot in a string.
        public static string SwapCharacters(string value, int position1, int position2)
        {
   
            char[] array = value.ToCharArray();
            char temp = array[position1]; 
            array[position1] = array[position2];
            array[position2] = temp; 
            return new string(array); 
        }

    }
}
