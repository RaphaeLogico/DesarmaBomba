using System;
using DesarmaBomba.Functions;

namespace DesarmaBomba
{
    class Program
    {
        static void Main(string[] args)
        {
            var Acoes = new Acoes();

            var Fios = Acoes.Carrega();

            Console.WriteLine("                                                         c=====e");
            Console.WriteLine("                                                            H   ");
            Console.WriteLine("   ____________                                         _,,_H__ ");
            Console.WriteLine("  (__((__((___()                                       //|     |");
            Console.WriteLine(" (__((__((___()()_____________________________________// |ACME |");
            Console.WriteLine("(__((__((___()()()------------------------------------'  |_____|");

            Acoes.Desarma(Fios);
            Console.ReadKey();
        }

    }
}
