using System;
using System.Diagnostics;// used for Process at Single responsibility principle.
using SOLIDPrinciple.ConsoleApp.SingleResponsibility;
using SOLIDPrinciple.ConsoleApp.OpenClosed;
using SOLIDPrinciple.ConsoleApp.LiskovSubstitution;
using SOLIDPrinciple.ConsoleApp.InterfaceSegregation;

using BirdWithoutPrinciple = SOLIDPrinciple.ConsoleApp.InterfaceSegregation.Bird;

namespace SOLIDPrinciple.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("********* Single responsibility principle ***********");

            var order = new Order();

            for (int i = 0; i < 5; i++)
            {
                order.AddItem(new Item(i + 1, $"Item No.{i + 1}"));
            }

            Console.WriteLine("Creat order and add Items:");
            Console.WriteLine(order.ToString());
            Console.WriteLine("----Finish create order and add items----");

            var path = @"C:\P\Temps\Order.txt";
            Console.WriteLine($"Save as {path}");
            Manage.SaveAsTextFile(order, path);

            //Process.Start(new ProcessStartInfo()
            //{
            //    UseShellExecute = false,
            //    FileName = @"C:\WINDOWS\system32\notepad.exe",
            //    Arguments = path

            //});

            Console.WriteLine("********* Finish Single responsibility principle ***********");

            Console.WriteLine("********* Open closed principle ***********");

            Console.WriteLine("Create car with simply factory");
            Console.WriteLine($"Create toyota car: {CarFactory.CreateCar("Toyota")}");
            Console.WriteLine($"Create honda car: {CarFactory.CreateCar("Honda")}");

            Console.WriteLine("------------------------------");

            Console.WriteLine("Create car with abstract factory");

            Console.WriteLine($"Create toyota car: {new ToyotaCar()}");
            Console.WriteLine($"Create toyota car: {new HondaCar()}");

            Console.WriteLine("********* Finish Open closed principle ***********");

            
            Console.WriteLine("********* Liskov substitution principle ***********");

            var sparrow = new Sparrow("sparrow");
            var ostrich = new Ostrich("ostrich");

            Console.WriteLine(sparrow.Chirp());
            Console.WriteLine(sparrow.Fly());

            Console.WriteLine(ostrich.Run());

            //In here, ostrich have fly method of Bird class because inherit.
            Console.WriteLine(ostrich.Fly()); // it's impossible at real world.

            Console.WriteLine("------------------------------");

            Console.WriteLine("Follow by Liskov substitution principle");

            var sparrowWithLiskov = new SparrowWithLiskov("sparrow");
            var ostrichWithLiskov = new OstrichWithLiskov("ostrich");

            Console.WriteLine(sparrowWithLiskov.Chirp());
            Console.WriteLine(sparrowWithLiskov.Fly());

            Console.WriteLine(ostrichWithLiskov.Run());

            //Console.WriteLine(ostrichWithLiskov.Fly()); ostrichWithLiskov havn't fly() method.


            Console.WriteLine("********* Finish Liskov substitution principle ***********");


            Console.WriteLine("********* Interface segregation principle ***********");

            Console.WriteLine("Not follow by interface segregation principle.");

            var dog = new Dog();            

            Console.WriteLine(dog.Barking());
            Console.WriteLine(dog.Flying()); // throw execption
            Console.WriteLine(dog.Swimming()); // throw execption

            var bird = new BirdWithoutPrinciple();

            Console.WriteLine(bird.Barking()); // throw execption
            Console.WriteLine(bird.Flying());
            Console.WriteLine(bird.Swimming()); // throw execption

            Console.WriteLine("------------------------------");
            Console.WriteLine("follow by interface segregation principle.");

            var dogWithPrinciple = new DogWithPrinciple();
            var birdWithPrinciple = new BirdWithPrinciple();
            var fishWithPrinciple = new FishWithPrinciple();

            Console.WriteLine(dogWithPrinciple.Barking());
            Console.WriteLine(birdWithPrinciple.Flying());
            Console.WriteLine(fishWithPrinciple.Swimming());

            Console.WriteLine("********* Finish Interface segregation principle ***********");


            Console.ReadLine();
        }
    }
}
