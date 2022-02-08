namespace SOLIDPrinciple.ConsoleApp.OpenClosed
{
    /*
     * This is a factory design pattern, it doesn't broke open closed principle. 
     * when you have a new car, you create another car factory.
     */

    public interface IAbstractFactory
    {
        Car Create();
    }

    public class ToyotaFactory : IAbstractFactory
    {
        public Car Create()
        {
            return new ToyotaCar();
        }
    }

    public class HondaFactory : IAbstractFactory
    {
        public Car Create()
        {
            return new HondaCar();
        }
    }

    //..
}
