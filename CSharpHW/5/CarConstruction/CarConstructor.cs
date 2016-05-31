using System;

namespace CarConstruction
{
    static class CarConstructor
    {
        static public Car Construct(Engine carEngine, Color carColor, Transmission carTransmission)
        {
            return new Car(carEngine, carColor, carTransmission);
        }
        static public void Reconstruct(ref Car car, Engine newEngine)
        {
            car.CarEngine = newEngine;
        }
    }
}
