// LectorDirectorio

using System;
using System.IO;
string path;
bool existe = false;

do
{
    Console.WriteLine("Ingrese el path del directorio:");
    path = Console.ReadLine();
    existe = Directory.Exists(path);

    if (!existe)
    {
        Console.WriteLine("El directorio no existe. Por favor, ingrese un path válido.");
    }

} while (!existe);

Console.WriteLine($"\n📁 Directorio: {path}");

string[] directorios = Directory.GetDirectories(path);

foreach (var directorio in directorios)
{
    System.Console.WriteLine($"├── 📁 {directorio}");
}

Console.WriteLine("Ingrese el nombre del directorio a listar:");