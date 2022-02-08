namespace SOLIDPrinciple.ConsoleApp.OpenClosed
{
    public class Car
    {
    }

    public class ToyotaCar : Car
    {
        public override string ToString()
        {
            return "It's Toyota car.";
        }
    }

    public class HondaCar : Car
    {
        public override string ToString()
        {
            return "It's Honda car.";
        }
    }
}
