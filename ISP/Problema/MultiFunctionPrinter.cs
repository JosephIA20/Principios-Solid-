

namespace Ejmplos1.ISP.Problema
{
    public class MultiFunctionPrinter : IPrint
    {
        //La implementacion de la interfaz en esta clase si aplica para usar todos los metodos
        //ya que esta clase es una impresora multifuncional que puede imprimir y Scannear
        public void print(Document doc)
        {
            Console.WriteLine($"Imprimiendo un documento{doc.Description} con el nombre {doc.Name}");
        }

        public void Scan()
        {
            Console.WriteLine("Scaneando un documento de nombre");
        }
    }
}
