using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkRegister(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Email.Text == "" || Pass.Text == "")
            {
                Response.Write($"<script>alert('please fill all the value')</script>");
            }
            else
            {
                string email = Email.Text;
                string password = Pass.Text;

                string connetionString;
                connetionString = ConfigurationManager.ConnectionStrings["crud_opConnectionString"].ConnectionString;
              

                SqlConnection conn = new SqlConnection(connetionString);
                conn.Open();

                string selectQuery = $"select id,password,isAdmin from Employees where email = '{email}'";
               

                SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
                SqlDataReader reader = selectCommand.ExecuteReader();
                string fetchPass = "";
                int IsAdmin = 0 ;
                int id = 0;
                while(reader.Read())
                {

                    fetchPass = reader["password"].ToString();
                    IsAdmin =  Convert.ToInt32(reader["isAdmin"]) ;
                    id = Convert.ToInt32(reader["id"]);
                 
                }
            
                reader.Close();
                if(fetchPass.ToString() == password.ToString())
                {
                    if(email == "chudasmamilan610@gmail.com" &&  IsAdmin == 1)
                    {
                        Response.Write($"<script>alert('login successfully')</script>");
                        Response.Redirect("admin.aspx");
                    }
                    else
                    {
                        Response.Redirect($"employeepage.aspx?User={id}");

                    }

                }
                else
                {
                    Response.Write($"<script>alert('password is incorrect')</script>");
                }

                conn.Close();





            }



        }
    }
}