using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit17 : Form
    {
        public Unit17()
        {
            InitializeComponent();
        }

        private void Unit17_Load(object sender, EventArgs e)
        {
            // Перебираем все элементы на форме.
            foreach (Control c in Controls)
            {
                // Если элемент есть потомок класса ButtonBase,
                if (c is ButtonBase)
                {
                    // то применяем стиль Системы.
                    ((ButtonBase)c).FlatStyle = FlatStyle.System;

                }
            }
        }
    }
}
