using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp2.Modelos
{
    public class Instrumentos
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("Tipo")] public Tipos? _Tipo { get; set; }
    }
}