using System;

namespace Ruanmou.Advanced9.Homework5.AbstractFactory.CommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("这里是抽象工厂");

            Console.WriteLine();

            Console.WriteLine("银龙茶餐厅");
            FoodFactoryBase 银龙茶餐厅 = new 银龙茶餐厅();
            银龙茶餐厅.Cook菠萝油().Show();
            银龙茶餐厅.Cook干炒牛河().Show();
            银龙茶餐厅.Cook罗宋汤().Show();
            银龙茶餐厅.Cook丝袜奶茶().Show();
            银龙茶餐厅.Cook猪扒包().Show();
            Console.WriteLine();

            Console.WriteLine("合发茶餐厅");
            FoodFactoryBase 合发茶餐厅 = new 合发茶餐厅();
            合发茶餐厅.Cook菠萝油().Show();
            合发茶餐厅.Cook干炒牛河().Show();
            合发茶餐厅.Cook罗宋汤().Show();
            合发茶餐厅.Cook丝袜奶茶().Show();
            合发茶餐厅.Cook猪扒包().Show();
            Console.WriteLine();

            Console.WriteLine("新君豪茶餐厅");
            FoodFactoryBase 新君豪茶餐厅 = new 新君豪茶餐厅();
            新君豪茶餐厅.Cook菠萝油().Show();
            新君豪茶餐厅.Cook干炒牛河().Show();
            新君豪茶餐厅.Cook罗宋汤().Show();
            新君豪茶餐厅.Cook丝袜奶茶().Show();
            新君豪茶餐厅.Cook猪扒包().Show();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}