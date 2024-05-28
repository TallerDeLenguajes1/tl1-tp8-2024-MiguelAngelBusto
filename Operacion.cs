
namespace EspacioCalculadora;



public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacionElegida;

    public double ResultadoAnterior
    {
        get => resultadoAnterior;
        set => resultadoAnterior = value;
    }
    public double NuevoValor
    {
        get => nuevoValor;
        set => nuevoValor = value;
    }
    public TipoOperacion OperacionElegida { get => operacionElegida; set => operacionElegida = value; }

    public double Resultado()
    {
        switch (operacionElegida)
        {
            case TipoOperacion.Suma:
                return resultadoAnterior + nuevoValor;
                break;
            case TipoOperacion.Resta:
                return resultadoAnterior - nuevoValor;
                break;
            case TipoOperacion.Multiplicacion:
                return resultadoAnterior * nuevoValor;
                break;
            case TipoOperacion.Division:
                if (nuevoValor != 0)
                {
                    return resultadoAnterior / nuevoValor;
                }
                else
                {
                    return 0;
                }
                break;
            default:
                return 0;
        }
    }
}