using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Login(string username, bool ismale)
        {
            Console.Write("\n {0}", username);
            if (ismale)
            {
                Console.WriteLine("先生，歡迎光臨!");
            }
            else
            {
                Console.WriteLine("小姐，歡迎光臨!");
            }
        }

        static void Main(string[] args)
        {
            string name = "Jack Wu";
            // 呼叫Login 方法
            // 傳入的第一個參數name變數，第二個參數為true
            Login(name, true);
            Console.WriteLine();
            //呼叫Login方法，傳入第一個參數是字串資料，第二個參數為false
            Login("Mary Lin", false);
            Console.Read();
        }
    }
}
