using System;
using System.Collections.Generic;

namespace BussinessL.Models
{
    public partial class User
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Username { get; set; }
        public string Parola { get; set; }
        public int ID_rol { get; set; }
        public Nullable<int> ID_materie { get; set; }
        public virtual Materii Materii { get; set; }
        public virtual Roluri Roluri { get; set; }
    }
}
