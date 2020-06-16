﻿using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit6 : Form
    {
        public Unit6()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Запуск длинной операции
            for (int i = 0; i < 100; i++)
            {
                // отправляем значение, которое должен увидеть пользователь
                backgroundWorker1.ReportProgress(i);

                // Приостанавливаем операцию на 100 мс чтобы сделать операцию заметно дольше
                Thread.Sleep(millisecondsTimeout: 100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Результаты показываем в заголовке окна
            this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Выводим сообщение о завершении фоновой задачи
            MessageBox.Show("Finished!");

            // После завершения фоновой операции сделаем кнопку снова активной
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выполняется ли фоновая задача в момент нажатия кнопки
            if (!backgroundWorker1.IsBusy)
            {
                // Если задача не выполняется, то запускаем её асинхронно в качестве фоновой операции
                backgroundWorker1.RunWorkerAsync();
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Обработка нажатия кнопки, которая может быть нажата во время выполнения фоновой операции
            MessageBox.Show("Some Action");
        }
    }
}
