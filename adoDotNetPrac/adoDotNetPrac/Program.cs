using System.Data.SqlClient;
using System;
using Newtonsoft.Json;

namespace System
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string city { get; set; }

    }
    class Program
    {
        public static void choose(SqlConnection sqlConnection)
        {
            try
            {
                Console.WriteLine("connected");
                Console.WriteLine("1 : Register");
                Console.WriteLine("2 : Login");
                Console.WriteLine("3 : Update Password");
                Console.WriteLine("4 : Delete/Remove User");
                Console.WriteLine("5 : View All User");
                Console.WriteLine("6 : close");
                Console.WriteLine("enter a number");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        bool registerCheck = Register(sqlConnection);
                        if (!registerCheck)
                        {
                            choose(sqlConnection);

                        }
                        break;
                    case 2:
                        bool loginCheck = login(sqlConnection);
                        if (!loginCheck)
                        {
                            choose(sqlConnection);
                        }

                        break;
                    case 3:
                        updatePass(sqlConnection);
                        break;
                    case 4:
                        bool deleteChek = deleteUser(sqlConnection);
                        if (!deleteChek)
                        {
                            choose(sqlConnection);

                        }
                        break;
                    case 5:
                        viewAllUser(sqlConnection);
                        break;
                    case 6:

                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void viewAllUser(SqlConnection sqlConnection)
        {
            try
            {

                Person person = new Person();
                List<Person> list = new List<Person>();

                string selectQuery = "select * from registerado";
                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();

                string filepath = "C:\\keval\\ado.csv";
                FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);
                StreamWriter sw= new StreamWriter(fs);
                string str = "";
                str = $"id,name,email,age,city";
                sw.WriteLine(str);
                while (reader.Read())
                {

                    person.id = Convert.ToInt32(reader["id"]);
                    person.name = reader["name"].ToString();
                    person.email =  reader["email"].ToString();
                    person.age = Convert.ToInt32(reader["age"]);
                    person.city = reader["city"].ToString();


                    Console.WriteLine($"{reader["id"]}.......");
                    Console.WriteLine($"name : {reader["name"]}");
                    Console.WriteLine($"email : {reader["email"]}");
                    Console.WriteLine($"age : {reader["age"]}");
                    Console.WriteLine($"city : {reader["city"]}");
                    Console.WriteLine();

                    str = $"{reader["id"]},{reader["name"]},{reader["email"]},{reader["age"]},{reader["city"]}";
                    sw.WriteLine(str);

                    list.Add(person);

                }
                sw.Close();
                fs.Close();

                string json = JsonConvert.SerializeObject(list);
                //Console.WriteLine(json);

                LocalDataStoreSlot myslot = Thread.AllocateNamedDataSlot("data");
                Thread.SetData(myslot, json);
                string value = (string)Thread.GetData(Thread.GetNamedDataSlot("data"));

                //Console.WriteLine(value);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static bool Register(SqlConnection sqlConnection)
        {
            try
            {
                Console.WriteLine("enter a name");
                string name = Console.ReadLine();
                Console.WriteLine("enter your mail");
                string mail = Console.ReadLine();

                Console.WriteLine("enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter your city");
                string city = Console.ReadLine();

                Console.WriteLine("enter your password");
                string pass = Console.ReadLine();
                Console.WriteLine("enter a conform password");
                string cpass = Console.ReadLine();

                if (pass == cpass)
                {
                    string insertQuery = $"insert into registerado (name,email,age,city,password) values ('{name}','{mail}',{age},'{city}','{pass}')";
                    Console.WriteLine(insertQuery);

                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("you register successfully");
                    return true;
                }
                else
                {
                    Console.WriteLine("your password is not match");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool login(SqlConnection sqlConnection)
        {

            try
            {

                Console.WriteLine("enter your email");

                string mail2 = Console.ReadLine();
                Console.WriteLine("enter your password");
                string pass1 = Console.ReadLine();

                string selectQuery = $"select password from registerado where email = '{mail2}'";

                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader reader = selectCommand.ExecuteReader();
                string fetchPass = "";
                while (reader.Read())
                {

                    fetchPass = reader["password"].ToString();

                }
                reader.Close();
                if (pass1 == fetchPass)
                {
                    Console.WriteLine("you log in success fully");
                    return true;
                }
                else
                {
                    Console.WriteLine("your password is wrong");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static void updatePass(SqlConnection sqlConnection)
        {
            Console.WriteLine("enter your email");
            string mail = Console.ReadLine();
            Console.Write("enter old Password");
            string pass = Console.ReadLine();

            string selectQuery = $"select password from registerado where email = '{mail}'";

            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            string fetchPass = "";
            while (reader.Read())
            {
                fetchPass = reader["password"].ToString();
            }
            reader.Close();
            if (pass == fetchPass)
            {
                Console.WriteLine("password is matched");
                Console.WriteLine("enter a new password");
                string newPass = Console.ReadLine();
                Console.WriteLine("enter a confirm password");
                string cpass = Console.ReadLine();

                if (cpass == newPass)
                {

                    Console.WriteLine("both passwor is matched");

                    string updateQuery = $"update registerado set password = '{newPass}' where email = '{mail}';";
                    Console.WriteLine(updateQuery);
                    Console.WriteLine(sqlConnection);
                    SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                    updateCommand.ExecuteNonQuery();
                    Console.WriteLine("your password update successfully");

                }
            }

        }
        public static bool deleteUser(SqlConnection sqlConnection)
        {
            Console.WriteLine("Enter a Admin Email");
            string email = Console.ReadLine();

            if (email == "milan@gmail.com")
            {
                Console.WriteLine("Enter Your Password");
                string password = Console.ReadLine();

                string selectQuery = $"select password from registerado where email = '{email}'";

                SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                SqlDataReader display = selectCommand.ExecuteReader();
                string fetchPass = "";
                while (display.Read())
                {
                    fetchPass = display["password"].ToString();

                }
                display.Close();
                if (fetchPass == password)
                {
                    Console.WriteLine("both password is matched");
                    string selectQuery1 = $"select id,name,email from registerado where isDelete = 0;";
                    SqlCommand selectCommand1 = new SqlCommand(selectQuery1, sqlConnection);
                    SqlDataReader display1 = selectCommand1.ExecuteReader();

                    while (display1.Read())
                    {
                        Console.WriteLine($"{display1["id"]} name  : {display1["name"]} email : {display1["email"]}");
                    }
                    display1.Close();
                    Console.WriteLine("select and write a number");
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (id != 1)
                    {
                        string deleteQuery = $"update registerado set isDelete = 1 where id= {id} ";
                        SqlCommand deleteCommand1 = new SqlCommand(deleteQuery, sqlConnection);
                        deleteCommand1.ExecuteNonQuery();
                        Console.WriteLine("user removed successfully");
                    }
                    else
                    {
                        Console.WriteLine("admin can not be remove");
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("You Enter a Wrong Password");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("you are Not  admin");
                return false;
            }

        }
        static void Main(string[] args)
        {

            SqlConnection sqlConnection = null;
            try
            {
                string connctionString = @"Data Source=DESKTOP-TKKISTV;Initial Catalog=crud_op;Integrated Security=True";
                sqlConnection = new SqlConnection(connctionString);
                sqlConnection.Open();

                choose(sqlConnection);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();

            }

        }
    }
}
