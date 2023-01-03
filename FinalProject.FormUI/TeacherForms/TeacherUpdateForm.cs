using FinalProject.Business.Abstract;
using FinalProject.Business.Concrete;
using FinalProject.DataAccess.Concrete;
using FinalProject.Entities.Concrete;
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
    public partial class TeacherUpdateForm : Form
    {
        public TeacherUpdateForm()
        {
            InitializeComponent();
            _teacherService = new TeacherManager(new EfTeacherDal());
            _branchService = new BranchManager(new EfBranchDal());
        }
        ITeacherService _teacherService;
        IBranchService _branchService;
        int teacherId;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string flname = tbxNameSurname.Text.Trim();
            string phone = tbxPhone.Text.Trim();
            string mail = tbxMail.Text.Trim();
            string pass = tbxPass.Text.Trim();

            DateTime birthday = dtpBirthday.Value;
            string adress = rtbxAdress.Text;
            int branch_id = Convert.ToInt32(cbxBranches.SelectedValue);

            if (flname != "" && phone != "" && mail != "" && pass != "" && birthday != null)
            {
                string gender = cbxGender.SelectedItem.ToString();
                Teacher st = new Teacher { ID = teacherId, Name = flname, Phone_Number = phone, Mail = mail, Password = pass, Gender = gender, Date_Of_Birth = birthday, Adress = adress, BranchID = branch_id };
                _teacherService.Update(st);
                LoadBranches();
                LoadTeachers();
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
        }
        private void dgwStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            teacherId = Convert.ToInt32(dgwTeachers.CurrentRow.Cells[0].Value);
            List<Teacher> teacher = _teacherService.GetTeacherById(teacherId);
            tbxNameSurname.Text = teacher[0].Name;
            tbxPhone.Text = teacher[0].Phone_Number;
            tbxMail.Text = teacher[0].Mail;
            tbxPass.Text = teacher[0].Password;
            cbxGender.Text = teacher[0].Gender;
            rtbxAdress.Text = teacher[0].Adress;
            dtpBirthday.Value = teacher[0].Date_Of_Birth;
        }
        void LoadBranches()
        {
            cbxBranches.DataSource = _branchService.GetAll();
            cbxBranches.DisplayMember = "Name";
            cbxBranches.ValueMember = "ID";
        }
        void LoadTeachers()
        {
            dgwTeachers.DataSource = _teacherService.GetAll();
        }

        private void TeacherUpdateForm_Load(object sender, EventArgs e)
        {
            LoadBranches();
            LoadTeachers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var teacher = _teacherService.GetTeacherById(teacherId);
            _teacherService.Delete(teacher[0]);
            LoadTeachers();
        }

        private void TeacherUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
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
