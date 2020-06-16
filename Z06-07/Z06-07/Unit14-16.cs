using System;
using System.Windows.Forms;

namespace Z06_07
{
    public partial class Unit14 : Form
    {
        public Unit14()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получаем выделенный узел.
            TreeNode node = treeView1.SelectedNode;
            // Если ничего не выделено,
            if (node == null)
            {
                // то добавляем в корень.
                treeView1.Nodes.Add(AddNodeTextBox.Text);
            }
            else
            {
                // Если выделенный узел существует,
                // то добавляем к нему.
                node.Nodes.Add(AddNodeTextBox.Text);
            }
            // Очищаем текстовое поле и переводим на него фокус. 
            AddNodeTextBox.Text = "";
            AddNodeTextBox.Focus();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // Получаем выделенный узел.
            TreeNode node = treeView1.SelectedNode;
            // Если узел выделен,
            if (node != null)
            {
                // то его и удаляем.
                treeView1.Nodes.Remove(node);
            }
            else
            {
                MessageBox.Show("Ничего не выделено");
            }

        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

        }

        private void Unit14_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            // Снимаем выделение с дерева.
            treeView1.SelectedNode = null;
            // Ищем узел с определенным текстом.
            TreeNode tn = FindNode(treeView1.Nodes, FindNodeTextBox.Text);
            // Если нашли,
            if (tn != null)
            {
                // то выделяем узел.
                treeView1.SelectedNode = tn;
                treeView1.Focus();
            }
        }

        private TreeNode FindNode(TreeNodeCollection tnc, string name)
        {
            // Ищем в узлах первого уровня.
            foreach (TreeNode tn in tnc)
            {
                // Если нашли,
                if (tn.Text == name)
                {
                    // то возвращаем.
                    return tn;
                }
            }

            // Ищем в подузлах.
            TreeNode node;
            foreach (TreeNode tn in tnc)
            {
                // Делаем поиск в узлах.
                node = FindNode(tn.Nodes, name);
                // Если нашли,
                if (node != null)
                {
                    // то возвращаем.
                    return node;
                }
            }

            // Ничего не нашли.
            return null;
        }

    }
}
