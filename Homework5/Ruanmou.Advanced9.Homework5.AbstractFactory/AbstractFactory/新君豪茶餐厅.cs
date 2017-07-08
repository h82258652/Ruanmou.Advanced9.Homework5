using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.AbstractFactory
{
    public class 新君豪茶餐厅 : FoodFactoryBase
    {
        public override 菠萝油 Cook菠萝油()
        {
            return new 菠萝油();
        }

        public override 干炒牛河 Cook干炒牛河()
        {
            return new 加蛋干炒牛河();
        }

        public override 罗宋汤 Cook罗宋汤()
        {
            return new 罗宋汤();
        }

        public override 丝袜奶茶 Cook丝袜奶茶()
        {
            return new 热奶茶();
        }

        public override 猪扒包 Cook猪扒包()
        {
            return new 猪扒包();
        }
    }
}