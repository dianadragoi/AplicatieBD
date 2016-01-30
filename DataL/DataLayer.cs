using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL.Models;

namespace DataL
{
    public class DataLayer
    {

        public IEnumerable<Materii> getMat()
        {
            using (var context = new ProiectContext())
            {
                var query = (from n in context.Materiis
                            select n).ToList<Materii>();
                return query;
            }
        }

        public IEnumerable<User> getProf()
        {
            using (var context = new ProiectContext())
            {
                var query = (from n in context.Users
                             where n.ID_rol == 2
                             select n).ToList<User>();
                return query;
            }
        }

        public IEnumerable<Intrebari> getIntr()
        {
            using (var context = new ProiectContext())
            {
                var query = (from n in context.Intrebaris
                             select n).ToList<Intrebari>();
                return query;
            }
        }

        public Intrebari getIntr(int i)
        {
            var temp = this.getIntr().ToList<Intrebari>();
            return temp[i];
        }

        public IEnumerable<Raspunsuri> getRasp(int id_intr)
        {
            using (var context = new ProiectContext())
            {
                var query = (from n in context.Raspunsuris
                             where n.ID_intrebare == id_intr
                             select n).ToList<Raspunsuri>();
                return query;
            }
        }
    }
}
