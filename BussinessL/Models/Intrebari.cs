using System;
using System.Collections.Generic;

namespace BussinessL.Models
{
    public partial class Intrebari
    {
        public Intrebari()
        {
            this.Raspunsuris = new List<Raspunsuri>();
        }

        public int ID { get; set; }
        public string Intrebare { get; set; }
        public int ID_materie { get; set; }
        public virtual Materii Materii { get; set; }
        public virtual ICollection<Raspunsuri> Raspunsuris { get; set; }
    }
}
