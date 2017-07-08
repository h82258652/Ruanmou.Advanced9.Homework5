using System;
using System.Windows.Forms;

namespace Ruanmou.Advanced9.Homework5.OrderSystem.Winform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int? Id
        {
            get;
            private set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                Id = id;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("请输入正确的 Id 值");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}