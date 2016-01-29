using System;
using System.Collections.Generic;

namespace BussinessL.Models
{
    public partial class Raspunsuri
    {
        public int ID_intrebare { get; set; }
        public string Var_raspuns { get; set; }
        public int Corect { get; set; }
        public virtual Intrebari Intrebari { get; set; }
    }
}
