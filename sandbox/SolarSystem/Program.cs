using System;

class Program
{
    static void Main(string[] args)
    {
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.343;

        Planet venius = new Planet();
        venius._name = "Venius";
        venius._diameter = 1234.343;

        Planet earth = new Planet();
        earth._name = "Earth";
        earth._diameter = 1234.343;
        
        SolarSystem solarSystem = new SolarSystem();
        
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venius);
        solarSystem._solarSystem.Add(earth);
        
        solarSystem.DisaplySolarSystem();

    }
}