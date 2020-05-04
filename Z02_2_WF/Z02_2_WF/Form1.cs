using System;
using System.Windows.Forms;

namespace Z02_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint months = Convert.ToUInt32(numericUpDownMonths.Value);
            uint days = Convert.ToUInt32(numericUpDownDays.Value);
            DateTime date = new DateTime(1990, 1, 1);
            switch (months % 12)
            {
                case 0:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Январь";
                            break;
                        }
                        textBoxAnswer.Text = "Февраль";
                        break;
                    }
                case 1:
                    {
                        if (months / 12 % 4 == 2)
                        {
                            if (days <= 28)
                            {
                                textBoxAnswer.Text = "Февраль";
                                break;
                            }
                            textBoxAnswer.Text = "Март";
                            break;
                        }
                        else
                        {
                            if (days <= 27)
                            {
                                textBoxAnswer.Text = "Февраль";
                                break;
                            }
                            textBoxAnswer.Text = "Март";
                            break;
                        }
                    }
                case 2:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Март";
                            break;
                        }
                        textBoxAnswer.Text = "Апрель";
                        break;
                    }
                case 3:
                    {
                        if (days <= 29)
                        {
                            textBoxAnswer.Text = "Апрель";
                            break;
                        }
                        textBoxAnswer.Text = "Май";
                        break;
                    }
                case 4:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Май";
                            break;
                        }
                        textBoxAnswer.Text = "Июнь";
                        break;
                    }
                case 5:
                    {
                        if (days <= 29)
                        {
                            textBoxAnswer.Text = "Июнь";
                            break;
                        }
                        textBoxAnswer.Text = "Июль";
                        break;
                    }
                case 6:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Июль";
                            break;
                        }
                        textBoxAnswer.Text = "Август";
                        break;
                    }
                case 7:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Август";
                            break;
                        }
                        textBoxAnswer.Text = "Сентябрь";
                        break;
                    }
                case 8:
                    {
                        if (days <= 29)
                        {
                            textBoxAnswer.Text = "Сентябрь";
                            break;
                        }
                        textBoxAnswer.Text = "Октябрь";
                        break;
                    }
                case 9:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Октбрь";
                            break;
                        }
                        textBoxAnswer.Text = "Ноябрь";
                        break;
                    }
                case 10:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Ноябрь";
                            break;
                        }
                        textBoxAnswer.Text = "Декабрь";
                        break;
                    }
                case 11:
                    {
                        if (days <= 30)
                        {
                            textBoxAnswer.Text = "Декабрь";
                            break;
                        }
                        textBoxAnswer.Text = "Январь";
                        break;
                    }
                default:
                    {
                        textBoxAnswer.Text = "Ошибка в количестве месяцев";
                        break;
                    }

            }
        }
    }
}
