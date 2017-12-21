using System;

namespace DesignPattern
{
    public static class Employee
    {
        private static int counter = 0;
        static Employee()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static void DomyWorkonceInlifetime(string name)
        {
            Console.WriteLine("calling the {0} method", name);
        }
    }
}
