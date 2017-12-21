using System;

namespace DesignPattern
{
    public class Worker
    {
        private static int counter = 0;
        private static Worker objects = null;
        private Worker()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static Worker getInstances
        {
            get
            {
                if (objects == null)
                {
                    objects = new Worker();

                }
                return objects;
            }
        }
        public void DomyWorkonceInlifetime(string name)
        {
            Console.WriteLine("method {0}",name);
        }
    }
}
