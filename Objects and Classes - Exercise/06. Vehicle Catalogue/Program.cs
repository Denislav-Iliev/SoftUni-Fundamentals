
class Program
{
    static void Main()
    {
        List<Vehicle> catalogue = new List<Vehicle>();

        string command = "";
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();
            catalogue.Add(new Vehicle(arguments[0], arguments[1], arguments[2], decimal.Parse(arguments[3])));
        }
        command = "";
        while (( command = Console.ReadLine()) != "Close the Catalogue")
        {
            string modelName = command;

            Vehicle foundVehicle = catalogue.FirstOrDefault(v => v.Model == modelName);
            if (foundVehicle != null)
            {
                Console.WriteLine(foundVehicle.ToString());
            }
        }
        decimal average = Average(catalogue, "Car");
        Console.WriteLine($"Cars have average horsepower of: {average:F2}.");
        average = Average(catalogue, "Truck");
        Console.WriteLine($"Trucks have average horsepower of: {average:F2}.");
    }

    private static decimal Average(List<Vehicle> catalogue, string type)
    {
        return catalogue.Where(vehicle => vehicle.Type == type).Select(vehicle => vehicle.HorsePower).DefaultIfEmpty().Average();
    }
}
public class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal HorsePower { get; set; }
    public Vehicle(string type, string model, string color, decimal horsePower)
    {
        Type = type == "car" ? "Car" : "Truck";
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }
    public override string ToString()
    {
        return $"Type: {Type}\n" + $"Model: {Model}\n" + $"Color: {Color}\n" + $"Horsepower: {HorsePower}";
    }
}