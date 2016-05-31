using System;


namespace CarConstruction
{
    class Engine
    {
        public string Model { get; private set; }
        public string Power { get; private set; }
        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
        }
    }
}
