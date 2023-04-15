using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    internal class Task3
    {
        public static void Run()
        {
            List<Musical_Instrument> musical_Instruments = new List<Musical_Instrument> { new Violin(), new Trombone(), new Ukulele(), new Cello() };
            foreach (Musical_Instrument musical_Instrument in musical_Instruments)
            {
                musical_Instrument.Show();
                musical_Instrument.Desc();
                musical_Instrument.History();
                Console.Write("Playing sound: ");
                musical_Instrument.Sound();
                Console.WriteLine();
            }
        }
    }

    public class Musical_Instrument
    {
        public string name { get; set; }
        public double avg_prive { get; set; }

        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Desc() { }
        public virtual void History() { }
    }

    public class Violin : Musical_Instrument
    {
        public Violin()
        {
            this.name = "Violin";
            this.avg_prive = 1500;
        }

        public override void Sound()
        {
            Console.WriteLine("tweedle dum, tweedle dee");
        }

        public override void Show()
        {
            Console.WriteLine($"Instrument's name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Its stringed musical instrument created in 16-th century");
        }

        public override void History()
        {
            Console.WriteLine("The violin was first known in 16th-century Italy, with some further modifications occurring in the 18th and 19th centuries to give the instrument a more powerful sound and projection");
        }
    }

    public class Trombone : Musical_Instrument
    {
        public Trombone()
        {
            this.name = "Trombone";
            this.avg_prive = 1500;
        }

        public override void Sound()
        {
            Console.WriteLine("wah-wah");
        }

        public override void Show()
        {
            Console.WriteLine($"Instrument's name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Its wind musical instrument created in 14-th century");
        }

        public override void History()
        {
            Console.WriteLine("While the invention of the early trombone, or sackbut, cannot be traced to one individual or with certainty to a specific location, it is thought to have been invented in Belgium around 1450. The sackbut was created to emulate the sound of a trumpet while playing lower notes.");
        }
    }

    public class Ukulele : Musical_Instrument
    {
        public Ukulele()
        {
            this.name = "Ukulele";
            this.avg_prive = 1500;
        }

        public override void Sound()
        {
            Console.WriteLine("whul-lu-ll");
        }

        public override void Show()
        {
            Console.WriteLine($"Instrument's name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Its wind guitar-like musical instrument created in 1880-th");
        }

        public override void History()
        {
            Console.WriteLine("Developed in the 1880s, the ukulele is based on several small, guitar-like instruments of Portuguese origin, the machete, cavaquinho, timple, and rajão, introduced to the Hawaiian Islands by Portuguese immigrants from Madeira, the Azores and Cape Verde.");
        }
    }

    public class Cello: Musical_Instrument
    {
        public Cello()
        {
            this.name = "Cello";
            this.avg_prive = 1500;
        }

        public override void Sound()
        {
            Console.WriteLine("whe-le-le");
        }

        public override void Show()
        {
            Console.WriteLine($"Instrument's name: {this.name}");
        }

        public override void Desc()
        {
            Console.WriteLine("Its large violin-like musical instrument created in 16-th century");
        }

        public override void History()
        {
            Console.WriteLine("he earliest cellos were developed during the 16th century and frequently were made with five strings. They served mainly to reinforce the bass line in ensembles. Only during the 17th and 18th centuries did the cello replace the bass viola da gamba as a solo instrument.");
        }
    }
}
