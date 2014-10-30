using System.Collections.Generic;
using FullUniversityAppWithSql.DLL.DAO;
using FullUniversityAppWithSql.DLL.GATEWAY;

namespace FullUniversityAppWithSql.BLL
{
    class DepartmentBll
    {
        private DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public string Save(Department aDepartment)
        {
            if (aDepartment.Name != string.Empty || aDepartment.Code != string.Empty)
            {
                if (!HasThisCodeValid(aDepartment.Code))
                {
                    return aDepartmentGateway.Save(aDepartment);   
                }
                else
                {
                    return "Code already exists";
                }
                
            }
            else
            {
                return "Please insert data first";
            }
        }

        private bool HasThisCodeValid(string code)
        {
            return aDepartmentGateway.HasThisCodeValid(code);
        }

        public List<Department> GetAllDepartments()
        {
            return aDepartmentGateway.GetAllDepartments();
        }
    }
}
