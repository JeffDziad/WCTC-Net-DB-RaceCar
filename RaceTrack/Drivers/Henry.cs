using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Henry : Driver
    {
        public Henry(RaceCar car) : base(car)
        {
            Name = "Henry Ford";
            SkillLevel = 7;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    } 
}