//exterior
//interior
//comfort
//safety
//media

namespace Lab3Creational
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            var sclass = new Sclass();
            var econom = new Econom();

            var factory = new CarFactory();
            var builders = new List<CarBuilder> { sclass, econom };

            foreach(var b in builders)
            {
                var c = factory.Build(b);
                Console.WriteLine("Car details: \nName: {0}\nExterior: {1}\nInterior: {2}\nComfort: {3}\nSafety: {4}\nMedia: {5}\n", c.Name, c.Exterior, c.Interior, c.Comfort, c.Safety, c.Media);
            }
        }
    }

}