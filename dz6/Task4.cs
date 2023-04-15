using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    internal class Task4
    {
        public static void Run()
        {
            List<Worker> workers = new List<Worker> { new President("Ivan Ivanenko", 5500), new Security("Stephan Brown", 7800), new Manager("July Peterson", 6700), new Engineer("Jacob Armstrong", 10200) };
            foreach (Worker worker in workers)
            {
                worker.Print();
                Console.WriteLine();
            }
        }
    }

    public abstract class Worker
    {
        public abstract string initials { get; set; }
        public abstract int salary { get; set; }

        public abstract void Print();
    }

    public class President : Worker
    {
        public override string initials { get; set; }
        public override int salary { get; set;}

        public President(string initials, int salary)
        {
            this.initials = initials;
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Job: President");
            Console.WriteLine($"Initials: {this.initials}");
            Console.WriteLine($"Salary: {this.salary}");
            Console.WriteLine("This person is responsible for countrie's wellbeing");
        }
    }

    public class Security : Worker
    {
        public override string initials { get; set; }
        public override int salary { get; set; }

        public Security(string initials, int salary)
        {
            this.initials = initials;
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Job: Security");
            Console.WriteLine($"Initials: {this.initials}");
            Console.WriteLine($"Salary: {this.salary}");
            Console.WriteLine("This person is responsible for providing someone's safety");
        }
    }

    public class Manager : Worker
    {
        public override string initials { get; set; }
        public override int salary { get; set; }

        public Manager(string initials, int salary)
        {
            this.initials = initials;
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Job: Manager");
            Console.WriteLine($"Initials: {this.initials}");
            Console.WriteLine($"Salary: {this.salary}");
            Console.WriteLine("This person is responsible for planning, organising and controlling some processes of some facility");
        }
    }

    public class Engineer : Worker
    {
        public override string initials { get; set; }
        public override int salary { get; set; }

        public Engineer(string initials, int salary)
        {
            this.initials = initials;
            this.salary = salary;
        }

        public override void Print()
        {
            Console.WriteLine($"Job: Engineer");
            Console.WriteLine($"Initials: {this.initials}");
            Console.WriteLine($"Salary: {this.salary}");
            Console.WriteLine("This person is responsible for finding ways of optimising current engineering state of facility or making some new engineering decisions");
        }
    }
}
