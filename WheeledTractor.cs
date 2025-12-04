using System;

namespace LabWork
{
    public class WheeledTractor : IWheeledTractor
    {
        private int wheelCount;
        private int horsePower;

        public WheeledTractor(int wheelCount, int horsePower)
        {
            this.wheelCount = wheelCount;
            this.horsePower = horsePower;
        }

        // Encapsulated properties expose only what is needed
        public int WheelCount => wheelCount;
        public int HorsePower => horsePower;

        public void Drive()
        {
            Console.WriteLine($"Wheeled tractor driving with {wheelCount} wheels and {horsePower} hp.");
        }

        // Example of an internal operation that is encapsulated
        public void InflateTires()
        {
            Console.WriteLine("Inflating tires...");
        }
    }
}
