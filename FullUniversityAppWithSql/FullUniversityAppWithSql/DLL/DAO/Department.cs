namespace FullUniversityAppWithSql.DLL.DAO
{
    class Department
    {
        public int DeptId { set; get; }
        public string Name { set; get; }
        public string Code { set; get; }

        public Department(string name, string code):this()
        {
            Name = name;
            Code = code;
        }

        public Department()
        {
            
        }
    }
}
