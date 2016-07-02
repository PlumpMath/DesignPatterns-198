using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class AbstractExhibitFactory
    {
        public abstract Predator CreatePredator();
        public abstract Prey CreatePrey();
    }

    public class OceanFactory : AbstractExhibitFactory
    {
        public override Predator CreatePredator()
        {
            return new Shark();
        }

        public override Prey CreatePrey()
        {
            return new Tuna();
        }
    }

    public class JungleFactory : AbstractExhibitFactory
    {
        public override Predator CreatePredator()
        {
            return new Lion();
        }

        public override Prey CreatePrey()
        {
            return new Gazelle();
        }
    }

    public abstract class Predator
    {
        public abstract void Eat(Prey prey);
    }

    public abstract class Prey
    {

    }

    public class Shark : Predator
    {
        public override void Eat(Prey prey)
        {
            Console.WriteLine(this.GetType().Name + " swam and ate the " + prey.GetType().Name);
        }
    }

    public class Lion : Predator
    {
        public override void Eat(Prey prey)
        {
            Console.WriteLine(this.GetType().Name + " sprinted and ate the " + prey.GetType().Name);
        }
    }

    public class Tuna : Prey
    {

    }

    public class Gazelle : Prey
    {

    }

    public class Zoo
    {
        private Predator _predator;
        private Prey _prey;

        public Zoo(AbstractExhibitFactory factory)
        {
            Console.WriteLine("Created the Zoo!");
            _predator = factory.CreatePredator();
            _prey = factory.CreatePrey();
        }

        public void FeedingTime()
        {
            _predator.Eat(_prey);
        }
    }
}