﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public delegate void CarEngineHandler(string msgForCaller);
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        private bool carIsDead;

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
                if (Exploded != null)
                {
                    Exploded("Sorry, this car is dead. X_X");
                }
            }
            else
            {
                CurrentSpeed = +change;
            }

            if (10 == (MaxSpeed - CurrentSpeed) && AboutToBlow != null)
            {
                AboutToBlow("Careful, nearly maxed out.");
            }

            if (CurrentSpeed >= MaxSpeed)
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
