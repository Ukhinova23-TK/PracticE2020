using System;
using System.Windows.Forms;
using System.Xml;

namespace Z06_07
{
    public partial class Unit7 : Form
    {
        public Unit7()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Получение всех дочерних элементов
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый xml-документ.
            XmlDocument xml = new XmlDocument();
            // Загружаем в xml-документ xml-файл.
            xml.Load("Xml.xml");
            // Берем корневой узел (тег) xml-документа.
            XmlNode d = xml.DocumentElement;
            // Берем все дочерние теги.
            XmlNodeList xnl = d.ChildNodes;
            // Перебираем все дочерние теги.
            for (int i = 0; i < d.ChildNodes.Count; i++)
            {
                // Выводим атрибуты тегов.
                MessageBox.Show(xnl[i].Attributes["text"].Value + " " +
                    xnl[i].Attributes["rustext"].Value);
            }
        }
    }
}
