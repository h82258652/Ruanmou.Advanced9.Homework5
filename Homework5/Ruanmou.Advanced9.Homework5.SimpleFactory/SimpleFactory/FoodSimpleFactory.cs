using System;
using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.SimpleFactory
{
    public class FoodSimpleFactory
    {
        public AbstractFood Cook(string foodName)
        {
            switch (foodName)
            {
                case "菠萝油":
                    return new 菠萝油();

                case "干炒牛河":
                    return new 干炒牛河();

                case "罗宋汤":
                    return new 罗宋汤();

                case "丝袜奶茶":
                    return new 丝袜奶茶();

                case "猪扒包":
                    return new 猪扒包();

                default:
                    throw new ArgumentOutOfRangeException(nameof(foodName), "这个菜馆根本就没这个菜");
            }
        }
    }
}