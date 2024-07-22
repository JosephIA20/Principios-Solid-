

using Ejmplos1.ISP.Problema;

namespace Ejmplos1.ISP.Solucion    //Joseph ALmanzar 2023-0696
{
    /// <summary>
    /// Como existe la multi Herencia en la interfaces es posible utilizas las interfaz 
    /// que quieras implementar en tu clase
    /// y no obligar a tu clase a utilizar metodo no son propios de si mismo 
    /// </summary>
    public class ISPMultiFunctionPrinter : IISPMultiFunctionPrinter,IISPPrintSimple
    {
        public void print(ISPDocument d)
        {
            Console.WriteLine($"Impriendo un documento {d.NameISP} con el nombre {d.DescriptionISP}");
        }

        public void Scan()
        {
            Console.WriteLine("Scanneando mi documento");
        }


    }
}
