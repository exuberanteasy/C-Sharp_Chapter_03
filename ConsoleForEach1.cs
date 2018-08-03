// 3-9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            double sum = 0;
            Console.Write("\n 請輸入總人數 : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double[] tall = new double[num];

            for (i = 0; i<=tall.GetUpperBound(0); i++)
            {
                Console.Write("\n 請輸入第 {0} 位身高(公分) : ", i + 1);
                tall[i] = double.Parse(Console.ReadLine());
            }

            foreach (double height in tall)
                sum += height;

            Console.WriteLine("\n === " + i.ToString("#") + "位平均身高:" + (sum / num).ToString("00.00"));
            Console.Read();
        }
    }
}
