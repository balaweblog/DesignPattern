using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public sealed class Student
    {
        private static int counter = 0;
        private static readonly Student objects = new Student();
        private static object obj = new object();
        private Student()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static Student getInstances
        {
            get
            {
                return objects;
            }
        }
        public  bool DomyWorkonceInlifetime(string name )
        {
            var inst = getInstances;
            Console.WriteLine("method {0}",name);
            return true;
        }
    }
}
