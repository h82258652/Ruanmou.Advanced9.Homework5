using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Ruanmou.Advanced9.Homework5.Foods;

namespace Ruanmou.Advanced9.Homework5.OrderSystem.Winform
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private readonly Random _rand = new Random();

        private bool[] _isDone;

        private readonly object _forLock = new object();

        private AbstractFood[] _maxScoreFoods;

        private int[] _maxScores;

        private void DoFinalOutput()
        {
            lock (_isDone)
            {
                if (_isDone.All(temp => temp))
                {
                    // 所有都完成

                    AbstractFood maxScoreFood = null;
                    int maxScore = -1;

                    for (int i = 0; i < _maxScores.Length; i++)
                    {
                        var score = _maxScores[i];
                        if (score > maxScore)
                        {
                            maxScore = score;
                            maxScoreFood = _maxScoreFoods[i];
                        }
                    }

                    Console.WriteLine();

                    var foregroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("最高分的菜是：" + maxScoreFood.GetType().Name + "，" + maxScore);
                    Console.ForegroundColor = foregroundColor;

                    button1.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            // 还是先清理一下输出好了
            Console.Clear();

            // 初始化数组
            var customers = new[]
            {
                "甲","乙","丙"
            };
            _isDone = new bool[customers.Length];
            _maxScoreFoods = new AbstractFood[customers.Length];
            _maxScores = new int[customers.Length];
            for (int i = 0; i < _maxScores.Length; i++)
            {
                _maxScores[i] = -1;
            }

            var menu = OrderSystem.Menu.Instance;
            var menuItems = menu.Items;

            var foodFactory = new FoodFactory();

            for (int i = 0; i < customers.Length; i++)
            {
                var index = i;
                var name = customers[index];
                var thread = new Thread(() =>
                {
                    // 点 5 个菜
                    for (int j = 0; j < 5; j++)
                    {
                        var id = _rand.Next(menuItems.Length);
                        var menuItem = menuItems[id];

                        var food = foodFactory.CreateById(menuItem.Id);
                        lock (_forLock)
                        {
                            Console.Write(name + "吃了" + menuItem.Name + " ");
                            food.Show();
                            var foodScore = food.Score();

                            if (foodScore > _maxScores[index])
                            {
                                _maxScores[index] = foodScore;
                                _maxScoreFoods[index] = food;
                            }

                            Console.WriteLine("评分是：" + foodScore);
                        }

                        // 吃完这个菜等个 500 ~ 3000 毫秒休息下吧。
                        Thread.Sleep(_rand.Next(500, 3001));
                    }
                    _isDone[index] = true;

                    lock (_forLock)
                    {
                        var foregroundColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(name + "吃完了");
                        Console.Write("，最高分是：");
                        Console.Write(_maxScores[index] + "，" + _maxScoreFoods[index].GetType().Name);
                        Console.WriteLine();
                        Console.ForegroundColor = foregroundColor;
                    }

                    DoFinalOutput();
                })
                {
                    IsBackground = true
                };
                thread.Start();
            }
        }
    }
}