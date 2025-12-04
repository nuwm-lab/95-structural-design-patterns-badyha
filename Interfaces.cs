using System;

namespace LabWork
{
    public interface IWheeledTractor
    {
        void Drive();
        int WheelCount { get; }
        int HorsePower { get; }
    }

    public interface ITrackedTractor
    {
        void Move();
        int TrackLength { get; }
        int HorsePower { get; }
    }
}
