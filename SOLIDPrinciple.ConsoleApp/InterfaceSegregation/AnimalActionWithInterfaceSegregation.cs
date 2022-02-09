namespace SOLIDPrinciple.ConsoleApp.InterfaceSegregation
{

    /*
     * follow by interface segregation principle, we use specific interfaces replace generic inteface.
     */

    public interface IDogAction
    {
        public string Barking();
    }

    public interface IBirdAction
    {
        public string Flying();
    }

    public interface IFishAction
    {
        public string Swimming();
    }

    public class DogWithPrinciple : IDogAction
    {
        public string Barking()
        {
            return "Dog barking.";
        }
    }

    public class BirdWithPrinciple : IBirdAction
    {
        public string Flying()
        {
            return "Bird flying";
        }
    }

    public class FishWithPrinciple : IFishAction
    {
        public string Swimming()
        {
            return "Fish living in the river.";
        }
    }
}
