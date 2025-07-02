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

DirectoryInfo directory = new DirectoryInfo(path);
FileInfo[] files = directory.GetFiles();
List<string> lineasCombinadas = new List<string>();
lineasCombinadas.Add("Nombre , Tamaño , UltimoAcceso");
foreach (FileInfo file in files)
{
    Console.WriteLine($"Nombre: {file.Name}, Tamaño: {file.Length} bytes");
    lineasCombinadas.Add($"{file.Name},{file.Length},{file.LastAccessTime:dd-MM-yyyy HH:mm:ss}");
}
string rutaParaGuardar = Path.Combine(path, "reporte_archivos.csv");
File.WriteAllLines(rutaParaGuardar, lineasCombinadas);