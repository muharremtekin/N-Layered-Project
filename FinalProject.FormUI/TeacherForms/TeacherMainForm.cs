using FinalProject.Business.Abstract;
using FinalProject.Business.Concrete;
using FinalProject.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.FormUI.TeacherForms
{
    public partial class TeacherMainForm : Form
    {
        public TeacherMainForm()
        {
            InitializeComponent();
            _teacherService = new TeacherManager(new EfTeacherDal());
            _lessonTaughtService = new LessonTaughtManager(new EfLessonTaughtDal());
            _studentService = new StudentManager(new EfStudentDal());
        }
        ITeacherService _teacherService;
        ILessonTaughtService _lessonTaughtService;
        IStudentService _studentService;
        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            LoadUSerDetail();
            LoadLessonTaught();
            fetchapidata();
        }

        private void öğretmenEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Router.teacherAddForm.Show();
            this.Hide();
        }
        void LoadLessonTaught()
        {
            dgwLessonTaught.DataSource = _studentService.GetAll();
        }
        void LoadUSerDetail()
        {
            lblUserDetails.Text = $"Ad-Soyad: {CurrentUser.currentTeacher.Name}\nEmail: {CurrentUser.currentTeacher.Mail}\nTelefon: {CurrentUser.currentTeacher.Phone_Number}";
        }

        void fetchapidata()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=bursa&units=metric&lang=tr&appid=e83b1748c912441f42a45d625ff37c03");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            try
            {

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);
                    label1.Text = $"Bursa: {data["main"]["temp"].ToString()} derece";

                }

            }
            catch { }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Router.teacherUpdateForm.Show();
            this.Hide();
        }

        private void aragörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Router.teacherSearchForm.Show();
            this.Hide();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Router.teacherAddForm.Show();
            this.Hide();
        }

        private void öğrenciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Router.studentUpdateForm.Show();
            this.Hide();
        }

        private void aragörüntüleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Router.studentcSearchForm.Show();
            this.Hide();
        }

        private void TeacherMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Router.parentAddForm.Show();
            this.Hide();
        }

        private void tümİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Router.lessonForm.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Router.loginForm.Show();
            this.Hide();
        }
    }
}
