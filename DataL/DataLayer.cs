using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataL.Models;
using System.Data;
using System.Data.SqlClient;


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

        public IEnumerable<User> getUser()
        {
            using (var context = new ProiectContext())
            {
                var query = (from n in context.Users select n).ToList<User>();
                return query;
            }
        }

        public int getIDMaterie(string nume_materie)
        {
            using (var context = new ProiectContext())
            {
                Int32 query = (from n in context.Materiis
                               where n.materie == nume_materie
                               select n.ID).FirstOrDefault();
                return query;

            }
        }

        public int getIDIntrebare(string intrebare)
        {
            using (var context = new ProiectContext())
            {
                Int32 query = (from n in context.Intrebaris
                               where n.Intrebare == intrebare
                               select n.ID).FirstOrDefault();
                return query;
            }
        }
        public bool InsertIntrebare(string intrebare, string numeMaterie)
        {
            int id = getIDMaterie(numeMaterie);
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Proiect;Integrated Security=SSPI");
            conn.Open();
            using (conn)
            {
                //insert Intrebare, ID_materie
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"insert into Intrebari(Intrebare,ID_materie) 
                                    values (@paramIntrebare,@paramID_materie)";

                cmd.Parameters.AddWithValue("@paramIntrebare", intrebare);
                cmd.Parameters.AddWithValue("@paramID_materie", id);

                try
                {
                    // conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                catch (SqlException d)
                {
                    conn.Close();
                    return false;
                }
            }
        }

        public bool InsertRaspuns(string intrebare, string raspuns, bool ifCorrect)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Proiect;Integrated Security=SSPI");
            conn.Open();
            int idIntrebare = getIDIntrebare(intrebare);
            SqlCommand cmdR = new SqlCommand();
            cmdR.Connection = conn;
            cmdR.CommandType = CommandType.Text;

            // first answer
            cmdR.CommandText = @"insert into Raspunsuri(ID_intrebare,Var_raspuns,Corect) 
                                    values (@paramID_intrebare,@paramRaspuns,@paramCorect)";
            cmdR.Parameters.AddWithValue("@paramID_intrebare", idIntrebare);
            cmdR.Parameters.AddWithValue("@paramRaspuns", raspuns);
            if (ifCorrect == true)
            {
                cmdR.Parameters.AddWithValue("@paramCorect", 1);
            }
            else
            {
                cmdR.Parameters.AddWithValue("@paramCorect", 0);
            }

            try
            {
                cmdR.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException d)
            {
                conn.Close();
                return false;
            }

        }
    }
}
