using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.AbstractFactory
{
    public abstract class FoodFactoryBase
    {
        public abstract 菠萝油 Cook菠萝油();

        public abstract 干炒牛河 Cook干炒牛河();

        public abstract 罗宋汤 Cook罗宋汤();

        public abstract 丝袜奶茶 Cook丝袜奶茶();

        public abstract 猪扒包 Cook猪扒包();
    }
}