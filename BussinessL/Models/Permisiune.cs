using System;
using System.Collections.Generic;

namespace BussinessL.Models
{
    public partial class Permisiune
    {
        public Permisiune()
        {
            this.Roluri_Permisiuni = new List<Roluri_Permisiuni>();
        }

        public int ID { get; set; }
        public string Permisiune1 { get; set; }
        public virtual ICollection<Roluri_Permisiuni> Roluri_Permisiuni { get; set; }
    }
}
