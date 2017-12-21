using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public sealed class Scientist
    {
        private static int counter = 0;
        private static readonly Lazy<Scientist> objects = new Lazy<Scientist>(() => new Scientist());
        private static object obj = new object();
         private Scientist()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static Scientist getInstances
        {
            get
            {
                return objects.Value;
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
