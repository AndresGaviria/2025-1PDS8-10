using ConsoleApp2.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Conexion
{
    public class ConexionEF2
    {
        private string string_conexion = "server=localhost;database=db_video_juegos;Integrated Security=True;TrustServerCertificate=true;";
        // server=localhost;database=db_video_juegos;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_video_juegos;Integrated Security=True;TrustServerCertificate=true;

        public void ConexionBasica()
        {
            var conexion = new Conexion2();
            conexion.StringConnection = this.string_conexion;

            var lista = conexion.Juegos!.ToList();

            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento.Id.ToString() + ", " + elemento.Nombre);
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

    public class Conexion2 : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Categorias>? Categorias { get; set; }
        public DbSet<Juegos>? Juegos { get; set; }
    }
}