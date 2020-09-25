using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diamond
{
    class Program
    {
        const int size = 4;
        const string ThreeSpace = "   ";
        static void Main(string[] args)
        {
            int level = 0;
            Recursive(level);
            Console.ReadLine();
        }
        static void Recursive(int level)
        {
            string leader = "";
            string text = "";
            int index = 0;

            if (level >= (2 * size) - 1) return;

            if (level < size)
            {
                
                index = size - level - 1;
                text = string.Join(ThreeSpace, new string((char)(index + 65), level + 1).Select(x => (char)(level + 65)));
            }
            else
            {
                //Reverse
                index = level - size + 1;
                text = string.Join(ThreeSpace, new string((char)(index + 65 - 1), size - index).Select(x => (char)(size - index + 65 - 1)));
            }
            leader = new string(' ', 2 * index);
            Console.WriteLine(leader + text);
            Recursive(level + 1);

        }
    }
}
