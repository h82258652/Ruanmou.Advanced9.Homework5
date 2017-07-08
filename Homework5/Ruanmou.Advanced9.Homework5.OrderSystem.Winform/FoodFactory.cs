using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.OrderSystem.Winform
{
    public class FoodFactory
    {
        public AbstractFood CreateById(int id)
        {
            var menuItem = Menu.Instance.Items.FirstOrDefault(temp => temp.Id == id);
            if (menuItem == null)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "菜单里没这个菜");
            }

            Type foodType = null;

            // 在当前程序目录下的 dll 寻找符合名称的类。
            foreach (var dll in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll"))
            {
                try
                {
                    var assembly = Assembly.LoadFile(dll);
                    foodType = assembly.GetType(menuItem.FullTypeName, false);
                    if (foodType != null)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    // 有可能不是 .net 的 dll。
                }
            }

            if (foodType == null)
            {
                throw new InvalidOperationException("菜单的 FullTypeName 配置错误，找不到这个类");
            }

            var food = Activator.CreateInstance(foodType) as AbstractFood;
            if (food == null)
            {
                throw new InvalidOperationException($"配置的类不是继承自 {nameof(AbstractFood)}");
            }

            return food;
        }
    }
}