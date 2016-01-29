using System;
using System.Collections.Generic;

namespace DataL.Models
{
    public partial class Materii
    {
        public Materii()
        {
            this.Intrebaris = new List<Intrebari>();
            this.Users = new List<User>();
        }

        public int ID { get; set; }
        public string materie { get; set; }
        public virtual ICollection<Intrebari> Intrebaris { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
