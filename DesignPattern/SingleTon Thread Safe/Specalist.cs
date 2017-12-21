using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public sealed class Specalist
    {
        private static int counter = 0;
        private static Specalist objects = null;
        private static object obj = new object();
        private Specalist()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static Specalist getInstances
        {
            get
            {
                lock (obj)
                {
                    if (objects == null)
                    {
                        objects = new Specalist();

                    }
                }
                return objects;
            }
        }
        public  bool DomyWorkonceInlifetime(string name)
        {
            var inst = getInstances;
            Console.WriteLine("method {0}",name);
            return true;
        }
    }
}
