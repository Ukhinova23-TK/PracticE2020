using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit8 : Form
    {
        public Unit8()
        {
            InitializeComponent();
        }

        public int num = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            // Увеличиваем счетчик пунктов меню.
            num++;
            // Создаем новый подпункт меню.
            // Для него задаем надпись
            // и обработчик выбора пользователем этого пункта.
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.menuToolStripMenuItem_Click;
            // Подсоединяем новый пункт меню к главному меню формы.
            menuToolStripMenuItem.DropDownItems.Add(mi);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Читаем текст на выбранном пользователе пункте меню.
            string s = ((ToolStripMenuItem)sender).Text;
            // Выводим этот текст.
            MessageBox.Show(s);
        }
    }
}
