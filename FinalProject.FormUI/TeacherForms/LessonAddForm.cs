using FinalProject.Business.Abstract;
using FinalProject.Business.Concrete;
using FinalProject.DataAccess.Abstract;
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
    public partial class LessonAddForm : Form
    {
        public LessonAddForm()
        {
            InitializeComponent();
            _lessonService = new LessonManager(new EfLessonDal());
        }
        ILessonService _lessonService;
        int lessonID = -1;
        private void btnBack_Click(object sender, EventArgs e)
        {
            Router.teacherMainForm.Show();
            this.Hide();
        }

        private void LessonAddForm_Load(object sender, EventArgs e)
        {
            LoadLessons();
        }
        void LoadLessons()
        {
            dataGridView1.DataSource = _lessonService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lessonName = textBox1.Text.Trim();
            if (lessonName != "")
            {
                Lesson newLesson = new Lesson { Name = lessonName };
                _lessonService.Add(newLesson);
                MessageBox.Show("Ders başarıyla eklendi");
            }
            else
                MessageBox.Show("İlgili alanı doldur!");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lessonID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string lessonName = textBox2.Text.Trim();
            if (lessonName != "" && lessonID != -1)
            {
                Lesson updateLesson = new Lesson { ID = lessonID, Name = lessonName };
                _lessonService.Update(updateLesson);
                MessageBox.Show("Ders başarıyla güncellendi");
            }
            else
                MessageBox.Show("İlgili alanı doldur!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lessonID != -1)
            {
                var deletelesson = _lessonService.GetLessonById(lessonID);
                _lessonService.Update(deletelesson[0]);
                MessageBox.Show("Ders başarıyla silindi");
            }
            else
                MessageBox.Show("Bir ders seç");
        }
    }
}
