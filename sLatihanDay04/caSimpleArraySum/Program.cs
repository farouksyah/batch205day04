using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSimpleArraySum
{
    class Program
    {
        //static int simpleArraySum(int[] ar)
        //{
        //    /*
        //     * Write your code here.
        //     */

        //}

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int a = 0;
            string angka = Console.ReadLine();
            string[] angka2 = new string[n];
            angka2 = angka.Split(null);
            foreach (var item in angka2)
            {
                array[a] = Convert.ToInt32(item);
                Console.WriteLine(item);
                
                Console.WriteLine(array[a]);
                a++;
            }
            //int summ = Math.Max(array);
            Console.ReadLine();
        }
    }
}
