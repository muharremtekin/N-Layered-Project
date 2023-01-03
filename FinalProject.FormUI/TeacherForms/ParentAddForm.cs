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
    public partial class ParentAddForm : Form
    {
        public ParentAddForm()
        {
            InitializeComponent();
            _parentService = new ParentManager(new EfParentDal());
        }
        IParentService _parentService;
        int parentID;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phoneNumber = textBox2.Text.Trim();
            if (name != "" && phoneNumber != "")
            {
                Parent newParent = new Parent { Name = name, Phone_Number = phoneNumber };
                _parentService.Add(newParent);
                MessageBox.Show("Kullanıcı başarıyla eklendi");
            }
            else
                MessageBox.Show("Lütfen ilgili alanları doldurum!");
        }

        private void ParentAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Router.teacherMainForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbxuName.Text.Trim();
            string phoneNumber = tbxuPhone.Text.Trim();
            if (name != "" && phoneNumber != "")
            {
                Parent parent = new Parent { ID = parentID, Name = name, Phone_Number = phoneNumber };
                _parentService.Update(parent);
                LoadParents();
                MessageBox.Show("Kullanıcı başarıyla güncellendi");
            }
            else
                MessageBox.Show("Lütfen ilgili alanları doldurum!");
        }
        void LoadParents()
        {
            dgwParents.DataSource = _parentService.GetAll();
        }

        private void ParentAddForm_Load(object sender, EventArgs e)
        {
            LoadParents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Router.teacherMainForm.Show();
            this.Hide();
        }

        private void dgwParents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            parentID = Convert.ToInt32(dgwParents.CurrentRow.Cells[0].Value);
            tbxuName.Text = dgwParents.CurrentRow.Cells[1].Value.ToString();
            tbxuPhone.Text = dgwParents.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
