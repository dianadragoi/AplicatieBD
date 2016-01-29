using System;
using System.Collections.Generic;

namespace BussinessL.Models
{
    public partial class Roluri_Permisiuni
    {
        public int ID { get; set; }
        public int ID_rol { get; set; }
        public int ID_permisiune { get; set; }
        public virtual Permisiune Permisiune { get; set; }
        public virtual Roluri Roluri { get; set; }
    }
}
