using FinalProject.Business.Abstract;
using FinalProject.Business.Concrete;
using FinalProject.DataAccess.Concrete;
using FinalProject.Entities.Concrete;
using FinalProject.FormUI.TeacherForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.FormUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // katmanlar birbirini yenilememeli ama şimdilik böyle kullandım.
            _teacherService = new TeacherManager(new EfTeacherDal());
            _studentService = new StudentManager(new EfStudentDal());
        }
        ITeacherService _teacherService;
        IStudentService _studentService;
        public object currentUser;

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string mail = tbxMail.Text;
            string password = tbxPassword.Text;

            LoginStudent(mail, password);
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            string mail = tbxMail.Text;
            string password = tbxPassword.Text;

            LoginTeacher(mail, password);
        }

        private void LoginTeacher(string mail, string password)
        {
            if (mail != "" && password != "")
            {
                var user = _teacherService.LoginTeacher(mail, password);
                if (user.Count > 0)
                {
                    MessageBox.Show("Hoş geldiniz " + user[0].Name);
                    currentUser = user[0];
                    TeacherMainForm teacherMainForm = new TeacherMainForm();
                    teacherMainForm.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("mail ya da şifre boş olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void LoginStudent(string mail, string password)
        {
            if (mail != "" && password != "")
            {
                var user = _studentService.LoginStudent(mail, password);
                if (user.Count > 0)
                {
                    MessageBox.Show(user[0].Name);
                    currentUser = user[0];
                }
                else
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("mail ya da şifre boş olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
