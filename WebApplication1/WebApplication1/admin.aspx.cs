using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            connetionString = ConfigurationManager.ConnectionStrings["crud_opConnectionString"].ConnectionString;

            SqlConnection sqlConnection = new SqlConnection(connetionString);
            string selectQuery = "select id,name,email,age,gender,contact,department,designation,hobby from Employees where id <> 1 and isDelete = 0";
            sqlConnection.Open();

            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Email");
            table.Columns.Add("age");
            table.Columns.Add("gender");
            table.Columns.Add("contact");
            table.Columns.Add("department");
            table.Columns.Add("designation");
            table.Columns.Add("hobby");



            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                table.Rows.Add($"{reader["id"].ToString()}", $"{reader["name"].ToString()}", $"{reader["email"].ToString()}", $"{reader["age"].ToString()}", $"{reader["gender"].ToString()}", $"{reader["contact"].ToString()}", $"{reader["department"].ToString()}", $"{reader["designation"].ToString()}", $"{reader["hobby"].ToString()}");
            }
            reader.Close();

            DataGrid1.DataSource = table;
            DataGrid1.DataBind();



            //SqlDataAdapter sqladapter = new SqlDataAdapter(selectQuery,sqlConnection);
            //DataSet ds = new DataSet();
            //sqladapter.Fill(ds);
            //DataGrid1.DataSource = ds;
            //DataGrid1.DataBind();



            sqlConnection.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Numebr.Text);

            string connetionString;
            connetionString = ConfigurationManager.ConnectionStrings["crud_opConnectionString"].ConnectionString;


            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();

            string deleteQuery = $"update Employees set isDelete = 1 where id = {id}";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
            deleteCommand.ExecuteNonQuery();

            Numebr.Text = "";
            conn.Close();
            Response.Redirect("admin.aspx");

        }
        protected void Submit_Id(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NumberEdit.Text);

            string connetionString;
            connetionString = ConfigurationManager.ConnectionStrings["crud_opConnectionString"].ConnectionString;


            SqlConnection conn = new SqlConnection(connetionString);
            conn.Open();

            string selectQuery = $"select name,email,age,gender,contact,department,designation,hobby from Employees where id = {id} and isDelete = 0";


            SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
            SqlDataReader reader = selectCommand.ExecuteReader();
            string department = "" ;
            while (reader.Read())
            {
                Name.Text = reader["name"].ToString();
                Email.Text =  reader["email"].ToString();
                Age.Text =  reader["age"].ToString();

                string hobby1 = reader["hobby"].ToString();
                string[] arr = hobby1.Split(',');

               for(int i=0;i<arr.Length; i++)
                {
                    if (arr[i]=="Programming")
                    {
                        Programming.Checked = true;
                    }
                    if (arr[i]=="Gaming")
                    {
                        Gaming.Checked = true;
                    }
                    if (arr[i]=="Music")
                    {
                        Music.Checked = true;
                    }
                    if (arr[i]=="Walking")
                    {
                        Walking.Checked = true;
                    }
                    if (arr[i]=="Running")
                    {
                        Running.Checked = true;
                    }
                    if (arr[i]=="Dancing")
                    {
                        Dancing.Checked = true;
                    }
                    if (arr[i]=="Coding")
                    {
                        Coding.Checked = true;
                    }
                    if (arr[i]=="Acting")
                    {
                        Acting.Checked = true;
                    }
                    if (arr[i]=="Movies")
                    {
                        Movies.Checked = true;
                    }
                    if (arr[i]=="Travelling")
                    {
                        Travelling.Checked = true;
                    }
                    if (arr[i]=="Reading")
                    {
                        Reading.Checked = true;
                    }

                }

                if (reader["gender"].ToString() == "male")
                {
                    RadioButton1.Checked = true;

                }else if(reader["gender"].ToString() == "female"){
                    RadioButton1.Checked = true;

                }
                else
                {
                    RadioButton1.Checked = true;

                }
                department = reader["department"].ToString();
                Conatct.Text =  reader["contact"].ToString();

                Desingnation.Text =   reader["designation"].ToString();
            }
            if (department == "Marketing")
            {
                Marketing.Selected = true;
                Development.Selected = false;
                Bussiness.Selected = false;
                QA.Selected = false;
                HR.Selected = false;
            }
            else if (department =="Development")
            {
                Marketing.Selected = false;
                Development.Selected = true;
                Bussiness.Selected = false;
                QA.Selected = false;
                HR.Selected = false;
            }
            else if (department =="Bussiness Analysis")
            {
                Marketing.Selected = false;
                Development.Selected = false;
                Bussiness.Selected = true;
                QA.Selected = false;
                HR.Selected = false;
            }
            else if (department =="QA")
            {
                Marketing.Selected = false;
                Development.Selected = false;
                Bussiness.Selected = false;
                QA.Selected = true;
                HR.Selected = false;
            }
            else if (department =="HR")
            {
                Marketing.Selected = false;
                Development.Selected = false;
                Bussiness.Selected = false;
                QA.Selected = false;
                HR.Selected = true;
            }
         
            reader.Close();
            conn.Close();
        }
        protected void Update_Id(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NumberEdit.Text) ;
            string name = Name.Text;
            string email = Email.Text;
            int age = Convert.ToInt32(Age.Text);
            string gender = "";
            if (RadioButton1.Checked)
            {
                gender = "male";
            }else if(RadioButton2.Checked)
            {
                gender = "female";
            }
            else
            {
                gender = "other";
            }

            string hobby = "";
            if (Programming.Checked)
            {
                hobby += Programming.Text;
                hobby += ",";
            }
            if (Gaming.Checked)
            {
                hobby += Gaming.Text;
                hobby += ",";
            }
            if (Music.Checked)
            {
                hobby += Music.Text;
                hobby += ",";
            }
            if (Reading.Checked)
            {
                hobby += Reading.Text;
                hobby += ",";
            }
            if (Walking.Checked)
            {
                hobby += Walking.Text;
                hobby += ",";
            }
            if (Running.Checked)
            {
                hobby += Running.Text;
                hobby += ",";
            }
            if (Dancing.Checked)
            {
                hobby += Dancing.Text;
                hobby += ",";
            }
            if (Coding.Checked)
            {
                hobby += Coding.Text;
                hobby += ",";
            }
            if (Acting.Checked)
            {
                hobby += Acting.Text;
                hobby += ",";
            }
            if (Movies.Checked)
            {
                hobby += Movies.Text;
                hobby += ",";
            }
            if (Travelling.Checked)
            {
                hobby += Travelling.Text;
                hobby += ",";
            }

            string contact = Conatct.Text;
            string department = Department.SelectedValue;
            string designation = Desingnation.Text;

            string connetionString;
            connetionString = ConfigurationManager.ConnectionStrings["crud_opConnectionString"].ConnectionString;
           

            SqlConnection conn = new SqlConnection(connetionString);

            string updateQuery = $"update Employees set name= '{name}',email = '{email}' ,age = {age},gender = '{gender}',contact={contact},department='{department}',designation='{designation}',hobby='{hobby}' where id= {id} ";
            conn.Open();
            Response.Write($"<script>console.log('{updateQuery}')</script>");

            Response.Write( updateQuery );
            SqlCommand updateCommand = new SqlCommand(updateQuery, conn);

            updateCommand.ExecuteNonQuery();

            conn.Close();

            Response.Redirect("admin.aspx");





        }

    }
}