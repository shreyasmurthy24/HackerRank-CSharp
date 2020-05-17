using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "abcd", "dcba", "efgh", "fgh", "ghfe", "bcda", "qwer", "rewq" };
            List<string> result = new List<string>();
            bool match = false;

            //Trim
            for (int i = 0; i < words.Count(); i++)
            {
                words[i] = words[i].Trim();
            }

            for (int i = 0; i < words.Count() - 1; i++)
            {
                result.Add(words[i]);
                for (int c = i + 1; c < words.Count(); c++)
                {
                    //Length check
                    if (words[i].Length == words[c].Length && words[i] != "")
                    {
                        char[] a = words[i].ToLower().ToCharArray();
                        char[] b = words[c].ToLower().ToCharArray();
                        int counter = 0;
                        match = false;
                        Array.Sort(a); Array.Sort(b);
                        foreach (char x in a)
                        {
                            if (x == b[counter])
                            {
                                match = true;
                            }
                            else
                            {
                                match = false;
                                break;
                            }
                            counter++;
                        }
                        if (match)
                        {
                            result.Add(words[c]);
                            words[c] = "";
                        }
                    }
                }

                if (result.Count > 1 && result[0] != "")
                {
                    Console.Write("Anagrams - ");
                    foreach (string item in result)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                result.Clear();
            }
            Console.ReadKey();
        }
    }
}
