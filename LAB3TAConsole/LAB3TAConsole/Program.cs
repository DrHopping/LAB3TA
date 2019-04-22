using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3TAConsole
{
    class Program
    {
        static Random rand = new Random();

        static private string RandValue(int length)
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

        static private void AddRandom(int number)
        { 
            for (int i = 0; i < number; i++)
            {
                tree.Insert(i, RandValue(10));
            }
        }

        static BTree<int, string> tree = new BTree<int, string>(50);

        static void Main(string[] args)
        {

            AddRandom(10000);
            int random;
            Console.WriteLine(random = rand.Next(10000));
            Console.WriteLine(tree.Search(4567).Value);
            Console.WriteLine(tree.comparisons);
            Console.WriteLine("---------------");
        
            Console.ReadLine();
        }
    }
}
