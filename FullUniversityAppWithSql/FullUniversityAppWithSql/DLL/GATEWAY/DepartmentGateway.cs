using System.Collections.Generic;
using System.Data.SqlClient;
using FullUniversityAppWithSql.DLL.DAO;

namespace FullUniversityAppWithSql.DLL.GATEWAY
{
    class DepartmentGateway
    {
        private SqlConnection connection;
        public DepartmentGateway()
        {
            string conn = @"server=ZAHID-PC; database=UniversityProject; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = conn;
        }
        public string Save(Department aDepartment)
        {
            connection.Open();
            string query = string.Format("INSERT INTO department_t VALUES('{0}','{1}')", aDepartment.Name,
                aDepartment.Code);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
        }

        public List<Department> GetAllDepartments()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM department_t");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Department> departments = new List<Department>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Department aDepartment = new Department();
                    aDepartment.DeptId = (int)aReader[0];
                    aDepartment.Name = aReader[1].ToString();
                    aDepartment.Code = aReader[2].ToString();

                    departments.Add(aDepartment);
                }
            }
            connection.Close();
            return departments;
        }

        public bool HasThisCodeValid(string code)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM department_t WHERE dept_Code='{0}'", code);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool hasRow = aReader.HasRows;
            connection.Close();
            return hasRow;
        }
    }
}
