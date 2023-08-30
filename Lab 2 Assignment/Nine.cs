using System;
namespace Lab29
{
    class Vehicle
    {
        void StartEngine()
        {
            Console.WriteLine("Engine is starting");
        }
        void StopEngine()
        {
            Console.WriteLine("Engine is stoping");
        }
    }
    sealed class Car : Vehicle
    {
        void show()
        {
            Console.WriteLine("This is Car class");
        }
    }
    class MainClass : Car
    {

    }
}