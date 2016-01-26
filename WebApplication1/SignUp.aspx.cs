using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox3.PasswordChar = "*";
             //TextBox4.Visible =false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Proiect;Integrated Security=SSPI");

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

                string nume=TextBox1.Text.ToString()+" "+TextBox2.Text.ToString();
                string username=TextBox3.Text.ToString();
                string passwd="student";
                if(TextBox4.Text.ToString()==TextBox5.Text.ToString())
                {
                passwd=TextBox4.Text.ToString();
                }
                else{
                MessageBox.Show("Passwords do not match!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Response.Redirect("SignUp.aspx");
                
                }
                int rol=3;
                if(CheckBox1.Checked==true)
                {
                    rol= 3;
                }
                else if(CheckBox2.Checked==true)
                {
                   rol = 2;
                }
                else {
                MessageBox.Show("Please check all options", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Response.Redirect("SignUp.aspx");

                }

                string queryString =
                   "INSERT into dbo.[User](Nume, Username,Parola, ID_rol) VALUES (@Nume,@Username,@Passwd,@Rol);";
                
                using (conn)
                {
                   SqlCommand command1 = new SqlCommand(queryString, conn);
                    command1.Parameters.Add("@Nume",nume);
                    command1.Parameters.Add("@Username",username);
                    command1.Parameters.Add("@Passwd",passwd);
                    command1.Parameters.Add("@Rol",rol);



                  var insert= command1.ExecuteNonQuery();
                  if (insert == 1)
                  {
                      MessageBox.Show("Success! Account created! Please Log In");
                      Response.Redirect("Login.aspx");

                  }
                }
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}