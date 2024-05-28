using System.Net.Sockets;
using System.Runtime.CompilerServices;
namespace EspacioCalculadora;

class Calculadora
{
    private double dato;
    private List<Operacion> operaciones;

    public Calculadora()
    {
        this.dato = 0;
        this.operaciones = new List<Operacion>();
    }

    public void Sumar(double x)
    {

        TipoOperacion a = TipoOperacion.Suma;
        if (operaciones.Count != 0)
        {
            // int b = operaciones.Count-1;
            Operacion aux = new Operacion();
            aux.NuevoValor = x;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = this.dato;
            operaciones.Add(aux);
        }
        else
        {
            Operacion aux = new Operacion();
            aux.NuevoValor = x;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = 0;
            operaciones.Add(aux);
        }
        this.dato = this.dato + x;
    }
    public void Restar(double x)
    {

        TipoOperacion a = TipoOperacion.Resta;
        if (operaciones.Count != 0)
        {
            // int b = operaciones.Count-1;
            Operacion aux = new Operacion();
            aux.NuevoValor = x;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = this.dato;
            operaciones.Add(aux);
        }
        else
        {
            Operacion aux = new Operacion();
            aux.NuevoValor = x;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = 0;
            operaciones.Add(aux);
        }
        this.dato = this.dato - x;
    }
    public void Multiplicar(double x)
    {

        TipoOperacion a = TipoOperacion.Multiplicacion;
        if (operaciones.Count != 0)
        {
            // int b = operaciones.Count-1;
            Operacion aux = new Operacion();
            aux.NuevoValor = x;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = this.dato;
            operaciones.Add(aux);

        }
        else
        {
            Operacion aux = new Operacion();
            aux.NuevoValor = x;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = 0;
            operaciones.Add(aux);
        }
        this.dato = this.dato * x;
    }
    public void Dividir(double y)
    {
        if (y != 0)
        {
            TipoOperacion a = TipoOperacion.Division;
            if (operaciones.Count != 0)
            {
                // int b = operaciones.Count-1;
                Operacion aux = new Operacion();
                aux.NuevoValor = y;
                aux.OperacionElegida = a;
                aux.ResultadoAnterior = this.dato;
                operaciones.Add(aux);
            }
            else
            {
                Operacion aux = new Operacion();
                aux.NuevoValor = y;
                aux.OperacionElegida = a;
                aux.ResultadoAnterior = 0;
                operaciones.Add(aux);
            }
            this.dato = this.dato / y;
        }
        else
        {
            Console.WriteLine("No se pueden hacer diviciones en 0");
        }
    }
    public void Limpiar()
    {
        this.dato = 0;
        TipoOperacion a = TipoOperacion.Limpiar;
        if (operaciones.Count != 0)
        {
            // int b = operaciones.Count-1;
            Operacion aux = new Operacion();
            aux.NuevoValor = 0;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = this.dato;
            operaciones.Add(aux);
        }
        else
        {
            Operacion aux = new Operacion();
            aux.NuevoValor = 0;
            aux.OperacionElegida = a;
            aux.ResultadoAnterior = 0;

        }
    }

    public void MostrarLista()
    {
        for (int i = 0; i < operaciones.Count; i++)
        {
            Console.WriteLine(i + ")" + operaciones[i].OperacionElegida.ToString() + " : " + operaciones[i].Resultado());
        }
    }
}