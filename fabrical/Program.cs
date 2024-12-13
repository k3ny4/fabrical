using System;

namespace MyFactoryLib
{
    public interface IProduct
    {
        string GetName();
    }

    public class ConcreteProductA : IProduct
    {
        public string GetName()
        {
            return "I'm Product A";
        }
    }

    public class ConcreteProductB : IProduct
    {
        public string GetName()
        {
            return "I'm Product B";
        }
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            return $"Creator: The same creator's code just worked with {product.GetName()}";
        }
    }

    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}

namespace FactoryMethodDemo
{
    using MyFactoryLib;

    class Program
    {
        static void Main(string[] args)
        {
            Creator creatorA = new ConcreteCreatorA();
            Console.WriteLine(creatorA.SomeOperation());

            Creator creatorB = new ConcreteCreatorB();
            Console.WriteLine(creatorB.SomeOperation());

            Console.ReadLine();
        }
    }
}
