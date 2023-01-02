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
    public partial class SearchTeacherForm : Form
    {
        public SearchTeacherForm()
        {
            InitializeComponent();
            _teacherService = new TeacherManager(new EfTeacherDal());
            _branchService = new BranchManager(new EfBranchDal());
        }
        ITeacherService _teacherService;
        IBranchService _branchService;
        private void SearchTeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadBranches();
        }
        void LoadTeachers()
        {
            dgwTeachers.DataSource = _teacherService.GetAll();
        }
        void LoadBranches()
        {
            cbxBranches.DataSource = _branchService.GetAll();
            cbxBranches.DisplayMember = "Name";
            cbxBranches.ValueMember = "ID";
        }

        private void cbxBranches_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwTeachers.DataSource = _teacherService.GetTeacherByBranch(Convert.ToInt32(cbxBranches.SelectedValue));
            }
            catch
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxName.Text))
                dgwTeachers.DataSource = _teacherService.GetTeacherByTeacherName(tbxName.Text);
            else
                LoadTeachers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }
    }
}
