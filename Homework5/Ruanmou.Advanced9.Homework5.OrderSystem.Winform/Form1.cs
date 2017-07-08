using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Ruanmou.Advanced9.Homework5.OrderSystem.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var instance = OrderSystem.Menu.Instance;
            var stringBuilder = new StringBuilder();
            foreach (var menuItem in instance.Items)
            {
                stringBuilder.AppendLine("菜号：" + menuItem.Id);
                stringBuilder.AppendLine("菜名：" + menuItem.Name);
                stringBuilder.AppendLine("价格：" + menuItem.Price + "元");
                stringBuilder.AppendLine();
            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                var foodFactory = new FoodFactory();
                try
                {
                    Debug.Assert(form2.Id.HasValue);
                    var food = foodFactory.CreateById(form2.Id.Value);

                    food.Show();
                }
                catch (Exception ex) when (ex is ArgumentOutOfRangeException || ex is InvalidOperationException)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }
    }
}