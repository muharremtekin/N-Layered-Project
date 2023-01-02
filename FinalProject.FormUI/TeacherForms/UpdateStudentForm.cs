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
    public partial class UpdateStudentForm : Form
    {
        public UpdateStudentForm()
        {
            InitializeComponent();
            _parentService = new ParentManager(new EfParentDal());
            _studentService = new StudentManager(new EfStudentDal());
        }
        IParentService _parentService;
        IStudentService _studentService;
        int studentId;
        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            LoadParents();
            LoadStudents();
        }

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
                int parent_id = Convert.ToInt32(cbxParents.SelectedValue);

                if (flname != "" && phone != "" && mail != "" && pass != "" && birthday != null)
                {
                    string gender = cbxGender.SelectedItem.ToString();
                    Student st = new Student { ID = studentId, Name = flname, PhoneNumber = phone, Mail = mail, Password = pass, Gender = gender, DateOfBirth = birthday, Adress = adress, Parent_ID = parent_id };
                    _studentService.Update(st);
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
            cbxParents.DataSource = _parentService.GetAll();
            cbxParents.DisplayMember = "Name";
            cbxParents.ValueMember = "ID";
        }
        void LoadStudents()
        {
            dgwStudents.DataSource = _studentService.GetAll();
        }

        private void dgwStudents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            studentId = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value);
            List<Student> student = _studentService.GetStudentById(studentId);
            tbxNameSurname.Text = student[0].Name;
            tbxPhone.Text = student[0].PhoneNumber;
            tbxMail.Text = student[0].Mail;
            tbxPass.Text = student[0].Password;
            cbxGender.Text = student[0].Gender;
            rtbxAdress.Text = student[0].Adress;
            dtpBirthday.Value = student[0].DateOfBirth;
        }
    }
}
