using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BussinessL;

namespace WebApplication1
{
    public partial class Teste : System.Web.UI.Page
    {
        Bussiness b = new Bussiness();
        private static int i = 0;
        private static int lenghtIntr = 0;
        private static int punctaj = 0;
        private static bool CheckedPressed = false;
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckedPressed = true;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckedPressed = true;
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckedPressed = true;
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckedPressed = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Start
            Label1.Visible = true;
            Label4.Visible = false;
            CheckBox1.Visible = true;
            CheckBox2.Visible = true;
            CheckBox3.Visible = true;
            CheckBox4.Visible = true;
            Button1.Visible = false;
            Button4.Visible = true;

            counter(); //cate intrebari sunt
            AfisareIntrRasp(i);
            i++;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
        }

        private void AfisareIntrRasp(int i)
        {
            var intr = b.getIntrebare(i);
            Label1.Text = intr.Intrebare.ToString();
            var temp2 = b.getRaspuns(intr.ID);
            CheckBox1.Text = temp2[0].Var_raspuns.ToString();
            CheckBox2.Text = temp2[1].Var_raspuns.ToString();
            CheckBox3.Text = temp2[2].Var_raspuns.ToString();
            CheckBox4.Text = temp2[3].Var_raspuns.ToString();
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            //Next question

            if (CheckedPressed == false)
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = "Nu ai raspuns!!";
            }
            else
            {
                
                Calcul_punctaj();
                Label3.Text = "Punctaj: " + punctaj + "/" + lenghtIntr;
                Label2.Text = " ";
                if (i < lenghtIntr)
                {
                    AfisareIntrRasp(i);
                    i++;
                    
                    
                }
                else
                {
                    Label3.Text = " ";
                    Label1.Text = "Ai terminat! Punctaj : " + punctaj;
                    CheckBox1.Visible = false;
                    CheckBox2.Visible = false;
                    CheckBox3.Visible = false;
                    CheckBox4.Visible = false;
                    Button1.Visible = false;

                }
                CheckedPressed = false;
            }
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
        }

        private void Calcul_punctaj()
        {
            var temp = b.getRaspuns(i);
            if (CheckBox1.Checked == true)
            {
                if (temp[0].Corect.Equals(1))
                    if (CheckBox2.Checked == false && CheckBox3.Checked == false && CheckBox4.Checked == false)
                    {
                        punctaj++;
                        return;
                    }
            }
            else
                if (CheckBox2.Checked == true)
                {
                    if (temp[1].Corect.Equals(1))
                    {
                        if (/*CheckBox1.Checked == false &&*/ CheckBox3.Checked == false && CheckBox4.Checked == false)
                            punctaj++;
                    }
                }
                else
                    if (CheckBox3.Checked == true)
                    {
                        if (temp[2].Corect.Equals(1))
                        {
                            if (/*CheckBox2.Checked == false && CheckBox1.Checked == false &&*/ CheckBox4.Checked == false)
                                punctaj++;
                        }
                    }
                    else
                        if (CheckBox4.Checked = true)
                        {
                            if (temp[3].Corect.Equals(1))
                            {
                                //if (CheckBox2.Checked == false && CheckBox3.Checked == false && CheckBox1.Checked == false)
                                punctaj++;
                            }
                        }
                            //else { }

            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
        }

        private void counter()
        {
            lenghtIntr = b.getIntrebari().Count();
        }



 

    }
}