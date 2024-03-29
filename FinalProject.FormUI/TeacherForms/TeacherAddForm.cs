﻿using FinalProject.Business.Abstract;
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
    public partial class TeacherAddForm : Form
    {
        public TeacherAddForm()
        {
            InitializeComponent();
            _teacherService = new TeacherManager(new EfTeacherDal());
            _branchService = new BranchManager(new EfBranchDal());
        }
        ITeacherService _teacherService;
        IBranchService _branchService;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string flname = tbxNameSurname.Text.Trim();
            string phone = tbxPhone.Text.Trim();
            string mail = tbxMail.Text.Trim();
            string pass = tbxPass.Text.Trim();
            string gender = cbxGender.Text.Trim();
            DateTime birthday = dtpBirthday.Value;
            int branch_id = Convert.ToInt32(cbxBranches.SelectedValue);
            string adress = rtbxAdress.Text.Trim();
            if (flname != "" && phone != "" && mail != "" && pass != "" && gender != "" && birthday != null && adress != "")
            {
                Teacher teacher = new Teacher { Name = flname, Phone_Number = phone, Mail = mail, Password = pass, Gender = gender, Date_Of_Birth = birthday, Adress = adress, BranchID = branch_id };
                _teacherService.Add(teacher);
                checkTeacher(teacher.Mail);
            }
            else
                MessageBox.Show("Boş alan bırakmayın", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void checkTeacher(string mail)
        {
            if (_teacherService.CheckStudent(mail))
                MessageBox.Show("Kayıt Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kayıt başarısız!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void LoadBranches()
        {
            cbxBranches.DataSource = _branchService.GetAll();
            cbxBranches.DisplayMember = "Name";
            cbxBranches.ValueMember = "ID";
        }

        private void TeacherAddForm_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void TeacherAddForm_FormClosing(object sender, FormClosingEventArgs e)
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
