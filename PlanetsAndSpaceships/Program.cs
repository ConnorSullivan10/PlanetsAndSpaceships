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
            // 1.
            var satelliteDictionary = new Dictionary<string, List<string>>
            {
                { "Perseid", new List<string> { "Mercury", "Mars", "Venus", "Jupiter" } },
                { "Logos", new List<string> { "Earth", "Venus", "Pluto", "Uranus" } },
                { "Agamemnon", new List<string> { "Mercury", "Saturn", "Neptune", "Jupiter", "Venus" } }

            };
            // 2.
            foreach (var planet in planetList)
            {
                var matchingSatellites = $"{planet}: ";
                foreach (var satellite in satelliteDictionary)
                {
                    if (satellite.Value.Contains(planet))
                    {
                        matchingSatellites += $"{satellite.Key}, ";
                    }
                }
                char[] charToTrim = { ',', ' ' };
                var finalMatchList = matchingSatellites.TrimEnd(charToTrim);
                Console.WriteLine(finalMatchList);
            }
        }
    }
}
