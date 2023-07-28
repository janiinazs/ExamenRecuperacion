public class Fusion : Personaje
{
    protected Personaje Personaje1;
    protected Personaje Personaje2;
    public Fusion(string nombreFusion, Personaje personaje1, Personaje personaje2) : base(nombreFusion)
    {
        this.Personaje1 = personaje1;
        this.Personaje2 = personaje2;
    }
}