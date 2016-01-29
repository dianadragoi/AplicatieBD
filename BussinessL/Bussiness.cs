using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL;
using DataL.Models;


namespace BussinessL
{
    public class Bussiness
    {
        DataLayer dt = new DataLayer();

        public List<Materii> getMaterii()
        {
            var temp = dt.getMat().ToList<Materii>();
            return temp;
        }
        public List<User> getProfesori()
        {
            var temp = dt.getProf().ToList<User>();
            return temp;

        }
        public List<Intrebari> getIntrebari()
        {
            var temp = dt.getIntr().ToList<Intrebari>();
            return temp;
        }
        public List<Raspunsuri> getRaspuns(int id_intr)
        {
            var temp = dt.getRasp(id_intr).ToList<Raspunsuri>();
            return temp;
        }
    }
}
