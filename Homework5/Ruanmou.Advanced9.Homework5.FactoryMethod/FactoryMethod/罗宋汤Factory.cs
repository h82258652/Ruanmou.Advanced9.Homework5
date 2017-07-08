using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.FactoryMethod
{
    public class 罗宋汤Factory : FoodFactoryCreator
    {
        public override AbstractFood Cook()
        {
            return new 罗宋汤();
        }
    }
}