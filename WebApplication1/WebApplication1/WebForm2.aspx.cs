using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{

    class WebFromCrud
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int age { get; set; }
        public string Contact { get; set; }

        public string Password { get; set; }

        public string Cpass { get; set; }
    }
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebFromCrud obj = new WebFromCrud();
            string connectionString = "Data Source=DESKTOP-TKKISTV;Initial Catalog=crud_op;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            obj.Name = Name.Text;
            obj.Email = Email.Text;
            obj.age  =Convert.ToInt32(Age.Text);
            obj.Contact = Conatct.Text;
            obj.Password = Pass.Text;
            obj.Cpass = Cpass.Text;

            string insertQuery = $"insert into webformcrud (name,email,age,contact,password) values ('{obj.Name}','{obj.Email}',{obj.age},{obj.Contact},'{obj.Password}')";
        
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);

            insertCommand.ExecuteNonQuery();
    
            sqlConnection.Close();
            Label9.Text = "data insert sucessfully";
            Name.Text = "";
            Email.Text = "" ;
            Age.Text =  ""; 
            Conatct.Text = "";
            Pass.Text = ""  ;
            Cpass.Text = "" ;

            Response.Redirect("vj");
        }
    }
}