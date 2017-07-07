using System;
using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.NormalImplement.CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("这里是普通实现，下面将展示几个菜好不好吃");

            new 菠萝油().Show();
            new 干炒牛河().Show();
            new 罗宋汤().Show();
            new 丝袜奶茶().Show();
            new 猪扒包().Show();

            Console.ReadKey();
        }
    }
}