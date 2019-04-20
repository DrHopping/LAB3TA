using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3TAConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree<int, string> tree = new BTree<int, string>(5);
            tree.Insert(1, "One");
            tree.Insert(2, "O2");
            tree.Insert(3, "O3");
            tree.Insert(4, "O4");
            tree.Insert(5, "O5");
            tree.Insert(6, "O6");

            tree.Edit(5, "Re");
            
            Console.WriteLine(tree.Search(5).Value);

            Console.ReadLine();
        }
    }
}
