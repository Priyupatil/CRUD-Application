using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp1
{
    public class Display
    {
        public static void DisplayStudentRecord(SqlConnection sqlConnection)
        {
            SqlCommand command = new SqlCommand("spDisplayStudRecords", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("Stud_Id: " + dataReader.GetValue(0).ToString());
                Console.WriteLine("Roll_NO: " + dataReader.GetValue(1).ToString());
                Console.WriteLine("Name: " + dataReader.GetValue(2).ToString());
                Console.WriteLine("Age: " + dataReader.GetValue(3).ToString());
                Console.WriteLine("Mob_NO: " + dataReader.GetValue(4).ToString());
                Console.WriteLine("English: " + dataReader.GetValue(5).ToString());
                Console.WriteLine("Hindi: " + dataReader.GetValue(6).ToString());
                Console.WriteLine("Maths: " + dataReader.GetValue(7).ToString());


            }
            dataReader.Close();
        }


    }

//}
