namespace SOLIDPrinciple.ConsoleApp.LiskovSubstitution
{
    public class OstrichWithLiskov : IBird
    {
        public string Name { get; set; }

        public OstrichWithLiskov(string name)
        {
            Name = name;
        }

        public string Run()
        {
            return $"{Name} run fast.";
        }
    }

    public class SparrowWithLiskov : IFly
    {
        public string Name { get; set; }

        public SparrowWithLiskov(string name)
        {
            Name = name;
        }

        public string Fly()
        {
            return $"{Name} is flying";
        }

        public string Chirp()
        {
            return $"{Name} is chirping.";
        }
    }

    public interface IBird
    {
        string Name { get; set; }
    }

    public interface IFly : IBird
    {
        string Fly();
    }
}
