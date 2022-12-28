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

namespace FinalProject.FormUI
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
            _branchService = new BranchManager(new EfBranchDal());
        }
        IBranchService _branchService;
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text.Trim());
            string name = textBox1.Text.Trim();
            _branchService.Add(
                new Branch
                {
                    ID = id,
                    Name = name,
                }
                );
            LoadBranches();
        }

        private void testform_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }
        void LoadBranches()
        {
            comboBox1.DataSource = _branchService.GetAll();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }
    }
}
