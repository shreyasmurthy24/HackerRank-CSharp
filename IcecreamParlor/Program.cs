using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcecreamParlor
{
    class Program
    {
        /// <summary>
        /// Sunny and Johnny like to pool their money and go to the ice cream parlor. Johnny never buys the same flavor that Sunny does. 
        /// The only other rule they have is that they spend all of their money.
        ///Given a list of prices for the flavors of ice cream, select the two that will cost all of the money they have.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine()); //Number of visits to Icream Parlor
            for (int i = 0; i < t; i++)
            {
                var m = Convert.ToInt32(Console.ReadLine()); //Total money pooled
                //int n = Convert.ToInt32(Console.ReadLine()); //No. of icecream flavors
                var arr_temp = Console.ReadLine().Split(' ');
                var arr = Array.ConvertAll(arr_temp, int.Parse);
                //for (int j = 0; j < n; j++)
                //{
                //    arr[j] = Convert.ToInt32(Console.ReadLine());
                //}

                int[] result = icecreamparlor(arr, m);

                for (int k = 0; k < result.Length; k++)
                {
                    Console.Write(k + " ");
                }
            }
        }

        private static int[] icecreamparlor(int[] arr, int m)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>();
            var boughtIcreamIndexes = new int[2];

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] < m)
                {
                    var otherPrice = m - arr[i];
                    if (lookup.ContainsKey(otherPrice))
                    {
                        //Solution
                        var indexOfIcecream = lookup[otherPrice];
                        if (indexOfIcecream < i)
                        {
                            boughtIcreamIndexes[0] = indexOfIcecream + 1;
                            boughtIcreamIndexes[1] = i + 1;
                        }
                        else
                        {
                            boughtIcreamIndexes[0] = i + 1;
                            boughtIcreamIndexes[1] = indexOfIcecream + 1;
                        }
                        break;
                    }
                    else
                    {
                        if (!lookup.ContainsKey(arr[i]))
                        {
                            lookup.Add(arr[i], i);
                        }
                    }
                }
            }
            return boughtIcreamIndexes;
        }
    }
}
