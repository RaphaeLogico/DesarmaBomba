using System;
using System.Collections.Generic;
using System.Linq;
using DesarmaBomba.Models;

namespace DesarmaBomba.Functions
{
    public class Acoes
    {
        public List<Fio> Carrega()
        {
            var Fios = new List<Fio>();

            Fios.Add(
                new Fio
                {
                    Seq = 1,
                    Cor = "Branco",
                    Explode = false
                }
            );


            Fios.Add(
                new Fio
                {
                    Seq = 2,
                    Cor = "Vermelho",
                    Explode = false
                }
            );

            Fios.Add(
                new Fio
                {
                    Seq = 3,
                    Cor = "Preto",
                    Explode = false
                }
            );

            Fios.Add(
                new Fio
                {
                    Seq = 4,
                    Cor = "Laranja",
                    Explode = false
                }
            );

            Fios.Add(
                new Fio
                {
                    Seq = 5,
                    Cor = "Verde",
                    Explode = false
                }
            );

            Fios.Add(
                new Fio
                {
                    Seq = 6,
                    Cor = "Roxo",
                    Explode = false
                }
            );

            return Fios;
        }

        public bool Corta(int fio, List<Fio> Fios)
        {
            if (Fios.Where(x => x.Seq == fio).FirstOrDefault().Explode)
            {
                Console.WriteLine("     _.-^^---....,,--      ");
                Console.WriteLine(" _--                  --_  ");
                Console.WriteLine("<                        >)");
                Console.WriteLine("|                         |");
                Console.WriteLine(" L._                   _./ ");
                Console.WriteLine("    ```--. . , ; .--'''    ");
                Console.WriteLine("          | |   |          ");
                Console.WriteLine("       .-=||  | |=-.   ");
                Console.WriteLine("       `-=#$%&%$#=-'   ");
                Console.WriteLine("          | ;  :|     ");
                Console.WriteLine(" _____.,-#%&$@%#&#~,._____");

                Console.WriteLine("Explodiu!!!!");
                return true;
            }

            Fios.RemoveAt(Fios.IndexOf(Fios.Where(x => x.Seq == fio).FirstOrDefault()));
            // Fios.Remove(new Fio(){Seq=fio});

            switch (fio)
            {
                case 1:
                    Fios.ForEach(c => c.Explode = false);
                    Fios.Where(x => x.Cor == "Preto").ToList().ForEach(c => c.Explode = true);
                    break;
                case 2:
                    Fios.ForEach(c => c.Explode = false);
                    Fios.Where(x => x.Cor != "Verde").ToList().ForEach(c => c.Explode = true);
                    break;
                case 3:
                    Fios.ForEach(c => c.Explode = false);
                    Fios.Where(x => x.Cor == "Verde" || x.Cor == "Branco" || x.Cor == "Laranja").ToList().ForEach(c => c.Explode = true);
                    break;
                case 4:
                    Fios.ForEach(c => c.Explode = false);
                    Fios.Where(x => x.Cor != "Vermelho" && x.Cor != "Preto").ToList().ForEach(c => c.Explode = true);
                    break;
                case 5:
                    Fios.ForEach(c => c.Explode = false);
                    Fios.Where(x => x.Cor != "Laranja" && x.Cor != "Branco").ToList().ForEach(c => c.Explode = true);
                    break;
                case 6:
                    Fios.ForEach(c => c.Explode = false);
                    Fios.Where(x => x.Cor != "Vermelho" && x.Cor != "Preto").ToList().ForEach(c => c.Explode = true);
                    break;

            }

            return false;

        }

        public void Desarma(List<Fio> Fios)
        {
            var Acoes = new Acoes();
            bool explodiu = false;

            while (!explodiu)
            {
                System.Console.WriteLine("Digite o numero de um fio para cortar: ");
                foreach (var item in Fios)
                {
                    System.Console.WriteLine($"{item.Seq} - {item.Cor}");
                }

                var resposta = Console.ReadLine();

                bool conv = Int32.TryParse(resposta, out int fio);
                if (conv && (Fios.Where(x => x.Seq == fio).Count() == 1))
                {
                    explodiu = Acoes.Corta(fio, Fios);
                }
                else
                {
                    System.Console.WriteLine("Escolher nº entre as opções listadas.");
                }
                if (Fios.Count() == 0)
                {
                    System.Console.WriteLine("Bomba desarmada!!!!");
                    Console.WriteLine("                                                         c=====e");
                    Console.WriteLine("                               ''''''                       H   ");
                    Console.WriteLine("   ____________                `     ,                  _,,_H__ ");
                    Console.WriteLine("  (__((__((___()               |    |                  //|     |");
                    Console.WriteLine(" (__((__((___()()_______________*  *__________________// |ACME |");
                    Console.WriteLine("(__((__((___()()()---------------  -------------------'  |_____|");
                    return;                    
                }

            }


        }
    }


}