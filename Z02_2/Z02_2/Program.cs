using System;

namespace Z02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Кличество прошедших месяцев: ");
                uint months = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Колиечество прошедших дней: ");
                uint days = Convert.ToUInt32(Console.ReadLine());
                if (days > 31)
                {
                    Console.WriteLine("Максимальное количество вводимых дней не может быть больше максимального количества дней в месяце.");
                    return;
                }
                DateTime date = new DateTime(1990, 1, 1);
                uint ostm = months % 12;
                switch (ostm)
                {
                    case 0:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Январь");
                                break;
                            }
                            Console.WriteLine("Февраль");
                            break;
                        }
                    case 1:
                        {
                            if (months / 12 % 4 == 2)
                            {
                                if (days <= 28)
                                {
                                    Console.WriteLine("Февраль");
                                    break;
                                }
                                Console.WriteLine("Март");
                                break;
                            }
                            else
                            {
                                if (days <= 27)
                                {
                                    Console.WriteLine("Февраль");
                                    break;
                                }
                                Console.WriteLine("Март");
                                break;
                            }
                        }
                    case 2:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Март");
                                break;
                            }
                            Console.WriteLine("Апрель");
                            break;
                        }
                    case 3:
                        {
                            if (days <= 29)
                            {
                                Console.WriteLine("Апрель");
                                break;
                            }
                            Console.WriteLine("Май");
                            break;
                        }
                    case 4:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Май");
                                break;
                            }
                            Console.WriteLine("Июнь");
                            break;
                        }
                    case 5:
                        {
                            if (days <= 29)
                            {
                                Console.WriteLine("Июнь");
                                break;
                            }
                            Console.WriteLine("Июль");
                            break;
                        }
                    case 6:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Июль");
                                break;
                            }
                            Console.WriteLine("Август");
                            break;
                        }
                    case 7:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Август");
                                break;
                            }
                            Console.WriteLine("Сентябрь");
                            break;
                        }
                    case 8:
                        {
                            if (days <= 29)
                            {
                                Console.WriteLine("Сентябрь");
                                break;
                            }
                            Console.WriteLine("Октябрь");
                            break;
                        }
                    case 9:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Октбрь");
                                break;
                            }
                            Console.WriteLine("Ноябрь");
                            break;
                        }
                    case 10:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Ноябрь");
                                break;
                            }
                            Console.WriteLine("Декабрь");
                            break;
                        }
                    case 11:
                        {
                            if (days <= 30)
                            {
                                Console.WriteLine("Декабрь");
                                break;
                            }
                            Console.WriteLine("Январь");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка");
                            break;
                        }
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadKey();
            }
        }
    }
}
