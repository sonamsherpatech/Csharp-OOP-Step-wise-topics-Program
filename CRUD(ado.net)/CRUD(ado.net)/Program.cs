using System;
using MySql.Data.MySqlClient;


///<summary>
/// DBName===> College
/// Table ===> Student
/// Field ===> sid,sname, saddress, sdob
/// Operation ==> insert, read, delete, update
/// </summary>
namespace CRUD_ado.net_
{
    class Insert
    {
        static void Main(string[] args)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=college;uid=root;password='';");
            con.Open();

            string sql = "INSERT INTO student (sname,saddress,sdob) VALUES ('Rohan Shrestha','Kalanki','2004-01-25'), ('Milan Khanal','Kritipur','2001-12-01'), ('Ujjwol Subedi','Thimi','1998-02-25')";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            int row = cmd.ExecuteNonQuery();
            if(row > 0)
            {
                Console.WriteLine($"{row} is inserted!!");
            }else
            {
                Console.WriteLine("Error in Deletion");
            }
            con.Close();
        }
    }

    class Select
    {
        public static void Main()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=college;uid=root;password='';");
            con.Open();

            string sql = "SELECT * FROM student";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader dr = cmd.ExecuteReader();

            Console.WriteLine("s_id\tStudent Name\tStudent Address\t\tStudent Date Of Birth");
            while(dr.Read())
            {
                Console.WriteLine($"{dr[0]}\t{dr[1]}\t{dr[2]}\t\t\t{dr[3]}");
            }
            con.Close();
        }
    }
    
    //updating the address to Chahabil whos sid is 3
    class Update
    {
        public static void Main()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=college;uid=root;password='';");
            con.Open();

            string sql = "UPDATE student SET saddress = 'Chahabil'  WHERE sid = 3";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            int row = cmd.ExecuteNonQuery();
            if(row > 0)
            {
                Console.WriteLine($"{row} is Updated");
            }else
            {
                Console.WriteLine("Error in Update");
            }

        }
    }

    //Delete the student with sid = 2
    class Delete
    {
        public static void Main()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=college;uid=root;password='';");
            con.Open();

            string sql = "DELETE FROM student WHERE sid = 2";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            int row = cmd.ExecuteNonQuery();
            if(row > 0)
            {
                Console.WriteLine($"{row} is Deleted");
            }else
            {
                Console.WriteLine("Error in Deletion");
            }
        }
    }
}
