﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Bussiness b = new Bussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                refresh();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            // insert intrebare
            b.InsertIntrebare(TextBox1.Text.ToString(), DropDownList1.SelectedItem.ToString());

            // insert raspuns 1
            b.InsertRaspuns(TextBox1.Text.ToString(),
                TextBox2.Text.ToString(),
                CheckBox1.Checked);

            // insert raspuns 2
            b.InsertRaspuns(TextBox1.Text.ToString(),
                TextBox3.Text.ToString(),
                CheckBox2.Checked);

            // insert raspuns 3
            b.InsertRaspuns(TextBox1.Text.ToString(),
                TextBox4.Text.ToString(),
                CheckBox3.Checked);

            // insert raspuns 4
            b.InsertRaspuns(TextBox1.Text.ToString(),
                TextBox5.Text.ToString(),
                CheckBox4.Checked);




            MessageBox.Show("Row inserted !! ");
            refresh();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;



        }


        protected void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            //adaugare in datalist toate intrebarile
            List<DataL.Models.Intrebari> lista_intrebari = b.getIntrebari();
            List<String> intr = new List<string>();

            foreach (var r in lista_intrebari)
            {
                intr.Add(r.Intrebare);
            }
            GridView1.DataSource = intr;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            b.delete_raspunsuri(e.Values[0].ToString());
            b.delete_intrebare(e.Values[0].ToString());
            refresh();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }

}