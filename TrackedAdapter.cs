using System;

namespace LabWork
{
    // Adapter: перетворює IWheeledTractor на ITrackedTractor
    public class TrackedAdapter : ITrackedTractor
    {
        private readonly IWheeledTractor wheeledTractor;
        private readonly int trackLength;

        public TrackedAdapter(IWheeledTractor wheeledTractor, int trackLength)
        {
            this.wheeledTractor = wheeledTractor ?? throw new ArgumentNullException(nameof(wheeledTractor));
            this.trackLength = trackLength;
        }

        public int TrackLength => trackLength;

        // Перенаправляємо потужність від базового трактора
        public int HorsePower => wheeledTractor.HorsePower;

        public void Move()
        {
            Console.WriteLine($"Adapter: converting wheeled tractor ({wheeledTractor.WheelCount} wheels) to tracked with track length {trackLength}.");
            Console.WriteLine($"Adapter: using {HorsePower} hp on tracks.");
            // Можемо повторно використати методи об'єкта-джерела
            wheeledTractor.Drive();
            Console.WriteLine("Adapter: Now moving as a tracked tractor.");
        }
    }
}
