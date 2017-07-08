using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.FactoryMethod
{
    public class 干炒牛河Factory : FoodFactoryCreator
    {
        public override AbstractFood Cook()
        {
            return new 干炒牛河();
        }
    }
}