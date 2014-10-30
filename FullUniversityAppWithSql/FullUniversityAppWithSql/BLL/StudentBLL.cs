using System.Collections.Generic;
using FullUniversityAppWithSql.DLL.DAO;
using FullUniversityAppWithSql.DLL.DAO.View;
using FullUniversityAppWithSql.DLL.GATEWAY;

namespace FullUniversityAppWithSql.BLL
{
    class StudentBLL
    {
        private StudentGateway aStudentGateway = new StudentGateway();
        public string Save(Student aStudent)
        {
            if (aStudent.Name == string.Empty || aStudent.Email == string.Empty || aStudent.Address == string.Empty)
            {
                return "failed";
            }
            else
            {
                if (!aStudentGateway.hasValidEmail(aStudent.Email))
                {
                    return aStudentGateway.Save(aStudent);
                }
                else
                {
                    return "email already exists";
                }
            }
        }

        public bool hasValidEmail(string email)
        {
            return aStudentGateway.hasValidEmail(email);
        }

        public List<StudentGridview> GetAllStudents()
        {
            return aStudentGateway.GetAllStudents();
        } 
    }
}
