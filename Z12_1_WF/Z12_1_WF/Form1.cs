using System;
using System.Windows.Forms;

namespace Z12_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = (int)numericUpDownXP2.Value;
                int y = (int)numericUpDownYP2.Value;
                Point point = new Point(x, y);
                richTextBox.Text = $"Изначальные координаты точки: {point.Print()}\n";
                point++;
                richTextBox.Text += $"Точка++ = {point.Print()}\n";
                point--;
                richTextBox.Text += $"Точка-- = {point.Print()}\n";
                int s = (int)numericUpDownScal.Value;
                point += s;
                richTextBox.Text += $"Точка + скаляр = {point.Print()}\n";
                point = s + point;
                richTextBox.Text += $"Скаляр + точка = {point.Print()}\n";
                if (point)
                {
                    richTextBox.Text += "X == Y\n";
                }
                else
                {
                    richTextBox.Text += "X != Y\n";
                }
                string str = (string)point;
                richTextBox.Text += $"Преобразование в String: {str}\n";
                Point str_point = (Point)str;
                richTextBox.Text += $"Преобразование в Point: {str_point.Print()}\n";
                richTextBox.Text += $"Результат обращения по индексу 0: {point[0]}\n";
                richTextBox.Text += $"Результат обращения по индексу 1: {point[1]}\n";
                richTextBox.Text += $"Результат обращения по несуществующему индексу: {point[2]}\n";
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message);
            }
        }
    }
}
