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

        static void Main(string[] args)
        {
            AbstractFactoryExample();
        }
    }
}
