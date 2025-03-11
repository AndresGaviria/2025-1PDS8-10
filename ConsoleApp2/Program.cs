using ConsoleApp2.Modelos;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

TiposPersonajes tipo = new TiposPersonajes();
var tipo2 = new TiposPersonajes(1,"Real");
Console.WriteLine(tipo2.nombre);

TiposPersonajes tipo3 = new TiposPersonajes() { id=2,nombre="Ficticio"};
Console.WriteLine(tipo3.nombre);

Personajes personaje = new Personajes()
{
    id=4,
    nombre="Carlos",
    fecha=DateTime.Now,
    tamaño=100,
    vivo=true,
    tipo=tipo3
};
string nom="Carlos";

var personaje2= new Personajes()
{
    id=4,
    nombre= nom,
    fecha=DateTime.Now,
    tamaño=100,
    vivo=true,
    tipo= new TiposPersonajes(3,"Animado")
};
Console.WriteLine(personaje2.tipo.nombre);