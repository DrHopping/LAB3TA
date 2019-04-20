using LAB3TAConsole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3TA_WPA
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        static BTree<int, string> tree = new BTree<int, string>(50);
        static SortedSet<int> keys = new SortedSet<int>();
        public Form1()
        {
            InitializeComponent();
        }

        static private void UpdateGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            foreach (var key in keys)
            {
                dataGrid.Rows.Add(tree.Search(key).Key, tree.Search(key).Value);
            }
            dataGrid.Sort(dataGrid.Columns[0], ListSortDirection.Ascending);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (AddValueText.Text != "" && AddKeyText.Text != "")
            {
                if (keys.Contains(int.Parse(AddKeyText.Text))) return;
                keys.Add(int.Parse(AddKeyText.Text));
                tree.Insert(int.Parse(AddKeyText.Text), AddValueText.Text);
                UpdateGrid(dataGridView1);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(RemoveKeyText.Text != "" && keys.Contains(int.Parse(RemoveKeyText.Text)))
            {
                tree.Delete(int.Parse(RemoveKeyText.Text));
                keys.Remove(int.Parse(RemoveKeyText.Text));
                UpdateGrid(dataGridView1);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if(EditValueText.Text != "" && EditKeyText.Text != "" && keys.Contains(int.Parse(EditKeyText.Text)))
            {
                tree.Edit(int.Parse(EditKeyText.Text), EditValueText.Text);
                UpdateGrid(dataGridView1);
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if(FindKeyText.Text != "" && keys.Contains(int.Parse(FindKeyText.Text)))
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[FindIndex(int.Parse(FindKeyText.Text))].Cells[0];
            }
        }

        private int FindIndex(int key)
        {
            int i;
            for (i = 0; (int)dataGridView1.Rows[i].Cells[0].Value != key; i++) { }
            return i;
        }

        private string RandValue(int length)
        {
            var Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[length];
            stringChars[0] = Chars[rand.Next(Chars.Length)];
            for (int i = 1; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[rand.Next(chars.Length)];
            }

            return new String(stringChars);

        }

        private void AddRandom(int number)
        {
            int random;
            for (int i = 0; i < number; i++)
            {
                while (keys.Contains(random = rand.Next(keys.Max + 100))) { }
                tree.Insert(random, RandValue(6));
                keys.Add(random);
            }
            UpdateGrid(dataGridView1);
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            AddRandom(10);
        }
    }
}
