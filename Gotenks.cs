public class Gotenks : Fusion
{
    public Gotenks(Personaje personaje1, Personaje personaje2) : base(personaje1.ObtenerNombre() + " + " + personaje2.ObtenerNombre(), personaje1, personaje2)
    {
    }
}