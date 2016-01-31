using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BussinessL.Models;
using BussinessL;
using DataL.Models;
using DataL;


namespace WebApplication1
{
    public partial class StartQuiz : System.Web.UI.Page
    {
        Bussiness b = new Bussiness();
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
            Response.Redirect("StartTest.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            var temp = b.getMaterii();
            foreach (var aux in temp)
            {
                ListBox1.Items.Add(aux.materie.ToString());
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            var temp = b.getProfesori();
            foreach (var aux in temp)
            {
                ListBox2.Items.Add(aux.Nume.ToString());
            }
        }
    }
}