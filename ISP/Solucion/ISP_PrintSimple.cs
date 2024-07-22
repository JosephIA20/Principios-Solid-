

namespace Ejmplos1.ISP.Solucion
{
    public class ISP_PrintSimple : IISPPrintSimple
    {
        /// <summary>
        /// //Esta clase esta usando la interfaz IISPPrintSimple, la cual solo esta usando un método que es propio 
        /// de esta misma clase
        /// y como es una impresora simple, no tiene el porque implementar un método de scanner 
        /// ya que  esta impresora no lo utiliza 
        /// cumpliendo con el principio abierto cerrado de manera correcta
        /// </summary>
        /// <param name="IISPPrintSimple"></param>
        public void print(ISPDocument Doc)
        {
            Console.WriteLine($"Impriendo un documento{Doc.NameISP} con la descripcion de:{Doc.DescriptionISP}");
        }
    }
}
