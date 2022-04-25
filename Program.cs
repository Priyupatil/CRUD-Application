using System;
using System.Data.SqlClient;


namespace CRUDApp1
{
    public class Stud_Information
    {
        public static void Main()
        {
            SqlConnection sqlConnection;

            string connectionString = @"Data Source=CTLTIMESLAP012\SQLEXPRESS;Initial Catalog=CODB;Integrated Security=True";
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection established successfully");
                Stud_Information.ExecuteUserChoice(sqlConnection);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ExecuteUserChoice(SqlConnection sqlConnection)
        {
            Console.WriteLine("Select from the options below:-\n1.Insertion\n2.Retrive\n3.Update\n4.Delete");
            int newchoice = int.Parse(Console.ReadLine());

            switch (newchoice)
            {
                case 1:
                    Insert insertStudent = new Insert();
                    Insert.SaveStudentRecord(sqlConnection);
                    Stud_Information.ExecuteUserChoice(sqlConnection);
                    break;

                case 2:
                    Display displayStudent = new Display();
                    Display.DisplayStudentRecord(sqlConnection);
                    Console.WriteLine("Select from the options below:-\n1.Insertion\n2.Retrive\n3.Update\n4.Delete");
                    newchoice = int.Parse(Console.ReadLine());
                    break;

                case 3:
                    Update updateStudent = new Update();
                    Update.UpdateStudentRecord(sqlConnection);
                    Console.WriteLine("Select from the options below:-\n1.Insertion\n2.Retrive\n3.Update\n4.Delete");
                    newchoice = int.Parse(Console.ReadLine());

                    break;

                case 4:
                    Delete deleteStudent = new Delete();
                    Delete.DeleteStudentRecord(sqlConnection);
                    Console.WriteLine("Select from the options below:-\n1.Insertion\n2.Retrive\n3.Update\n4.Delete");
                    newchoice = int.Parse(Console.ReadLine());

                    break;
                default:
                    Console.WriteLine("Please enter an valid option");
                    break;
            }

        }
    }
}



//}