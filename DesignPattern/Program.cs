using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Basics of Creational and singleton pattern
            //when one object of class is created.all referece to the objects are refered to the same underlying instance created

            #region Static Classes and Methods
            /* 
            Acheiving singleton behaviour in static classes 
            If you just have static class and you can call the method multiple times and you cant have constructor. 
            */
            //Employee.DomyWorkonceInlifetime("first");
            //Employee.DomyWorkonceInlifetime("second");
            #endregion

            #region Basic SingleTon Impelementation
            /*
            Singleton implementation 
            you cant create object since it has constructor and instance is accessed through properties. 
            You cant inherit as well because of private constructor. but if you have nested class this will create object and will try polluting
            your class of singleton
            */
            //var worker = Worker.getInstances;
            //worker.DomyWorkonceInlifetime("first");
            //var worker1 = Worker.getInstances;
            //worker1.DomyWorkonceInlifetime("Second");
            #endregion

            #region Singleton Break with Inner Class
            /*
           Nested class inside the singleton class will pollute your code to create object so this is wrong. 
           we can stop this by using sealed class so cant inherit in nested class
           */
            //var manager = Manager.getInstances;
            // var manager1 = Manager.getInstances;
            //manager.DomyWorkonceInlifetime("first");
            //manager1.DomyWorkonceInlifetime("second");
            //Manager.Supervisor supervisor1 = new Manager.Supervisor();
            //Manager.Supervisor supervisor2 = new Manager.Supervisor();

            #endregion

            #region Singleton Wrap with sealed so no class inheritance and inner class expose

            /*make it sealed your singleton class
             * the problem with this is it is not thread safe so if running parallely it wont impact
            */
            //var security = Security.getInstances;
            //var security1 = Security.getInstances;
            //security.DomyWorkonceInlifetime("first");
            //security1.DomyWorkonceInlifetime("second");

            #endregion

            #region Singleton Thread Safe

            // make it thread safe
            //the problem in this is you are locking the object and thread is costly
            // make it thread safe and invoke it parallely
            //var specalist1 = Specalist.getInstances;
            //var specalist2 = Specalist.getInstances;
            //Parallel.Invoke(
            //   () => specalist1.DomyWorkonceInlifetime("first"),
            //   () => specalist2.DomyWorkonceInlifetime("second"));
            #endregion

            #region SingleTon Eager Loading  to avoid locking
            //to avoid locking go with eagerloading (read only object instant)
            //var student1 = Student.getInstances;
            //var student2 = Student.getInstances;
            //Parallel.Invoke(
            //   () => student1.DomyWorkonceInlifetime("first"),
            //   () => student2.DomyWorkonceInlifetime("second"));
            #endregion

            #region SingleTon Lazy Loading
            //further move on go with lazy loading after invoking
            //var scientist1 = Scientist.getInstances;
            //var scientist2 = Scientist.getInstances;
            //Parallel.Invoke(
            //() => scientist1.DomyWorkonceInlifetime("first"),
            //() => scientist2.DomyWorkonceInlifetime("second"));
            #endregion

            #region Real Time Example
            // look at the code in creational.singleton.example
            //Logging feature need to be called once in project lifetime 
            //ReferREALTIMEEXAMPLE comments 
            #endregion

         
           Console.Read();
        }
    }
}
