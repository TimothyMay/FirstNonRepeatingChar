using System;
using System.Linq;

namespace FirstNonRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");

            var s = Console.ReadLine();
            Console.WriteLine(FirstNonRepeatingLetter(s));
            Console.ReadLine();
        }

        public static string FirstNonRepeatingLetter(string s)
        {
            var letters = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (letters.Where(x => char.ToUpper(x) == char.ToUpper(letters[i])).ToList().Count == 1)
                {
                    return letters[i].ToString();
                }
            }
            return "";
        }
    }
}
