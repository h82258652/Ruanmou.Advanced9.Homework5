using System;

namespace Ruanmou.Advanced9.Homework5.SimpleFactory.CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("这里是简单工厂");

            var foodSimpleFactory = new FoodSimpleFactory();
            foodSimpleFactory.Cook("菠萝油").Show();
            foodSimpleFactory.Cook("干炒牛河").Show();
            foodSimpleFactory.Cook("罗宋汤").Show();
            foodSimpleFactory.Cook("丝袜奶茶").Show();
            foodSimpleFactory.Cook("猪扒包").Show();

            Console.ReadKey();
        }
    }
}