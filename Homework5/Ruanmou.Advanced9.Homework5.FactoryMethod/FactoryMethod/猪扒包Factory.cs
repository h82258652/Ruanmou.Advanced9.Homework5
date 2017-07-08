using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.FactoryMethod
{
    public class 猪扒包Factory : FoodFactoryCreator
    {
        public override AbstractFood Cook()
        {
            return new 猪扒包();
        }
    }
}