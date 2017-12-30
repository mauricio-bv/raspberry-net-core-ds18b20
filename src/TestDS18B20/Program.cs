using System;
using LibraryDS18B20;
using System.Threading;

namespace TestDS18B20
{
    class Program
    {

        static void ReadTemperature()
        {
            while (true)
            {
                int temperature = DS18B20.GetTemperature("28-031662b19cff");

                Console.WriteLine(string.Format("Temperature: {0}", temperature.ToString()));
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {

            Thread thread = new Thread(new ThreadStart(ReadTemperature));
            thread.Start();

        }
    }
}