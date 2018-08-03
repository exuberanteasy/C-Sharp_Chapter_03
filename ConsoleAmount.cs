// 3-17

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
            double[][] amt = new double[3][];

            amt[0] = new double[] { 1100, 2200, 3300 };
            amt[1] = new double[] { 1500, 2500 };
            amt[2] = new double[] { 1000, 2000, 3000, 4000 };

            string[] company = new string[] { "台北", "台中", "高雄" };
            double[] sum = new double[] { 0.0, 0.0, 0.0};
            double total = 0;
            Console.WriteLine("\n\t第一處\t第二處\t第三處\t第四處 (單位:千元)");
            for(int i = 0; i<amt.Length; i++)
            {
                for(int k =0; k< amt[i].Length; k++)
                {
                    Console.Write("\t{0}", amt[i][k]); // 顯示各處的金處
                    sum[i] += amt[i][k]; // 計算各公司的營業額
                }
                total += sum[i] * 1000;
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for(int n = 0; n<3; n++)
            {
                sum[n] *= 1000;
                Console.WriteLine("{0} 分公司營業額:{1}元\t 營業率:{2:p}",
                    company[n], sum[n].ToString("c"), sum[n] / total);
            }
            Console.WriteLine("\n總營業額: {0}元", total.ToString("c"));
            Console.Read();
        }
    }
}
