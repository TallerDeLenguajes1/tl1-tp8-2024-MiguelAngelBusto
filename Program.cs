// See https://aka.ms/new-console-template for more information
using EspacioTarea;
using System;

List<Tarea> pendientes = new List<Tarea>();
List<Tarea> realizadas = new List<Tarea>();

Console.WriteLine("Ingrese la cantidad de Tareas que desea que haya: ");
string x = Console.ReadLine();
int n;
int.TryParse(x, out n);
for (int i = 0; i < n; i++)
{
    string token = "Tarea" + i;
    int min = 1;
    int max = 60;
    Random rnd = new Random();
    int duracion = rnd.Next(min, max + 1);
    Tarea aux = new Tarea(i, token, duracion);
    pendientes.Add(aux);
    MostrarTarea(pendientes[i]);
}
n = 1;
while (n != 0)
{
    Console.WriteLine("Desea Pasar una tarea pendiente a una tarea realizada? (0 para No Cualquier otro Numero para si)");
    n = Ingresar();
    if (n != 0)
    {
        Console.WriteLine("A continuacion ingrese un ID");
        int id = Ingresar();
        for (int h = 0; h < pendientes.Count; h++)
        {
            if (id == pendientes[h].TareaID)
            {
                realizadas.Add(pendientes[h]);
                Tarea aux = pendientes[h];
                h = pendientes.Count + 1;
                pendientes.Remove(aux);
            }
        }
    }
}
Console.WriteLine("---------------Lista de Pendientes-----------");
MostrarLista(pendientes);
Console.WriteLine("---------------Lista de Realizadas-----------");
MostrarLista(realizadas);

n = 1;
while (n != 0)
{
    Console.WriteLine("Desea buscar una tarea por descripcion? (0 para No Cualquier otro Numero para si)");
    n = Ingresar();
    if (n != 0)
    {
        Console.WriteLine("A continuacion ingrese una posible descripcion");
        string cadena = Console.ReadLine();
        for (int h = 0; h < pendientes.Count; h++)
        {
            if (pendientes[h].Descripcion.Contains(cadena))
            {
                MostrarTarea(pendientes[h]);
            }
        }
    }
}

void MostrarTarea(Tarea x)
{
    Console.WriteLine("TareaID:" + x.TareaID + "\nDescripcion: " + x.Descripcion + "\nDuracion: " + x.Duracion);
}

int Ingresar()
{
    Console.WriteLine("Ingrese un numero: ");
    string x = Console.ReadLine();
    int n;
    int.TryParse(x, out n);
    return n;
}

void MostrarLista(List<Tarea> x)
{
    for (int i = 0; i < x.Count; i++)
    {
        MostrarTarea(x[i]);
    }
}