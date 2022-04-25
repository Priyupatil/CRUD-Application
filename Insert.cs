using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp1
{
    public class Insert
    {

        public static void SaveStudentRecord(SqlConnection sqlConnection)
        {
            Console.WriteLine("Enter your Roll number");
            int Roll_No = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your Age");
            int Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Mobile number");
            string Mob_No = Console.ReadLine();

            Console.WriteLine("Enter your marks of English");
            int engMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your marks of Hindi");
            int hindiMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your marks of Maths");
            int mathsMarks = int.Parse(Console.ReadLine());

            SqlCommand command = new SqlCommand("spInsert", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Roll_No", Roll_No);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@Mob_No", Mob_No);
            command.Parameters.AddWithValue("@EngMarks", engMarks);
            command.Parameters.AddWithValue("@HindiMarks", hindiMarks);
            command.Parameters.AddWithValue("@MathsMarks", mathsMarks);
            command.ExecuteNonQuery();

            Console.WriteLine("Records inserted successfully into the table");



        }

    }

}



