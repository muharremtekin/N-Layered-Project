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

namespace FinalProject.FormUI
{
    public partial class CurrentUser : Form
    {
        public CurrentUser()
        {
            InitializeComponent();
        }
        public static Teacher currentTeacher;
        public static Student currentStudent;
        private void CurrentUser_Load(object sender, EventArgs e)
        {

        }
    }
}
