

namespace Ejmplos1.ISP.Problema
{
    public interface IPrint
    {
        // Esta interfaz no esta mal pero obliga a todo las clases que la implementen a utilizar sus métodos
        // El cual quizás no sea necesario utilizar dependiendo la clase 
        public void print(Document doc);
        public abstract void Scan();
    }
}
