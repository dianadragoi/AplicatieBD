using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;


namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Proiect;Integrated Security=SSPI");

            conn.Open();
           // TextBox1.Text = conn.State.ToString();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine(Environment.NewLine);
                string queryString =
                 "SELECT Username, Parola FROM dbo.[User];";
                using (conn)
                {
                    SqlCommand command = new SqlCommand(queryString, conn);
                    SqlDataReader intr = command.ExecuteReader();
                    int econt = 0;
                    
                    while (intr.Read())
                    { 
                       if (TextBox1.Text.ToString() == intr["Username"].ToString() && TextBox2.Text.ToString() == intr["Parola"].ToString())
                       {
                            Response.Redirect("StartQuiz.aspx");
                           econt = 1;
                       }
                      // MessageBox.Show(intr["Parola"].ToString());
                    }
                    if (econt == 0)
                    {
                        MessageBox.Show("Please retry or create an account!", "Incorrect username or password",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }


        }

        protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
        {
           
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            string textBody;
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Proiect;Integrated Security=SSPI");

            conn.Open();
           // TextBox1.Text = conn.State.ToString();
            if (conn.State == ConnectionState.Open)
            {
                string nume = TextBox4.Text.ToString();
                string queryString1 =
                     "SELECT Username, Parola FROM dbo.[User] WHERE Nume=@1;";
                
                using (conn)
                {
                    SqlCommand command1 = new SqlCommand(queryString1, conn);
                    command1.Parameters.Add("@1", nume);
                    SqlDataReader intr = command1.ExecuteReader();
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Timeout = 100000;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("quizzapplication@gmail.com", "platformaverificare");
                    MailMessage msg = new MailMessage();
                    msg.To.Add(new MailAddress(TextBox3.Text, ToString()));
                    msg.From = new MailAddress("quizzapplication@gmail.com");
                    msg.Subject = "Authentification";

                    while (intr.Read())
                    {

                        textBody = "Datele de autentificare pentru aplicatia Platforma de verificare pentru licenta:  Username: " + intr["Username"] + " Parola: " + intr["Parola"];
                        msg.Body = textBody;

                    }
                    client.Send(msg);
                    MessageBox.Show("Successfully Sent Message.");
                }


            }
        }
    }
    
}