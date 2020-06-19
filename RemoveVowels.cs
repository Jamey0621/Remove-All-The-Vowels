using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var str="This website is for losers LOL!";
            // lets figure out how to remove all the vowels
            // a,e,i,o,u
            var RemoveVowels = new string[] { "a", "e", "i", "o", "u" };
            foreach (var c in RemoveVowels)
            {
                str = str.Replace(c, string.Empty);
            }

            Console.WriteLine(str);
        }
    }
}
