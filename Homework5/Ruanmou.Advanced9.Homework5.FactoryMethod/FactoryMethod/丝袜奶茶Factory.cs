﻿using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.FactoryMethod
{
    public class 丝袜奶茶Factory : FoodFactoryCreator
    {
        public override AbstractFood Cook()
        {
            return new 丝袜奶茶();
        }
    }
}