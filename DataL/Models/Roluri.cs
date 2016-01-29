using System;
using System.Collections.Generic;

namespace DataL.Models
{
    public partial class Roluri
    {
        public Roluri()
        {
            this.Roluri_Permisiuni = new List<Roluri_Permisiuni>();
            this.Users = new List<User>();
        }

        public int ID { get; set; }
        public string Rol { get; set; }
        public virtual ICollection<Roluri_Permisiuni> Roluri_Permisiuni { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
