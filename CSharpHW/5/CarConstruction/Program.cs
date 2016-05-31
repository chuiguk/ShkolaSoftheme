using System;

namespace CarConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = CarConstructor.Construct(new Engine("X12O31", "200HP"), new Color(Colors.Black), new Transmission(TransmissionType.Auto));
            Console.WriteLine("Car: Engine - {0}, {1}; Color: {2}, Transmission: {3}", car.CarEngine.Model, car.CarEngine.Power,
                                                                                       car.CarColor.ColorName, car.CarTransmission.TransmissionName);
            CarConstructor.Reconstruct(ref car, new Engine("U10L67", "300HP"));
            Console.WriteLine("Reconstructed Car: Engine - {0}, {1}; Color: {2}, Transmission: {3}", car.CarEngine.Model, car.CarEngine.Power,
                                                                                       car.CarColor.ColorName, car.CarTransmission.TransmissionName);
            Console.ReadKey();
        }
    }
}
