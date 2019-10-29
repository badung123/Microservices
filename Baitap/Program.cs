using Baitap.Entities;
using Baitap.Homework;
using System;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            LoaiBaitap bt = new LoaiBaitap();
            var type = bt.GetEntityBasedOnType(BaitapEnum.Baitap1);
            Console.WriteLine("type: " + type);
        }
    }
}
