using System;

class SolarSystem
{
    public List<Planet> _solarSystem = new List<Planet>();

    public void DisaplySolarSystem()
    {
        foreach (Planet p in _solarSystem)
        {
            p.DisplayPlanetInformation();
        }
    }
}
