namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var truck = new Car();
            truck.Make = "Toyota";
            truck.Model = "Tundra";
            truck.Year = 2023;

            truck.Vehicle();
        }
    }
}
