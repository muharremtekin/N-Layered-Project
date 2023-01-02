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
    public partial class UpdateTeacherForm : Form
    {
        public UpdateTeacherForm()
        {
            InitializeComponent();
            _branchService = new BranchManager(new EfBranchDal());
            _teacherService = new TeacherManager(new EfTeacherDal());
        }

        IBranchService _branchService;
        ITeacherService _teacherService;
        int teachertId;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                    Teacher teacher = new Teacher { ID = teachertId, Name = flname, Phone_Number = phone, Mail = mail, Password = pass, Gender = gender, Date_Of_Birth = birthday, Adress = adress, BranchID = branch_id };
                    _teacherService.Update(teacher);
                    LoadStudents();
                    MessageBox.Show("Güncelleme işlemi başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Programı dğüzgün kullan!\n{ex.Message}", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void LoadParents()
        {
            cbxBranches.DataSource = _branchService.GetAll();
            cbxBranches.DisplayMember = "Name";
            cbxBranches.ValueMember = "ID";
        }
        void LoadStudents()
        {
            dgwTeachers.DataSource = _teacherService.GetAll();
        }

        private void dgwTeachers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            teachertId = Convert.ToInt32(dgwTeachers.CurrentRow.Cells[0].Value);
            var student = _teacherService.GetTeacherById(teachertId);
            tbxNameSurname.Text = student[0].Name;
            tbxPhone.Text = student[0].Phone_Number;
            tbxMail.Text = student[0].Mail;
            tbxPass.Text = student[0].Password;
            cbxGender.Text = student[0].Gender;
            rtbxAdress.Text = student[0].Adress;
            dtpBirthday.Value = student[0].Date_Of_Birth;
        }

        private void UpdateTeacherForm_Load(object sender, EventArgs e)
        {
            LoadParents();
            LoadStudents();
        }
    }
}
