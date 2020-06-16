using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit21 : Form
    {
        public Unit21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем тип по имени.
            Type t = Type.GetType("Z06_07." + textBox1.Text);
            // Создаем переменную по типу.
            ISomeInterface w = (Z06_07.ISomeInterface)Activator.CreateInstance(t);
            // Вызываем метод.
            w.SomeMethod();
        }
    }

    public interface ISomeInterface
    {
        void SomeMethod();
    }

    public class Class1 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class1");
        }
    }

    public class Class2 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class2");
        }
    }
}
