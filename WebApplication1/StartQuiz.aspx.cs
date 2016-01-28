using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class StartQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.MaintainScrollPositionOnPostBack = true;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teste.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Proiect;Integrated Security=SSPI");
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine(Environment.NewLine);
                string queryString = "Select materie FROM Materii;";
                using (conn)
                {
                    SqlCommand command = new SqlCommand(queryString, conn);
                    SqlDataReader intr = command.ExecuteReader();
                    while (intr.Read())
                    {
                        this.ListBox1.Items.Add(intr["materie"].ToString());
                        //this.ListBox1.Items.ToString();
                    }
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}