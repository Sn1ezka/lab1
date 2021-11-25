using System;

namespace Lab1
{
    public static class Comparison{
        public static string BestCarByTechParams(Car first, Car second)
        {
            int firstCounter = 0;
            int secondCounter = 0;

            if(first.MaximumAcceleration > second.MaximumAcceleration)
            {
                firstCounter+=1;
            }
            else
            {
                secondCounter+=1;
            }

            if(first.FuelForOneHundredKm > second.FuelForOneHundredKm)
            {
                firstCounter+=1;
            }
            else
            {
                secondCounter+=1;
            }

            if(first.HoldingCapacity > second.HoldingCapacity)
            {
                firstCounter+=1;
            }
            else
            {
                secondCounter+=1;
            }

            return firstCounter>secondCounter? $"Автомобиль {first.Brand} лучше, чем {second.Brand}" : $"Автомобиль {second.Brand} лучше, чем {first.Brand}";
        }
    }
}