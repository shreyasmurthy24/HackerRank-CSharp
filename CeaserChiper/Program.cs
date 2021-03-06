﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserChiper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11; /*Convert.ToInt32(Console.ReadLine());*/
            string s = "middle-Autz"; //Console.ReadLine();
            int k = 2; // Convert.ToInt32(Console.ReadLine());

            string res = ceaserChiper(s, k);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        private static string ceaserChiper(string s, int k)
        {
            //s = s.ToLower();
            char[] s1 = s.ToCharArray(); //s.Select(x => x.ToString()).ToArray();
            int len = s1.Length;
            char[] s2 = new char[len];

            string alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWZYZ";
            char[] arrAlpha = alpha.ToCharArray();  //alpha.Select(y => y.ToString()).ToArray();

            string specialChars = "!@#$%^&*()-=";
            char[] spChars = specialChars.ToCharArray();
            int rot_index = k; int i = 0;

            for (int j = 0; j < s1.Length; j++)
            {
                for (int l = 0; l < arrAlpha.Length; l++)
                {
                    if (s1[j] == arrAlpha[l])
                    {
                        if (!char.IsLetterOrDigit(s1[j]))
                        {
                            break;
                        }
                        rot_index = Array.IndexOf(arrAlpha, arrAlpha[l]) + rot_index;
                        if (rot_index > 26)
                        {
                            rot_index = rot_index - 26;
                        }
                        s2[i] = arrAlpha[rot_index];
                        i++; rot_index = k;
                    }
                }
            }
                
            string s3 = new string(s2);

            return s3;
        }
    }
}
