using System;
using System.Linq;

namespace StrongPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string password = Console.ReadLine();
            int answer = strongPass(n, password);
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        private static int strongPass(int n, string password)
        {
            string special_characters = "!@#$%^&*()-+";
            int count = 0;
            bool lower = false, upper = false, num = false, special = false;
            
            for (int i = 0; i < n; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                {
                    lower = true;
                }

                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    upper = true;
                }

                if (password.Any(d => char.IsDigit(d)))
                {
                    num = true;
                }                

                if (special_characters.Contains(password[i]))
                {
                    special = true;
                }
            }

            if (!lower) count++;
            if (!upper) count++;
            if (!special) count++;
            if (!num) count++;
            if ((n + count) < 6)
            {
                count += 6 - (n + count);
            }
            return count;
            
        }
    }
}
