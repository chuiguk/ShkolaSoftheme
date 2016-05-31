using System;


namespace CarConstruction
{
    class Car
    {
        public Engine CarEngine { get; set; }
        public Color CarColor { get; set; }
        public Transmission CarTransmission { get; set; }
        public Car(Engine carEngine, Color carColor, Transmission carTransmission)
        {
            this.CarEngine = carEngine;
            this.CarColor = carColor;
            this.CarTransmission = carTransmission;
        }
    }
}
