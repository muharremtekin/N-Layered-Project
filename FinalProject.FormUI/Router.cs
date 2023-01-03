using FinalProject.FormUI.TeacherForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.FormUI
{
    public static class Router
    {
        public static TeacherAddForm teacherAddForm = new TeacherAddForm();
        public static TeacherUpdateForm teacherUpdateForm = new TeacherUpdateForm();
        public static TeacherMainForm teacherMainForm = new TeacherMainForm();
        public static SearchTeacherForm teacherSearchForm = new SearchTeacherForm();
        public static StudentAddForm studentAddForm = new StudentAddForm();
        public static SearchStudentForm studentcSearchForm = new SearchStudentForm();
        public static UpdateStudentForm studentUpdateForm = new UpdateStudentForm();
        public static ParentAddForm parentAddForm = new ParentAddForm();
        public static LessonAddForm lessonForm = new LessonAddForm();
        public static LoginForm loginForm = new LoginForm();
        public static CurrentUser currentUserForm = new CurrentUser();
        public static StudentMainForm studentMainForm = new StudentMainForm();
    }
}
