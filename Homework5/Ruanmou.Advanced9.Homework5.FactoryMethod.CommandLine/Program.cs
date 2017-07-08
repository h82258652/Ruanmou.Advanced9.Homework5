using System;

namespace Ruanmou.Advanced9.Homework5.FactoryMethod.CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("这里是工厂方法");

            new 菠萝油Factory().Cook().Show();
            new 干炒牛河Factory().Cook().Show();
            new 罗宋汤Factory().Cook().Show();
            new 丝袜奶茶Factory().Cook().Show();
            new 猪扒包Factory().Cook().Show();

            Console.ReadKey();
        }
    }
}