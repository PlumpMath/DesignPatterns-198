using DesignPatterns.LazyLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void AbstractFactoryExample()
        {
            /* This example uses the Abstract Factory design pattern to 
             * create zoo exhibits. The zoo can contain either an ocean
             * or jungle exhibit depending on the factory passed to the 
             * zoo constructor. The zoo has a feeding time method available
             * regardless of the type of exhibit
             */

            AbstractExhibitFactory oceanFactory = new OceanFactory();
            AbstractExhibitFactory jungleFactory = new JungleFactory();

            Zoo zoo1 = new Zoo(jungleFactory);
            zoo1.FeedingTime();

            Zoo zoo2 = new Zoo(oceanFactory);
            zoo2.FeedingTime();

            Console.ReadKey();
        }

        public static void FactoryExample()
        {
            /* Intent
             *      Define an interface for creating an object, but let subclasses decide which class to instantiate
             *      Factory Method lets a class defer instantiation to subclasses
             */
        }

        static void Main(string[] args)
        {
            //AbstractFactoryExample();
            var factory = new SimpleCatFactory();
            var kitty = factory.GetKitty("actual");

            Console.ReadKey();
        }
    }
}
