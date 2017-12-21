using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Manager
    {
        private static int counter = 0;
        private static Manager objects = null;
        private Manager()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static Manager getInstances
        {
            get
            {
                if (objects == null)
                {
                    objects = new Manager();

                }
                return objects;
            }
        }
        public void DomyWorkonceInlifetime(string name)
        {
            Console.WriteLine("method {0}",name);
        }
        public class Supervisor : Manager
        {

        }
    }
}
