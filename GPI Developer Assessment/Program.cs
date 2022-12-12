using System;
using System.IO;

namespace GPI_Developer_Assessment
{
    public class Program
    {
        public static int equilibrium(int[] arr)
        {
            int i, j;
            int leftsum, rightsum;

            for (i = 0; i < arr.Length; ++i)
            {

                leftsum = 0;
                rightsum = 0;
                /* get left sum */
                for (j = 0; j < i; j++)
                    leftsum += arr[j];

                /* get right sum */
                for (j = i + 1; j < arr.Length; j++)
                    rightsum += arr[j];

                /* if leftsum and rightsum are
                 same, then we are done */
                if (leftsum == rightsum)
                    return i;
            }

            /* return -1 if no equilibrium
             index is found */
            return -1;
        }
        public static int findMyArray(int[] one, int[] two)
        {
            for (var i = one.Length - 1; i >= two.Length - 1; i--)
            {
                var found = true;
                for (var j = two.Length - 1; j >= 0 && found; j--)
                {
                    found = one[i - (two.Length - 1 - j)] == two[j];
                }
                if (found)
                    return i - (two.Length - 1);
            }
            // not found, return -1
            return -1;
        }

        //for your file
        static int triangle(string path)
        {
            int sum = 0;
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var numbers = line.Split(" ");
                if ((numbers.Length - 1) % 2 == 0)
                {
                    sum += int.Parse(numbers[(numbers.Length - 1) / 2 - 1]);
                }
                else
                {
                    sum += int.Parse(numbers[(numbers.Length - 1) / 2]);
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region for example in word file in triangle

            // for example in word file
            //int i, j, k, l, n;
            //n = 100;
            //var rand = new Random();
            //string text = "";
            //for (i = 1; i <= n; i++)
            //{
            //    for (j = 1; j <= n - i; j++)
            //    {
            //        text += " ";
            //    }
            //    for (k = 1; k <= i; k++)
            //    {
            //        text += rand.Next(10);
            //    }
            //    for (l = i - 1; l >= 1; l--)
            //    {
            //        text += rand.Next(10);
            //    }
            //    text += ("\n");
            //}
            //Console.WriteLine(text);
            //string path = "E:file2.txt";
            //File.WriteAllText(path, text, Encoding.UTF8);
            //var lines = File.ReadAllLines(path);
            //int sum = 0;
            //int c = 0;
            //foreach (var line in lines)
            //{
            //    sum += (int)line[line.Length - c - 1] - 48;
            //    c++;
            //}
            //Console.WriteLine(sum);
            #endregion

            Console.WriteLine("Press 1.Triangle Assessment 2.Find an Array 3. Equilibrium");
            int ans = int.Parse(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    // don't forget to change the path
                    string path = "C:\\Users\\all\\Downloads\\Compressed\\New folder (2)\\Triangle Problem\\triangle.txt";
                    Console.WriteLine(triangle(path));
                    break;
                case 2:
                    int[] arr1 = { 4, 9, 3, 7, 8 };
                    int[] arr2 = { 3, 7 };
                    Console.WriteLine(findMyArray(arr1, arr2));
                    break;
                case 3:
                    //A[0] = -1 A[1] = 3 A[2] = -4 A[3] = 5 A[4] = 1 A[5] = -6 A[6] = 2 A[7] = 1
                    int[] arr3 = { -1, 3, -4, 5, 1, -6, 2, 1 };
                    Console.WriteLine(equilibrium(arr3));
                    break;
            }

        }
    }
}
