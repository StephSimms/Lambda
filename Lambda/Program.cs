using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();



            employee.fname = new List<string>() { "Joe", "Devlan", "Spencer", "Andrew", "Lucky", "Steph", "Steve", "Fred", "Joe", "Michael" };
            employee.lname = new List<string>() { "Schmoe", "Cecil", "Cleophas", "David", "Simms", "Ann", "Skrobot", "Best", "Buck", "Jordan" };
            employee.ID = new List<int>() { 11, 21, 31, 41, 51, 61, 71, 81, 91, 101 };

            int count = employee.fname.Count(x => x == "Joe");

            List<string> joeList = employee.fname.Where(x => x == "Joe").ToList();

            List<int> aboveFive = employee.ID.Where(x => x> 5).ToList();

            for (int j = aboveFive[0] -1; j < aboveFive[0] + aboveFive.Count -1; j++)
            {
                Console.WriteLine(employee.ID[j] + " "+employee.fname[j] + " " + employee.lname[j]);
            }


            foreach (string joe in joeList)
            {
                Console.WriteLine("\n" + joe);
            }


            for (int i = 0; i < employee.fname.Count; i++) 
            {
                Console.WriteLine(employee.ID[i] + " " + employee.fname[i] + " " + employee.lname[i]);
            }

            Console.WriteLine("\n Hello, there are " + count + " Joes in this Company");
            Console.ReadLine();



                
            
        }
    }
}