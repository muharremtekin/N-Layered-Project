using FinalProject.Business.Abstract;
using FinalProject.Business.Concrete;
using FinalProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.FormUI.TeacherForms
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
            _parentService = new ParentManager(new EfParentDal());
            _studentService = new StudentManager(new EfStudentDal());
        }
        IParentService _parentService;
        IStudentService _studentService;
        private void SearchStudentForm_Load(object sender, EventArgs e)
        {
            LoadParents();
            LoadStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
        void LoadParents()
        {
            cbxParents.DataSource = _parentService.GetAll();
            cbxParents.DisplayMember = "Name";
            cbxParents.ValueMember = "ID";
        }
        void LoadStudents()
        {
            dgwStudents.DataSource = _studentService.GetAll();
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxName.Text))
                dgwStudents.DataSource = _studentService.GetStudentByStudentName(tbxName.Text.Trim());
            else
                LoadParents();
        }

        private void cbxParents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwStudents.DataSource = _studentService.GetStudentByParentId(Convert.ToInt32(cbxParents.SelectedValue));
            }
            catch
            {
            }
        }

        private void SearchStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Router.teacherMainForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Router.teacherMainForm.Show();
            this.Hide();
        }
    }
}
