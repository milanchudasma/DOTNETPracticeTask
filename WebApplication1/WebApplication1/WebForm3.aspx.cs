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
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public long Contact { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public string Password { get; set; }
        public string hobby { get; set; }


    }
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {


            if (Name.Text == "" || Email.Text == ""||
           Age.Text == "" ||  Conatct.Text == "" ||
           Department.SelectedValue == "" ||
           Desingnation.Text ==  "" ||
           Pass.Text == "" ||
           Cpass.Text == "" ||  Department.SelectedValue == "")
            {
                Response.Write($"<script>alert('please fill all the value')</script>");
            }
            else
            {
                string connetionString;
                connetionString = ConfigurationManager.ConnectionStrings["crud_opConnectionString"].ConnectionString;
                Response.Write($"<script>alert('{connetionString}')</script>");

                SqlConnection conn = new SqlConnection(connetionString);


                Employee obj = new Employee();
                obj.Name = Name.Text;
                obj.Email = Email.Text;
                obj.Age = Convert.ToInt32(Age.Text);


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
                obj.hobby = hobby;

                Response.Write($"<script> console.log('{hobby}') </script>");
                if (RadioButton1.Checked)
                {

                    obj.Gender = RadioButton1.Text;
                }
                else if (RadioButton2.Checked)
                {
                    obj.Gender = RadioButton2.Text;
                }
                else if (RadioButton3.Checked)
                {
                    obj.Gender = RadioButton3.Text;
                }

                obj.Contact = long.Parse(Conatct.Text);
                obj.Department = Department.SelectedValue;
                obj.Designation = Desingnation.Text;

                if (Pass.Text == Cpass.Text)
                {
                    obj.Password = Pass.Text;

                }


                string insertQuery = $"insert into Employees (name,email,age,gender,contact,department,designation,password,hobby) values('{obj.Name}','{obj.Email}',{obj.Age},'{obj.Gender}',{obj.Contact},'{obj.Department}','{obj.Designation}','{obj.Password}','{obj.hobby}')";

                Response.Write($"<script> console.log('{insertQuery}') </script>");
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
                Name.Text = "";
                Email.Text = "";
                Age.Text = "";

                if (RadioButton1.Checked)
                {

                    RadioButton1.Checked = false;
                }
                else if (RadioButton2.Checked)
                {
                    RadioButton2.Checked = false;

                }
                else if (RadioButton3.Checked)
                {
                    RadioButton3.Checked = false;

                }
                Conatct.Text = "";
                Department.SelectedValue = "";
                Desingnation.Text =  "";


                Pass.Text = "";
                Cpass.Text = "";



                Response.Write($"<script>alert('data insert successfully')</script>");
                Response.Redirect("login.aspx");

            }



        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}