using System;

namespace SOLIDPrinciple.ConsoleApp.InterfaceSegregation
{
    /*
     * IAnimalAction is generic action.
     */

    public interface IAnimalAction
    {
        public string Flying();
        public string Barking();
        public string Swimming();
    }

    public class Dog : IAnimalAction
    {
        /*
         * because dog can not fly and living water, but Dog inhert from IAnimalAction. 
         * the bed way is only keeping the fly() method, Swimming() method and throw new NotImplementedException(); not recommend 100%          
        */
        public string Flying()
        {
            //throw new NotImplementedException("Dog can not fly.");
            return "---------Dog not implemented---------------";
        }

        public string Barking()
        {
            return "Dog barking.";
        }

        public string Swimming()
        {
            //throw new NotImplementedException("Dog can not living in the river.");
            return "--------Dog not implemented----------------";
        }
    }

    public class Bird : IAnimalAction    
    {
        /*
         * Bird can not barking and swimming, but it inherit from IAnimalAction
         * so, it has same problem with Dog
         */

        public string Flying()
        {
            return "Bird flying";
        }

        public string Barking()
        {
            //throw new NotImplementedException("Bird can not barking.");
            return "---------Bird not implemented---------------";
        }
        
        public string Swimming()
        {
            //throw new NotImplementedException("Bird can not swimming.");
            return "---------Bird not implemented---------------";
        }
    }
}
