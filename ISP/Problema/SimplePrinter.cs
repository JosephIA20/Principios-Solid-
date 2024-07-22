
namespace Ejmplos1.ISP.Problema
{
    public class SimplePrinter : IPrint
    {
        public void print(Document doc)
        {
            Console.WriteLine($"Impriendo un documento {doc.Description} de nombre de {doc.Name}");
        }
        //El problema de este implementacion es que el metodo Scan no debe de ser implementando por una impresora simple 
        public void Scan()
        {
            //Este método no deberia de ser implementado en un impresora simple
        }
    }
}
