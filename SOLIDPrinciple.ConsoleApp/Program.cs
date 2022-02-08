using System;
using System.Diagnostics;
using SOLIDPrinciple.ConsoleApp.SingleResponsibility;

namespace SOLIDPrinciple.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("********* Single responsibility principle ***********");

            var order = new Order();

            for (int i = 0; i < 5; i++)
            {
                order.AddItem(new Item(i + 1, $"Item No.{i + 1}"));
            }

            Console.WriteLine("Creat order and add Items:");
            Console.WriteLine(order.ToString());
            Console.WriteLine("----Finish create order and add items----");

            var manage = new Manage();
            var path = @"C:\P\Temps\Order.txt";            
            Console.WriteLine($"Save as {path}");
            manage.SaveAsTextFile(order, path);

            Process.Start(new ProcessStartInfo()
            {
                UseShellExecute = false,
                FileName = @"C:\WINDOWS\system32\notepad.exe",
                Arguments = path

            });

            Console.WriteLine("********* Finish Single responsibility principle ***********");

            Console.ReadLine();
        }
    }
}
