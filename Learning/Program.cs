using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create an instance of MethodsCollection
            MethodsCollection mCollection = new MethodsCollection();

            // Call the methods using the instance of MethodsCollection
            mCollection.VariableLearning();
            mCollection.Loops();
            mCollection.SwitchCaseExample();

            InterfaceCheckClass icClass = new InterfaceCheckClass();

            // Call the method defined in IMethod
            icClass.IMethod();

            GenericClass<string> genObj1 = new GenericClass<string>("Hello");

            // Call the method defined in GenericClass
            genObj1.GMethod();

            // Create an instance of GenericClass with int as the type argument
            GenericClass<int> genObj2 = new GenericClass<int>(42);

            // Call the method defined in GenericClass
            genObj2.GMethod();
        }
    }

    public class MethodsCollection
    {
        public void VariableLearning()
        {
            // Variable code
            int number = 5;
            string name = "John Doe";
            bool isTrue = true;

            Console.WriteLine("Number: " + number);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("IsTrue: " + isTrue);
        }

        public void Loops()
        {
            // Loop code
            Console.WriteLine("For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }
            Console.WriteLine();

            Console.WriteLine("While Loop:");
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine("Counter: " + counter);
                counter++;
            }
            Console.WriteLine();
        }

        public void SwitchCaseExample()
        {
            // Switch case
            Console.WriteLine("Switch Case Example:");
            int option = 2;
            switch (option)
            {
                case 1:
                    Console.WriteLine("Option 1 selected");
                    break;
                case 2:
                    Console.WriteLine("Option 2 selected");
                    break;
                case 3:
                    Console.WriteLine("Option 3 selected");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    public interface SampleInterface
    {
        void IMethod();
    }

    public class InterfaceCheckClass : SampleInterface
    {
        public void IMethod()
        {
            Console.WriteLine("IMethod implementation in InterfaceCheckClass");
        }
    }

    public class GenericClass<T>
    {
        private T value;

        public GenericClass(T value)
        {
            this.value = value;
        }

        public void GMethod()
        {
            Console.WriteLine("GMethod implementation in GenericClass");
            Console.WriteLine("Value: " + value);
        }
    }
}
