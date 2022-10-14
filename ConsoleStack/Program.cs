using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Stack<int> stackInt = new Stack<int>();
            Queue<int> queueInt = new Queue<int>();

            // Thêm phần tử vào Stack và Queue
            for (int i = 1; i <= 10; i++)
            {
                stackInt.Push(i);
                queueInt.Enqueue(i);
            }

            Console.WriteLine($"Tổng số phần tử Stack : {stackInt.Count}");
            Console.WriteLine($"Tổng số phần tử Queue : {queueInt.Count}");

            string stackElements = "";
            string queueElements = "";

            for (int i = 0; i < 10; i++)
            {
                stackElements += $" {stackInt.Pop()} ";
                queueElements += $" {queueInt.Dequeue()} ";
            }

            Console.WriteLine($"Phần tử Stack : {stackElements}");
            Console.WriteLine($"Phần tử Queue : {queueElements}");
            Console.WriteLine($"Tổng số phần tử Stack : {stackInt.Count}");
            Console.WriteLine($"Tổng số phần tử Queue : {queueInt.Count}");

            Console.ReadLine();
        }
    }
}
