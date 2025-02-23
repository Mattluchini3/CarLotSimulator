﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //dot notation
            Car car1 = new Car();
            car1.Make = "Mazda";
            car1.Model = "CX-5";
            car1.Year = 2023;
            car1.IsDriveable = true;
            car1.EngineNoise = "vroom vroom";
            car1.HonkNoise = "beep beep";

            //object intializer syntax
            Car car2 = new Car()
            {
                Make = "Toyota",
                Model = "Camry"
            };

            //custom constructor

            Car car3 = new Car(2023, "Ford", "F-150");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
