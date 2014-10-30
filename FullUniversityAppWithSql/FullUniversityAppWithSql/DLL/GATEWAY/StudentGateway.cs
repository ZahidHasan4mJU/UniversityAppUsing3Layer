using System.Collections.Generic;
using System.Data.SqlClient;
using FullUniversityAppWithSql.DLL.DAO;
using FullUniversityAppWithSql.DLL.DAO.View;

namespace FullUniversityAppWithSql.DLL.GATEWAY
{
    class StudentGateway
    {
        private SqlConnection connection; 
        public StudentGateway()
        {
            string conn = @"server = ZAHID-PC; database = UniversityProject;integrated security = true;";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }
        public string Save(Student aStudent)
        {
            connection.Open();
            string query = string.Format("INSERT INTO student VALUES ('{0}', '{1}', '{2}',{3})", 
                                        aStudent.Name, aStudent.Email, aStudent.Address, 
                                        aStudent.DepartmentId);
            SqlCommand command = new SqlCommand(query, connection);
            int affectedRow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRow > 0)
                return "data inserted";
            else
            {
                return "please insert data first";
            }
            
        }
        

        public bool hasValidEmail(string email)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM student WHERE st_Email = '{0}'", email);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool HasRow = reader.HasRows;
            connection.Close();
            return HasRow;
        }

        public List<StudentGridview> GetAllStudents()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM View_1");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<StudentGridview> students = new List<StudentGridview>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StudentGridview aStudent = new StudentGridview();//Student();
                    //aStudent.StudentId = (int) reader[0];
                    aStudent.Name = reader[0].ToString();
                    aStudent.Email = reader[1].ToString();
                    aStudent.Address = reader[2].ToString();
                    aStudent.DepName = reader[3].ToString();
                    aStudent.DepCode = reader[4].ToString();
                    
                    students.Add(aStudent);
                }
              
            }
            connection.Close();
            return students;
            
        }
    }
}
