using System;
using System.Collections.Generic;

namespace DesarmaBomba.Models
{
    public class Fio
    {        
        public int Seq { get; set; }
        public string Cor { get; set; }
        public bool Explode { get; set; }

    }

    public class Fios<Fio>
    {
         public List<Fio> Cabos { get; set; }

  
    }


}