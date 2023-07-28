public class DecoradorGogeta : Fusion
{
    public DecoradorGogeta(Personaje personaje1, Personaje personaje2) : base(personaje1, personaje2, $"{personaje1.ObtenerNombre()} + {personaje2.ObtenerNombre()} = Gotenks")
    {
    }
}