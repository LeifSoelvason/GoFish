using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoFish
{
    internal class Program
    {
        public static bool Exit = false;

        static void Main(string[] args)
        {
            do 
            {               
                MyMenu Obj = new MyMenu();
                Obj.Menu();
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Fish fish1 = new Fish();
                        fish1.Add();
                        break;
                    case "2":
                       Console.Clear();
                       Fish fish2 = new Fish();
                       fish2.ShowAll();                                               
                        break;
                    case "3":                       
                        Exit = true;
                        break;
                }
            }
            while (!Exit);
        }
    }
}
