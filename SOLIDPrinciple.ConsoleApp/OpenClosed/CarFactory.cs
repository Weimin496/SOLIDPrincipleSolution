using System;

namespace SOLIDPrinciple.ConsoleApp.OpenClosed
{

    /*
     * This is a simply factory, it broken the Open closed principle because we open CreateCar method again, when we need to add another new car type. 
     */
    public class CarFactory
    {
        public static Car CreateCar(string typeCar)
        {
            return typeCar switch
            {
                "Toyota" => new ToyotaCar(),
                "Honda" => new HondaCar(),
                _ => throw new ArgumentException("Car type is unknow."),
            };
        }
    }
}
