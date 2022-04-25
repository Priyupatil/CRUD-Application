using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApp1
{
    public class Delete
    {
        public static void DeleteStudentRecord(SqlConnection sqlConnection)
        {
            int Roll_No;
            Console.WriteLine("Enter the Roll_No of the student to be deleted");
            Roll_No = int.Parse(Console.ReadLine());

            SqlCommand command = new SqlCommand("spdeleteStudent", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Roll_No", Roll_No);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            Console.WriteLine("Record deleted Successfully");

        }
    }
}
