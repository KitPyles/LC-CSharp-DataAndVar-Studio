using System;

class MainClass
{
    public static void Main(string[] args)
    {

        // Declare and initialize the 12 variables here:
        string date = "Monday 2019-03-18";
        string time = "10:05:34 AM";
        int astronautCount = 7;
        string astronautStatus = "ready";
        double averageAstronautMassKg = 80.7;
        double crewMassKg;
        int fuelMassKg = 760000;
        double shuttleMassKg = 74842.31;
        double totalMassKg;
        int fuelTempCelsius = -225;
        string fuelLevel = "100%";
        string weatherStatus = "clear";
        string divider = "-------------------------------------";

        // Write code to generate the LC04 report here:
        Console.WriteLine("Please, enter the number of astronauts: ");
        astronautCount = Int32.Parse(Console.ReadLine());
        crewMassKg = astronautCount * averageAstronautMassKg;
        totalMassKg = crewMassKg + fuelMassKg + shuttleMassKg;
        Console.WriteLine(divider);
        Console.WriteLine("> LC04 - LAUNCH CHECKLIST");
        Console.WriteLine(divider);
        Console.WriteLine("Date: " + date);
        Console.WriteLine("Time: " + time);
        Console.WriteLine("");
        Console.WriteLine(divider);
        Console.WriteLine("> ASTRONAUT INFO");
        Console.WriteLine(divider);
        Console.WriteLine("* count: " + astronautCount);
        Console.WriteLine("* status: " + astronautStatus);
        Console.WriteLine("");
        Console.WriteLine(divider);
        Console.WriteLine("> FUEL DATA");
        Console.WriteLine(divider);
        Console.WriteLine("* Fuel temp celsius: " + fuelTempCelsius + " C");
        Console.WriteLine("* Fuel level: " + fuelLevel,
          "");
        Console.WriteLine("");
        Console.WriteLine(divider);
        Console.WriteLine("> MASS DATA");
        Console.WriteLine(divider);
        Console.WriteLine("* Crew mass: " + crewMassKg + " kg");
        Console.WriteLine("* Fuel mass: " + fuelMassKg + " kg");
        Console.WriteLine("* Shuttle mass: " + shuttleMassKg + " kg");
        Console.WriteLine("* Total mass: " + totalMassKg + " kg");
        Console.WriteLine("");
        Console.WriteLine(divider);
        Console.WriteLine("> FLIGHT PLAN");
        Console.WriteLine(divider);
        Console.WriteLine("* weather: " + weatherStatus);
        Console.WriteLine("");
        Console.WriteLine(divider);
        Console.WriteLine("> OVERALL STATUS");
        Console.WriteLine(divider);
        Console.WriteLine("* Clear for takeoff: YES");

        // When done, have your TA check your code.





        // BONUS: Use ReadLine to prompt the user to enter the number of astronauts going on the mission.






    }
}