using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public delegate void CarEngineHandler(string msgForCaller);
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;
        public CarEngineHandler listOfHandlers { get; set; }

        public Car()
        {
            MaxSpeed = 100;
        }
        public Car(string name, int maxspeed, int currentspeed)
        {
            PetName = name;
            MaxSpeed = maxspeed;
            CurrentSpeed = currentspeed;
        }

        public void Accelerate(int change)
        {
            if (carIsDead)
            {
                if(listOfHandlers != null)
                {
                    listOfHandlers("Sorry, this car is dead. X_X");
                }
            }
            else
            {
                CurrentSpeed = +change;
            }

            if( 10==(MaxSpeed-CurrentSpeed) &&listOfHandlers != null)
            {
                listOfHandlers("Careful, nearly maxed out.");
            }

            if(CurrentSpeed >= MaxSpeed)
            {
                carIsDead = true;
            }
            else
            {
                Console.WriteLine($"Current speed: {CurrentSpeed}.");
            }
        }
    }
}
