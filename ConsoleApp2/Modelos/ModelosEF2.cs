using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Modelos
{
    public class Categorias
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
    }

    public class Juegos
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int NumCopias { get; set; }
        public DateTime Fecha { get; set; }
        public int Categoria { get; set; }
        public bool Activo { get; set; }
        public string? Personajes { get; set; }

        [ForeignKey("Categoria")] public Categorias? _Categoria { get; set; }
    }
}