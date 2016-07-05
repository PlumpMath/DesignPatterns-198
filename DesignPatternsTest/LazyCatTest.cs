using System;
using System.Diagnostics;
using DesignPatterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.LazyLoading;

namespace DesignPatternsTest
{
    [TestClass]
    public class LazyCatTest
    {
        [TestMethod]
        public void CustomBad()
        {
            var factory = new SimpleCatFactory();
            var kitty = (CustomLazyCat) factory.GetKitty("custom");

            Assert.IsNull(kitty._name);                        
        }

        [TestMethod]
        public void CustomGood()
        {
            var factory = new SimpleCatFactory();
            var kitty = (CustomLazyCat) factory.GetKitty("custom");          

            Assert.IsNull(kitty._name);
            Debug.WriteLine("Here kitty kitty");

            Assert.IsNotNull(kitty.Name);
        }

        [TestMethod]
        public void CustomRepeat()
        {
            var factory = new SimpleCatFactory();
            var kitty = (CustomLazyCat) factory.GetKitty("custom");
            
            Assert.IsNull(kitty._name);

            Debug.WriteLine("Here kitty kitty");
            Assert.IsNotNull(kitty.Name);

            Debug.WriteLine("Here kitty kitty");
            Assert.IsNotNull(kitty._name);
            Assert.IsNotNull(kitty.Name);
        }

        [TestMethod]
        public void ActualLazyCatTest()
        {
            var factory = new SimpleCatFactory();
            var kitty = (ActualLazyCat) factory.GetKitty("actual");
            
            Debug.WriteLine("Here kitty kitty");
            Assert.IsNotNull(kitty._nameInitializer.Value);
            Debug.WriteLine("Here kitty kitty");
            Assert.IsNotNull(kitty.Name);

        }
    }
}
