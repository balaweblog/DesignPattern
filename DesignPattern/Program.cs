using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //If you just have static class and you can call the method multiple times and you cant have constructor.
            /*
            bool variable = StaticClasses.DomyWorkonceInlifetime();
            bool variable1 = StaticClasses.DomyWorkonceInlifetime();
            */

            // actual implementation of single ton class
            /*
            var variable = Singleton.getInstances;
            Singleton.DomyWorkonceInlifetime();
            var variable1 = Singleton.getInstances;
            Singleton.DomyWorkonceInlifetime();
            */

            //you cant inherit the above class since it has private constructor. but if you have nested class.
            //this will create object and will try polluting your class of singleton. 
            // so it is always safe to seal the singleton class to avoid inheritance
            /*
            var variable = NestedTon.getInstances;
            NestedTon.Newton newton = new NestedTon.Newton();
            NestedTon.Newton newton1 = new NestedTon.Newton();
            */

            //make it sealed 
            /*
            var variable = SealedTon.getInstances;
            var variable1 = SealedTon.getInstances;
            */

            // make it thread safe and invoke it parallely
            //this is right approach of implementation but thread is costly 
            //you are locking the object
            /*
            Parallel.Invoke(
                () => ThreadTon.DomyWorkonceInlifetime(),
                () => ThreadTon.DomyWorkonceInlifetime());
                */
            //to avoid locking go with eagerloading (read only object instant)
            /*
            Parallel.Invoke(
               () => EagerLoading.DomyWorkonceInlifetime(),
               () => EagerLoading.DomyWorkonceInlifetime());
            Console.Read();
            */

            //further move on go with lazy loading after invoking

            Parallel.Invoke(
            () => EagerLoading.DomyWorkonceInlifetime(),
            () => EagerLoading.DomyWorkonceInlifetime());
            Console.Read();
        }
    }
    public static class StaticClasses
    {
        private static int counter = 0;
        static StaticClasses()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public  static bool DomyWorkonceInlifetime()
        {
            Console.WriteLine("One time only strictly");
            return true;
        }
    }
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton objects = null;
        private Singleton()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static Singleton getInstances
        {
            get
            {
                if (objects == null)
                {
                    objects = new Singleton();
                    
                }
                return objects;
            }
        }
        public static bool DomyWorkonceInlifetime()
        {
            Console.WriteLine("One time only strictly");
            return true;
        }
    }
    public class NestedTon
    {
        private static int counter = 0;
        private static NestedTon objects = null;
        private NestedTon()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static NestedTon getInstances
        {
            get
            {
                if (objects == null)
                {
                    objects = new NestedTon();

                }
                return objects;
            }
        }
        public static bool DomyWorkonceInlifetime()
        {
            Console.WriteLine("One time only strictly");
            return true;
        }
        public class Newton: NestedTon
        {

        }
    }
    public sealed class SealedTon
    {
        private static int counter = 0;
        private static SealedTon objects = null;
        private SealedTon()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static SealedTon getInstances
        {
            get
            {
                if (objects == null)
                {
                    objects = new SealedTon();

                }
                return objects;
            }
        }
        public static bool DomyWorkonceInlifetime()
        {
            Console.WriteLine("One time only strictly");
            return true;
        }
        //you cant derive
       // public class Newton : SealedTon
        //{

        //}
    }
    public sealed class ThreadTon
    {
        private static int counter = 0;
        private static ThreadTon objects = null;
        private static object obj = new object();
        private ThreadTon()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static ThreadTon getInstances
        {
            get
            {
                lock (obj)
                {
                    if (objects == null)
                    {
                        objects = new ThreadTon();

                    }
                }
                return objects;
            }
        }
        public static bool DomyWorkonceInlifetime()
        {
            var inst = getInstances;
            Console.WriteLine("One time only strictly");
            return true;
        }
    }
    public sealed class EagerLoading
    {
        private static int counter = 0;
        private static readonly EagerLoading objects = new EagerLoading();
        private static object obj = new object();
        private EagerLoading()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static EagerLoading getInstances
        {
            get
            {
                return objects;
            }
        }
        public static bool DomyWorkonceInlifetime()
        {
            var inst = getInstances;
            Console.WriteLine("One time only strictly");
            return true;
        }
    }
    public sealed class LazyLoading
    {
        private static int counter = 0;
        private static readonly Lazy<LazyLoading> objects = new Lazy<LazyLoading>();
        private static object obj = new object();
        private LazyLoading()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public static LazyLoading getInstances
        {
            get
            {
                return objects.Value;
            }
        }
        public static bool DomyWorkonceInlifetime()
        {
            var inst = getInstances;
            Console.WriteLine("One time only strictly");
            return true;
        }
    }
}
