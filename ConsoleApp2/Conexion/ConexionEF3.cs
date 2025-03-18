using ConsoleApp2.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Conexion
{
    public class ConexionEF3
    {
        private string string_conexion = "server=localhost;database=db_instrumentos;Integrated Security=True;TrustServerCertificate=true;";
        // server=localhost;database=db_instrumentos;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_instrumentos;Integrated Security=True;TrustServerCertificate=true;

        public void ConexionBasica()
        {
            var conexion = new Conexion3();
            conexion.StringConnection = this.string_conexion;

            var lista = conexion.Instrumentos!.ToList();

            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento.Id.ToString() + ", " + 
                    elemento.Codigo + ", " + 
                    elemento.Nombre + ", " + 
                    elemento.Cantidad.ToString() + ", " + 
                    elemento.Fecha.ToString() + ", " + 
                    elemento.Tipo.ToString() + ", " + 
                    elemento.Activo.ToString());
            }
        }

        public void ConexionInsert()
        {
            var conexion = new Conexion2();
            conexion.StringConnection = this.string_conexion;

            var juego = new Juegos();
            juego.Codigo = "54654651";
            juego.Nombre = "Mario Bros";
            juego.NumCopias = 100;
            juego.Fecha = DateTime.Now;
            juego.Categoria = 2;
            juego.Activo = false;

            conexion.Juegos!.Add(juego);
            conexion.SaveChanges();
        }
    }

    public class Conexion3 : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Tipos>? Tipos { get; set; }
        public DbSet<Instrumentos>? Instrumentos { get; set; }
    }
}