using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FullUniversityAppWithSql.BLL;
using FullUniversityAppWithSql.DLL.DAO;

namespace FullUniversityAppWithSql
{
    public partial class UniversityUI : Form
    {
        Department aDepartment = new Department();
        public UniversityUI()
        {
            InitializeComponent();
            showInComboBox();
        }

        private void showInComboBox()
        {
            DepartmentBll aDepartmentBll = new DepartmentBll();
            List<Department> departments = aDepartmentBll.GetAllDepartments();
            foreach (Department department1 in departments)
            {
                departmentComboBox.Items.Add(department1);
            }
            departmentComboBox.DisplayMember = "Code";
            departmentComboBox.ValueMember = "Name";
        }

        private StudentBLL aStudentBll = new StudentBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;

            Department aDepartment = (Department) departmentComboBox.SelectedItem;
            MessageBox.Show(aDepartment.DeptId.ToString());
            aStudent.DepartmentId = aDepartment.DeptId;
            string msg = aStudentBll.Save(aStudent);
            MessageBox.Show(msg);

            studentGridView.DataSource = aStudentBll.GetAllStudents();


        }
    }
}
