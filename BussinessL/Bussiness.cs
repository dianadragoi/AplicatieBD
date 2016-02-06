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

        public Intrebari getIntrebare(int i)
        {
            var temp = dt.getIntr(i);
            return temp;
        }
        public List<Raspunsuri> getRaspuns(int id_intr)
        {
            var temp = dt.getRasp(id_intr).ToList<Raspunsuri>();
            return temp;
        }

        public List<User> getUser()
        {
            var temp = dt.getUser().ToList<User>();
            return temp;

        }

        //public int getIDMaterie(string nume_materie)
        //{
        //    int id = dt.getIDMaterie(nume_materie);
        //    return id;
        //}

        public bool InsertIntrebare(string intrebare, string numeMaterie)
        {
            return dt.InsertIntrebare(intrebare, numeMaterie);
        }

        public bool InsertRaspuns(string intrebare, string raspuns, bool ifCorrect)
        {
            return dt.InsertRaspuns(intrebare, raspuns, ifCorrect);
        }

        public int getIDIntrebare(string intrebare)
        {
            int idIntrebare = dt.getIDIntrebare(intrebare);
            return idIntrebare;
        }

        public bool delete_intrebare(string intr)
        {
            return dt.delete_intrebare(intr);
        }

        public bool delete_raspunsuri(string intr)
        {
            return dt.delete_raspunsuri(intr);
        }
    }

}
