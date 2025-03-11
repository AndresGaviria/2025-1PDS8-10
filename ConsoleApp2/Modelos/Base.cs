namespace ConsoleApp2.Modelos
{
    public class TiposPersonajes
    {
        public int id;
        public string? nombre = null;

        public TiposPersonajes()
        {

        }

        public TiposPersonajes(int id, string? nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }

    public class Personajes
    {
        public int id;
        public string? nombre = null;
        public DateTime fecha;
        public double tamaño;
        public bool vivo;
        public TiposPersonajes? tipo;
    }
}