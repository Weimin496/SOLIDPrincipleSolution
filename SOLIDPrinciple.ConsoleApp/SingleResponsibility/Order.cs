using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SOLIDPrinciple.ConsoleApp.SingleResponsibility
{
    /* 
     * At Order class, it include property Items, additem(), RemoveItem(), override ToString() and SaveAsTextFile() method.
     * if we look at this class, Additem(), RemoveItem() are responsible with Items. SaveAsTextFile() method is managing Items.
     * so Order class responsibilize not only keeping Items, but also managing it. we don't have only one reason to change this clase,(keeping items and managing item.)
     * follow by Single responsiblity principle, we can seperate SaveAsTextFile() into another class.
    */


    public class Order
    {
        public List<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            if (Items.Any(i => i.Id == item.Id))
            {
                Items.RemoveAt(Items.IndexOf(item));
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Items);
        }

        //public void SaveAsTextFile(string pathWithFileName)
        //{
        //    File.WriteAllText(pathWithFileName, ToString());
        //}
    }

    public class Manage
    {
        public void SaveAsTextFile(Order order, string pathWithFileName)
        {
            if (File.Exists(pathWithFileName))
            {
                File.Delete(pathWithFileName);
            }

            File.WriteAllText(pathWithFileName, order.ToString());
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
