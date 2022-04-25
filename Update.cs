using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp1
{
    public class Update
    {
        public static void UpdateStudentRecord(SqlConnection sqlConnection)
        {
            int Roll_No, Age;
            string Mob_No;
            int engMarks, hindimarks, mathsMarks;

            Console.WriteLine("Enter the student roll number that you would like to update");
            Roll_No = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Age of student to update");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Student Mobile number that would like to update");
            Mob_No = Console.ReadLine();

            Console.WriteLine("Enter the marks for English");
            engMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks for Hindi");
            hindimarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks for Maths");
            mathsMarks = int.Parse(Console.ReadLine());

            SqlCommand command = new SqlCommand("spUpdate", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Roll_No", Roll_No);
            command.Parameters.AddWithValue("@Age", Age);
            command.Parameters.AddWithValue("@Mob_No", Mob_No);
            command.Parameters.AddWithValue("@EngMarks", engMarks);
            command.Parameters.AddWithValue("@HindiMarks", hindimarks);
            command.Parameters.AddWithValue("@MathsMarks", mathsMarks);
            command.ExecuteNonQuery();
            sqlConnection.Close();

            Console.WriteLine("Record updated Successfully");
        }
    }
}
