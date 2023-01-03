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
    public partial class StudentLessonRegisterForm : Form
    {
        public StudentLessonRegisterForm()
        {
            InitializeComponent();
            _lessonLearnService = new LessonLearnManager(new EfLessonsLearnDal());
            _lessonTaughtService = new LessonTaughtManager(new EfLessonTaughtDal());
        }
        ILessonLearnService _lessonLearnService;
        ILessonTaughtService _lessonTaughtService;
        private void StudentLessonRegisterForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = _lessonTaughtService.GetAll();
        }
    }
}
