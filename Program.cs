namespace DuplicateCities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<State> states = new List<State>(){
    new State ()
    {
        Name = "St1",
        Districts = new List<District>()
        {
            new District()
            {
                Name = "dist1",
                Cities = new List<string>()
                {
                    "city1",
                    "city2"
                }
            },
            new District()
            {
                Name = "dist2",
                Cities = new List<string>()
                {
                    "city3",
                    "city4"
                }
            }
        }
    },
    new State ()
    {
        Name = "St2",
        Districts = new List<District>()
        {
            new District()
            {
                Name = "dist3",
                Cities = new List<string>()
                {
                    "city1",
                    "city5"
                }
            },
            new District()
            {
                Name = "dist4",
                Cities = new List<string>()
                {
                    "city6",
                    "city7"
                }
            }
        }
    }
};
            var listOfCities = new List<string>();
            foreach (var state in states)
            {
               
                foreach(var district in state.Districts)
                {
                    foreach (var city in district.Cities)
                    {
                        Console.WriteLine($"{state.Name}-{district.Name}-{city}");
                        listOfCities.Add(city);
                    }
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < listOfCities.Count; i++)
            {
                for (int j = i + 1; j < listOfCities.Count - 1; j++)
                {
                    if (listOfCities[j] == listOfCities[i])
                    {
                        Console.WriteLine(listOfCities[j]);
                    }
                }
            }
            foreach(var district in states.Select(x => x.Districts).ToList())
            {

            }
        }
    }
    public class State
    {
        public string Name { get; set; }
        public List<District> Districts { get; set; }
    }
    public class District
    {
        public string Name { get; set; }
        public List<string> Cities { get; set; }
    }


}