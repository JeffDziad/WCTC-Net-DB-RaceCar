using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ModelT : RaceCar
    {
        public ModelT()
        {
            Name = "Model T";
            TopSpeed = 50;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts up just after a few cranks!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name}'s brakes bring it to a screeching halt!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}'s engine backfires and peters out.");
        }
    }
}