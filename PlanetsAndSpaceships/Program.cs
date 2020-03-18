using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            //2.
            List<string> remainingPlanets = new List<string> { "Uranus", "Neptune"};
            //3.
            planetList.AddRange(remainingPlanets);
            //4.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            //.5
            planetList.Add("Pluto");
            string planetsAndPluto = string.Join(", ", planetList.ToArray());
            Console.WriteLine(planetsAndPluto);
            //6.
            List<string> rockyPlanets = new List<string>();
            var rockys = planetList.GetRange(0, 4);
            // not sure if the line below needs to be included as part of the extraction instructions
            // planetList.RemoveRange(0, 4);
            rockyPlanets.AddRange(rockys);
            string hereComeTheRockys = string.Join(", ", rockyPlanets.ToArray());
            Console.WriteLine(hereComeTheRockys);
            //7.
            planetList.Remove("Pluto");
            string planetsMinusPluto = string.Join(", ", planetList.ToArray());
            Console.WriteLine(planetsMinusPluto);


            //-----------------------------------------------------------------------------------
            //Iterating Over Planets
            //-----------------------------------------------------------------------------------


        }
    }
}
