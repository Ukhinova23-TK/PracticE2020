﻿using System;
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
    public partial class Unit4 : Form
    {
        public Unit4()
        {
            InitializeComponent();
            this.Load += statusStrip1_Resize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                label1.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                statusStrip1.Items[0].Text = ex.Message;
            }
            catch
            {
                label1.Text = "Неизвестная ошибка!";
            }
        }

        private void statusStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Clicked status bar");
        }

        private void statusStrip1_Resize(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Width = statusStrip1.Width - 150;
        }

        private void toolStripStatusLabel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Blue, width: 2), 2, 2, 15, 15);
        }
    }
}
