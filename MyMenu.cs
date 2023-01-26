using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    public class MyMenu
    {
        public string[] titles = { "Mainmenu", "1)  Add", "2)  Show list", "3)  Exit" };

        public void Menu()
        {
            Console.SetCursorPosition(40, 0);
            Console.WriteLine(titles[0] + "\n");
            Console.SetCursorPosition(0, 5);

            for (int i = 1; i < titles.Length; i++)
            {
                Console.WriteLine(titles[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
