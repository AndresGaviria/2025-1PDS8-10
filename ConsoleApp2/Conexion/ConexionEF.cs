using ConsoleApp2.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Conexion
{
    public class ConexionEF
    {        
        private string string_conexion = "server=localhost;database=db_clase11032025;Integrated Security=True;TrustServerCertificate=true;";
        // server=localhost;database=db_clase11032025;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_clase11032025;Integrated Security=True;TrustServerCertificate=true;

        public void ConexionBasica()
        {
            var conexion = new Conexion();
            conexion.StringConnection = this.string_conexion;
        
            var lista_estados = conexion.Estados.ToList();

            foreach (var estado in lista_estados)
            {
                Console.WriteLine(estado.Id.ToString() + "|" + estado.Nombre);
            }
        }
    }

    public partial class Conexion : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Estados>? Estados { get; set; }
    }
}