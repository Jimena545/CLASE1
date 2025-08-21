// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Personas persona = new Personas();
persona.id = 1;
persona.nombre = "Maria Rodriguez";
persona.estatura = 1.60;
persona.vive = false;
persona.fecha = datetime.now;
persona.Estado = new Estados() { id = 1, nombre = "viudo"};

public class Estados
{
    public int id;
    public string? nombre;
}
public class Personas
{
    public int id;
    public string? nombre;
    public int estatura;
    public bool vive;
    public datetime fecha;
    public Estados? Estado;
}

public class Estudiantes : Personas
{

    public string? Carnet;
}
