public class Program {
    public static void Main()
    {
        Goku goku = new Goku();
        Vegeta vegeta = new Vegeta();
        Gohan gohan = new Gohan();
        Trunks trunks = new Trunks();
  
        Console.WriteLine("Nombre de los personajes:");
        Console.WriteLine(goku.ObtenerNombre());    // Goku
        Console.WriteLine(vegeta.ObtenerNombre());  // Vegeta
        Console.WriteLine(gohan.ObtenerNombre());   // Gohan
        Console.WriteLine(trunks.ObtenerNombre());  // Trunks
  
        DecoradorGogeta gogeta = new DecoradorGogeta (goku, vegeta);
        DecoradorGotenks gotenks = new DecoradorGotenks (gohan, trunks);
  
        Console.WriteLine("\nNombres de las fusiones:");
        Console.WriteLine(gogeta.ObtenerNombre());  // GokuVegeta => Gogeta
        Console.WriteLine(gotenks.ObtenerNombre()); // GohanTrunks => Gotenks
    }
}