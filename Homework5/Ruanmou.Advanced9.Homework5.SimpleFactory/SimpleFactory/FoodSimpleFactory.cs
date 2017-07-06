using Ruanmou.Advanced9.Homework5.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ruanmou.Advanced9.Homework5.SimpleFactory
{
    public class FoodSimpleFactory
    {
        public AbstractFood CreateFood(string foodName)
        {
            switch (foodName)
            {
                case "菠萝油":
                    return new 菠萝油();

                case "干炒牛河":
                    return new 干炒牛河();

                default:
                    throw new ArgumentOutOfRangeException(nameof(foodName), "这个菜馆根本就没这个菜");
            }
        }
    }
}