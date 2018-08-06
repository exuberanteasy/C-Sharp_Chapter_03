/*  3-34
    引述的傳遞方式
    傳值呼叫

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        private static void CallValue(int x, int y)
        {
            int z;
            x = 33;
            y = 66;
            Console.WriteLine("\n 2.方法內 交換前\t\t:x={0} y={1} ", x, y);
            z = x;
            x = y;
            y = z;
            Console.WriteLine("\n3. 方法內 交換後\t\t:x={0} y={1}", x, y);
        }

        static void Main(string[] args)
        {
            int a = 50;
            int b = 80;
            Console.WriteLine("\n1. 呼叫敘述 未進入方法前\t:a={0} b={1}", a, b);
            CallValue(a, b);
            Console.WriteLine("\n1. 呼叫敘述 離開方法回原處時\t:a={0} b={1}", a, b);
            Console.Read();
        }
    }
}
