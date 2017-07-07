using System;

namespace Ruanmou.Advanced9.Homework5.AbstractFactory.CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("这里是抽象工厂");

            FoodFactoryBase foodFactory = new 银龙茶餐厅();

            Console.ReadKey();
        }
    }
}