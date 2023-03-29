using System;

namespace LearningDotNetFramework.classes
{
    public class Vehicle
    {
        private string brand;

        public Vehicle()
        {
            this.brand = "Ford";
        }
        
        public string Brand
        {
            get => brand;
            set => brand = value;
        }

        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    public class Car : Vehicle
    {
        private string modelName;

        public Car(string modelName)
        {
            this.modelName = modelName;
        }

        public string ModelName
        {
            get => modelName;
            set => modelName = value;
        }

        public static void Run()
        {
            Car car = new Car("Mustang");
            car.honk();

            Console.WriteLine("Brand: {0}, ModelName: {1}", car.Brand, car.modelName);

        }
    }

    //cannot be inherited
    public sealed class SVehicle
    {
        
    }
}