using System;
using System.Windows.Forms;
using FullUniversityAppWithSql.BLL;
using FullUniversityAppWithSql.DLL.DAO;

namespace FullUniversityAppWithSql
{
    public partial class DepartmentUIForm : Form
    {
        public DepartmentUIForm()
        {
            InitializeComponent();
        }

        private Department aDepartment;
        private DepartmentBll aDepartmentBll = new DepartmentBll();

        private void saveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(nameTextBox.Text, codeTextBox.Text);
            string msg = aDepartmentBll.Save(aDepartment);
            MessageBox.Show(msg);

            departmentGridView.DataSource = aDepartmentBll.GetAllDepartments();

        }
    }
}
