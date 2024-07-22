
using System.Reflection.Metadata;

namespace Ejmplos1.ISP.Solucion
{
    /// <summary>
    /// El princio de segregacion de Interfaces establece:
    /// 
    /// Una clase nunca debe extender de interfaces con métodos que no usa
    /// </summary>
    public interface IISPPrintSimple //Esta interfaz existe solo para una Impresora simple la cual solo imprime hojas

    {
        public abstract void print(ISPDocument Doc);
    }


    /// <summary>
    /// Esta interfaz aplica para una impresora multifuncional que aparte de imprimir 
    /// tambien scanea 
    /// </summary>
    public interface IISPMultiFunctionPrinter 
    {
        public void Scan();
    }
}
