using System;


namespace CarConstruction
{
    enum TransmissionType
    {
        Auto, Manual
    }
    class Transmission
    {
        public TransmissionType TransmissionName { get; private set; }
        public Transmission(TransmissionType transmissionName)
        {
            this.TransmissionName = transmissionName;
        }
    }
}
