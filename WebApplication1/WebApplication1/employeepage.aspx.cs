using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class employeepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["User"]);

            string connetionString;
            connetionString = ConfigurationManager.ConnectionStrings["crud_opConnectionString"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connetionString);
            string selectQuery = $"select name,email,age,gender,contact,department,designation from Employees where id= {id} ";
            sqlConnection.Open();
            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                Name.Text = reader["name"].ToString();
                Email.Text =  reader["email"].ToString();
                Age.Text =  reader["age"].ToString();
                Gender.Text =  reader["gender"].ToString();
                Conatct.Text =  reader["contact"].ToString();
                Department.Text =  reader["department"].ToString();
                Desingnation.Text =   reader["designation"].ToString();
            }
            reader.Close();
            sqlConnection.Close();

        }
       
    }
}