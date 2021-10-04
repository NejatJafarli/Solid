using System;
using System.Collections.Generic;

namespace Open_Closed
{
    abstract class Employe
    {
        abstract public void CheckSalary();
    }

    class Manager : Employe
    {
        public override void CheckSalary()
        {
            Console.WriteLine("Manager Salary");
        }
    }
    class Developer : Employe
    {
        public override void CheckSalary()
        {
            Console.WriteLine("Developer Salary");
        }
    }
    class Teacher : Employe
    {
        public override void CheckSalary()
        {
            Console.WriteLine("Teacher Salary");
        }
    }

    class Program
    {
        public static void LookEmployesSalary(List<Employe> Employes)
        {
            foreach (Employe employe in Employes)
            {
                employe.CheckSalary();
            }
        }
        static void Main(string[] args)
        {
            List<Employe> employes = new List<Employe>();

            employes.Add(new Teacher());
            employes.Add(new Developer());
            employes.Add(new Manager());

            LookEmployesSalary(employes);
        }
    }
}
