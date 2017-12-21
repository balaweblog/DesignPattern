using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public sealed class Security
    {
        private static int counter = 0;
        private static Security objects = null;
        private Security()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static Security getInstances
        {
            get
            {
                if (objects == null)
                {
                    objects = new Security();

                }
                return objects;
            }
        }
        public  void DomyWorkonceInlifetime(string name)
        {
            Console.WriteLine("method {0}",name);
        }
        //you cant derive
        // public class CheifSecurity : Security
        //{

        //}
    }
}
