using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading.Channels;
using System.Net.Mail;
using System.Net;

namespace studentcrud
{
     class demo1
    {
        private protected int id = 1;
        internal void demoMethod()
        {
            Console.WriteLine($"this is private : {this.id}");
        }
        protected string name = "milan";
    }
    interface demo3
    {

    }
    abstract class milan
    {

    }
    class demo2 : demo1,demo3
    {
       internal protected void demo2Method()
        {
            Console.WriteLine(this.id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo1 demo1 = new demo1();
            demo1.demoMethod();
            demo2 demo2 = new demo2();
            demo2.demo2Method();



            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("jamel.hand89@ethereal.email");
            mailMessage.To.Add(new MailAddress("milanchudasma610@gmail.com"));
            mailMessage.Subject = "test mail";
            mailMessage.Body = "this is second testing mail";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.ethereal.email";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("jamel.hand89@ethereal.email", "Z5WTT157GSAd75rEt4");
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
            Console.WriteLine("Mail Send SuccessFully");


            //ado practice from youtube video

            //string connectionstring = @"Data Source=DESKTOP-TKKISTV;Initial Catalog=crud_op;Integrated Security=True";
            /////
            //SqlConnection sqlConnection =  new SqlConnection(connectionstring);
            //sqlConnection.Open();

            //Console.WriteLine("write a name");
            //string name  = Console.ReadLine();
            //Console.WriteLine("wtite your city");
            //string city = Console.ReadLine();
            //Console.WriteLine("enter a birth date");
            //string date = Console.ReadLine();
            //Console.WriteLine("enter a phone number");
            //long num = long.Parse(Console.ReadLine());

            //string insertQuery = $"insert into crud_op (id,name,city,date,phone) values(4,'{name}','{city}','{date}',{num});";

            //SqlCommand insertCommand = new SqlCommand(insertQuery,sqlConnection);

            //insertCommand.ExecuteNonQuery();

            //string selectQuery = $"select * from crud_op;";
            //SqlCommand cmd = sqlConnection.CreateCommand();
            //SqlCommand display = new SqlCommand(selectQuery,sqlConnection);
            //SqlDataReader reader = display.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine($"id :{reader.GetValue(0).ToString()} name : {reader.GetValue(1).ToString()} city : {reader.GetValue(2).ToString()} date : {reader.GetValue(3).ToString()} phone : {reader.GetValue(4).ToString()}  " );

            //}
            //reader.Close();
            //sqlConnection.Close();

            //Console.Write(sqlConnection.ToString());
        }
    }
}
