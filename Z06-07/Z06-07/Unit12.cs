using System;
using System.Drawing.Drawing2D;
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
    public partial class Unit12 : Form
    {
        public Unit12()
        {
            InitializeComponent();
        }

        private void Unit12_Load(object sender, EventArgs e)
        {
            // Создаем объект GraphicsPath.
            GraphicsPath gp = new GraphicsPath();
            // Прибавляем два круга.
            gp.AddEllipse(0, 0, 100, 100);
            gp.AddEllipse(110, 0, 100, 100);
            // Создаем регион на основе экземпляра GraphicsPath.
            Region r = new Region(gp);
            // Присваиваем созданный регион
            // региону нашего окна.
            this.Region = r;

        }
    }
}
