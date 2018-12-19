using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Elevator
    {
        private readonly double MaxWeight;
        private readonly Passenger[] Occupant;
        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupant = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            this.Occupant[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double sumOfWeight = 0;
            for (int i = 0; i < this.Occupant.Length; i++)
            {
                sumOfWeight = sumOfWeight + this.Occupant[i].GetWeight();
            }
            return sumOfWeight;
        }
        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > this.MaxWeight;
        }

    }
}
