using System;
using System.IO;
using System.Windows.Forms;

namespace Z09_1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Init()
        {
            try
            {
                double A, B, H;
                A = (double)numericUpDownRun.Value;
                B = (double)numericUpDownEnd.Value;
                H = (double)numericUpDownFoot.Value;
                if (A > B)
                {
                    throw new Exception("Начало интервала не может быть больше конца");
                }
                using (BinaryWriter bw = new BinaryWriter(File.Open("file.dat", FileMode.Create)))
                {
                    for (double i = A; i <= B; i += H)
                    {
                        bw.Write(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message);
            }
        }

        public void Outit()
        {
            try
            {
                double help;
                using (BinaryReader br = new BinaryReader(File.Open("file.dat", FileMode.Open)))
                {
                    while (br.PeekChar() > -1)
                    {
                        help = br.ReadDouble();
                        if (help > 0)
                        {
                            richTextBoxAnswer.Text += help + " ";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            richTextBoxAnswer.Text = "";
            Init();
            Outit();
        }
    }
}
