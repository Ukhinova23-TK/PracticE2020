using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit24 : Form
    {
        public Unit24()
        {
            InitializeComponent();
        }

        private void Unit24_Load(object sender, EventArgs e)
        {
            // Создаем узел верхнего уровня.
            TreeNode treeNode = treeView1.Nodes.Add("Item1");
            // Создаем два подузла для него.
            TreeNode treeNode11 = treeNode.Nodes.Add("Item11");
            TreeNode treeNode12 = treeNode.Nodes.Add("Item12");
            // Создание подузлов для подузлов.
            treeNode11.Nodes.Add("Item111");
            treeNode11.Nodes.Add("Item112");
            treeNode12.Nodes.Add("Item121");
            treeNode12.Nodes.Add("Item122");
            // Раскрываем все дерево.
            treeNode.ExpandAll();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Ставим галочку на всех подузлах.
            SelectAllSubnodes(e.Node);
        }

        // Метод для установки галочки для всех подузлов.
        void SelectAllSubnodes(TreeNode treeNode)
        {
            // Ставим или убираем отметку со всех подузлов.
            foreach (TreeNode treeSubNode in treeNode.Nodes)
            {
                treeSubNode.Checked = treeNode.Checked;
            }
        }
    }
}
