using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace GoFish
{

    public class Fish
    {       
        public string Name { get; set; }
        public string Type { get; set; }
        public string Diet { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }

        public void Add()
        {

            Fish fish = new Fish();

            Console.WriteLine("What is the fish's name: ");
            fish.Name = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Does the fish live in Saltwater or Freshwater: ");
            fish.Type = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Does the fish eat Meat or Plants: ");
            fish.Diet = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("Where is the fish from: ");
            fish.Nationality = Console.ReadLine().ToLower();
            Console.Clear();
            Console.WriteLine("(Optional) Describe the fish: ");
            fish.Description = Console.ReadLine().ToLower();
            Console.Clear();

            if (fish.Type == "saltwater" && fish.Diet == "meat")
            {
                Console.WriteLine("The fish has been added to Tank1");
                List<Fish> tank1 = new List<Fish>();
                tank1.Add(fish);
                string filePath1 = @"C:\Users\LeifS\fishdata\tank1.txt";
                JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };
                string json1 = JsonConvert.SerializeObject(tank1);
                File.WriteAllText(filePath1, json1);
            }
            else if (fish.Type == "saltwater" && fish.Diet == "plants")
            {
                Console.WriteLine("The fish has been added to Tank2");
                List<Fish> tank2 = new List<Fish>();
                tank2.Add(fish);
                string filePath2 = @"C:\Users\LeifS\fishdata\tank2.txt";
                JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };
                string json2 = JsonConvert.SerializeObject(tank2);
                File.WriteAllText(filePath2, json2);
            }
            else if (fish.Type == "freshwater" && fish.Diet == "meat")
            {
                Console.WriteLine("The fish has been added to Tank3");
                List<Fish> tank3 = new List<Fish>();
                tank3.Add(fish);
                string filePath3 = @"C:\Users\LeifS\fishdata\tank3.txt";
                JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };
                string json3 = JsonConvert.SerializeObject(tank3);
                File.WriteAllText(filePath3, json3);
            }
            else if (fish.Type == "freshwater" && fish.Diet == "plants")
            {
                Console.WriteLine("The fish has been added to Tank4");
                List<Fish> tank4 = new List<Fish>();
                tank4.Add(fish);
                string filePath4 = @"C:\Users\LeifS\fishdata\tank4.txt";
                JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };
                string json4 = JsonConvert.SerializeObject(tank4);
                File.WriteAllText(filePath4, json4);
            }
        }

        public void ShowAll()
        {
            string filePath1 = @"C:\Users\LeifS\fishdata\tank1.txt";
            string filePath2 = @"C:\Users\LeifS\fishdata\tank2.txt";
            string filePath3 = @"C:\Users\LeifS\fishdata\tank3.txt";
            string filePath4 = @"C:\Users\LeifS\fishdata\tank4.txt";

            
            string tank1Content = File.ReadAllText(filePath1);
            Console.WriteLine("Tank 1: " + tank1Content + "\n");

            string tank2Content = File.ReadAllText(filePath2);
            Console.WriteLine("Tank 2: " + tank2Content + "\n");

            string tank3Content = File.ReadAllText(filePath3);
            Console.WriteLine("Tank 3: " + tank3Content + "\n");

            string tank4Content = File.ReadAllText(filePath4);
            Console.WriteLine("Tank 4: " + tank4Content + "\n");

            Console.ReadKey();
            Console.Clear();
        }
    }

}



    