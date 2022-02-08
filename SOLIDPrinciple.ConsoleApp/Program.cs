﻿using System;
using System.Diagnostics;
using SOLIDPrinciple.ConsoleApp.SingleResponsibility;
using SOLIDPrinciple.ConsoleApp.OpenClosed;

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

            Console.ReadLine();
        }
    }
}
