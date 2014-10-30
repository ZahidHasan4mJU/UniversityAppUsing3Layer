using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullUniversityAppWithSql
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void studentUiButton_Click(object sender, EventArgs e)
        {
            UniversityUI aUniversityUi = new UniversityUI();
            aUniversityUi.ShowDialog();
        }

        private void DepartmentUiButton_Click(object sender, EventArgs e)
        {
            DepartmentUIForm aDepartmentUiForm = new DepartmentUIForm();
            aDepartmentUiForm.ShowDialog();
        }
    }
}
