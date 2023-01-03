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
    public partial class StudentMainForm : Form
    {
        public StudentMainForm()
        {
            InitializeComponent();
            _lessonLearnService = new LessonLearnManager(new EfLessonsLearnDal());
        }
        ILessonLearnService _lessonLearnService;
        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _lessonLearnService.GetLessonByStudentId(CurrentUser.currentStudent.ID);
        }

        private void StudentMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
