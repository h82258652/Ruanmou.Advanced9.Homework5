namespace Ruanmou.Advanced9.Homework5.Foods
{
    public abstract class AbstractFood
    {
        /// <summary>
        /// 菜的名称
        /// </summary>
        public string Name
        {
            get;
            protected set;
        }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price
        {
            get;
            protected set;
        }
    }
}