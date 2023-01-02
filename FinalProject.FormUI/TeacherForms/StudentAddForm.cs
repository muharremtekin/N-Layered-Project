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
    public partial class StudentAddForm : Form
    {
        public StudentAddForm()
        {
            InitializeComponent();
            _parentService = new ParentManager(new EfParentDal());
            _studentService = new StudentManager(new EfStudentDal());
        }
        IParentService _parentService;
        IStudentService _studentService;
        private void StudentAddForm_Load(object sender, EventArgs e)
        {
            LoadParents();
        }
        void LoadParents()
        {
            cbxParents.DataSource = _parentService.GetAll();
            cbxParents.DisplayMember = "Name";
            cbxParents.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string flname = tbxNameSurname.Text.Trim();
            string phone = tbxPhone.Text.Trim();
            string mail = tbxMail.Text.Trim();
            string pass = tbxPass.Text.Trim();
            string gender = cbxGender.SelectedItem.ToString();
            DateTime birthday = dtpBirthday.Value;
            int parent_id = Convert.ToInt32(cbxParents.SelectedValue);
            if (flname != "" && phone != "" && mail != "" && pass != "" && gender != "" && birthday != null)
            {
                Student student = new Student { Name = flname, PhoneNumber = phone, Mail = mail, Password = pass, Gender = gender, DateOfBirth = birthday, Parent_ID = parent_id };
                _studentService.Add(student);
                checkStudent(student.Mail);
            }
        }
        void checkStudent(string mail)
        {
            if (_studentService.CheckStudent(mail))
                MessageBox.Show("Kayıt Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kayıt başarısız!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}