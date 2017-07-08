using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.FactoryMethod
{
    public class 菠萝油Factory : FoodFactoryCreator
    {
        public override AbstractFood Cook()
        {
            return new 菠萝油();
        }
    }
}