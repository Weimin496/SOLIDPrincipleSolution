using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.ConsoleApp.LiskovSubstitution
{
    /*
     * Bird class is base class of Eagle and Ostrich, fly() method is base class, when Eagle and Ostrich inherit from Brid.
     * The Liskov substitution principle is subtype must be able to replace their base types(anywhere, anytime). but Ostrich can not fly.
     * 
     * There are 2 ways to fixed this problem.
     * 1. we can add validate (if or switch). but this way will broken open close principle.
     * 2. we can create IFly interface and IBird interface.
     */

    public class Bird
    {
        public string Name { get; set; }

        public Bird(string name)
        {
            Name = name;
        }

        public string Fly()
        {
            return $"{Name} is flying";
        }
    }

    public class Sparrow : Bird
    {
        public Sparrow(string Name):
            base(Name)
        {

        }

        public string Chirp()
        {
            return $"{Name} is chirping.";
        }
    }

    public class Ostrich : Bird
    {
        public Ostrich(string name) 
            : base(name)
        {
        }

        public string Run()
        {
            return $"{Name} run fast.";
        }        
    }

}
