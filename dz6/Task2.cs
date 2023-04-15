using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    internal class Task2
    {
        public static void Run()
        {
            List<Gadget> gadgets = new List<Gadget> { new Kettle(), new Microwave(), new Automobile(), new Ferry() };
            foreach(var gadget in gadgets)
            {
                gadget.Show();
                gadget.Desc();
                Console.Write("Work sound: ");
                gadget.Sound();
                Console.WriteLine();
            }
        }
    }

    public class Gadget
    {
        public string name { get; set; }
        public string electricity_usage { get; set; }

        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Desc() { }
    }

    public class Kettle : Gadget
    {
        public Kettle()
        {
            this.name = "Kettle";
            this.electricity_usage = "20V/Hr";
        }

        public override void Sound()
        {
            Console.WriteLine("SSHHHhhhhhh");
        }

        public override void Show()
        {
            Console.WriteLine($"Gadget name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Is used for boilling water");
            Console.WriteLine($"Spends for work {this.electricity_usage}");
        }
    }

    public class Microwave : Gadget
    {
        public Microwave()
        {
            this.name = "Microwave";
            this.electricity_usage = "40V/Hr";
        }

        public override void Sound()
        {
            Console.WriteLine("WWHHHhhhhh");
        }

        public override void Show()
        {
            Console.WriteLine($"Gadget name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Is used for warming food and making simple dishes");
            Console.WriteLine($"Spends for work {this.electricity_usage}");
        }
    }

    public class Automobile : Gadget
    {
        public Automobile()
        {
            this.name = "Automobile";
            this.electricity_usage = "220V/Hr";
        }

        public override void Sound()
        {
            Console.WriteLine("BBRRRRrrr");
        }

        public override void Show()
        {
            Console.WriteLine($"Gadget name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Is used for moving faster on the ground");
            Console.WriteLine($"Spends for work {this.electricity_usage}");
        }
    }

    public class Ferry : Gadget
    {
        public Ferry()
        {
            this.name = "Ferry";
            this.electricity_usage = "320V/Hr";
        }

        public override void Sound()
        {
            Console.WriteLine("WWHHHSSHHHHHH");
        }

        public override void Show()
        {
            Console.WriteLine($"Gadget name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Is used for moving faster by water");
            Console.WriteLine($"Spends for work {this.electricity_usage}");
        }
    }
}
