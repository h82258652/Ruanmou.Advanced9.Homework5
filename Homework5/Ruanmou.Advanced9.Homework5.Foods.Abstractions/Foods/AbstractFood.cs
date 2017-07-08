using System;

namespace Ruanmou.Advanced9.Homework5.Foods
{
    public abstract class AbstractFood
    {
        public abstract void Show();

        private static readonly Random Rand = new Random();

        /// <summary>
        /// 评分
        /// </summary>
        /// <returns></returns>
        public virtual int Score()
        {
            return Rand.Next(0, 101);
        }
    }
}