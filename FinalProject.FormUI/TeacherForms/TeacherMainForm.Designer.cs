
namespace FinalProject.FormUI.TeacherForms
{
    partial class TeacherMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğretmenEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aragörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aragörüntüleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.veliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwLessonTaught = new System.Windows.Forms.DataGridView();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessonTaught)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğretmenEkleToolStripMenuItem,
            this.öğrenciToolStripMenuItem,
            this.veliToolStripMenuItem,
            this.derslerToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(855, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğretmenEkleToolStripMenuItem
            // 
            this.öğretmenEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğretmenEkleToolStripMenuItem1,
            this.silToolStripMenuItem,
            this.toolStripSeparator1,
            this.aragörüntüleToolStripMenuItem});
            this.öğretmenEkleToolStripMenuItem.Name = "öğretmenEkleToolStripMenuItem";
            this.öğretmenEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 36);
            this.öğretmenEkleToolStripMenuItem.Text = "Öğretmen";
            // 
            // öğretmenEkleToolStripMenuItem1
            // 
            this.öğretmenEkleToolStripMenuItem1.Name = "öğretmenEkleToolStripMenuItem1";
            this.öğretmenEkleToolStripMenuItem1.Size = new System.Drawing.Size(263, 36);
            this.öğretmenEkleToolStripMenuItem1.Text = "Öğretmen Ekle";
            this.öğretmenEkleToolStripMenuItem1.Click += new System.EventHandler(this.öğretmenEkleToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(263, 36);
            this.silToolStripMenuItem.Text = "Sil-güncelle";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // aragörüntüleToolStripMenuItem
            // 
            this.aragörüntüleToolStripMenuItem.Name = "aragörüntüleToolStripMenuItem";
            this.aragörüntüleToolStripMenuItem.Size = new System.Drawing.Size(263, 36);
            this.aragörüntüleToolStripMenuItem.Text = "Ara/görüntüle";
            this.aragörüntüleToolStripMenuItem.Click += new System.EventHandler(this.aragörüntüleToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciToolStripMenuItem1,
            this.aragörüntüleToolStripMenuItem1});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(253, 36);
            this.öğrenciEkleToolStripMenuItem.Text = "Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem1
            // 
            this.öğrenciToolStripMenuItem1.Name = "öğrenciToolStripMenuItem1";
            this.öğrenciToolStripMenuItem1.Size = new System.Drawing.Size(253, 36);
            this.öğrenciToolStripMenuItem1.Text = "Sil-güncelle";
            this.öğrenciToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciToolStripMenuItem1_Click);
            // 
            // aragörüntüleToolStripMenuItem1
            // 
            this.aragörüntüleToolStripMenuItem1.Name = "aragörüntüleToolStripMenuItem1";
            this.aragörüntüleToolStripMenuItem1.Size = new System.Drawing.Size(253, 36);
            this.aragörüntüleToolStripMenuItem1.Text = "Ara/görüntüle";
            this.aragörüntüleToolStripMenuItem1.Click += new System.EventHandler(this.aragörüntüleToolStripMenuItem1_Click);
            // 
            // veliToolStripMenuItem
            // 
            this.veliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.veliToolStripMenuItem.Name = "veliToolStripMenuItem";
            this.veliToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.veliToolStripMenuItem.Text = "Veli";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.ekleToolStripMenuItem.Text = "Tüm işlemler";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümİşlemlerToolStripMenuItem});
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.derslerToolStripMenuItem.Text = "Dersler";
            // 
            // tümİşlemlerToolStripMenuItem
            // 
            this.tümİşlemlerToolStripMenuItem.Name = "tümİşlemlerToolStripMenuItem";
            this.tümİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.tümİşlemlerToolStripMenuItem.Text = "Tüm işlemler";
            this.tümİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.tümİşlemlerToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(123, 36);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // dgwLessonTaught
            // 
            this.dgwLessonTaught.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLessonTaught.Location = new System.Drawing.Point(0, 272);
            this.dgwLessonTaught.Margin = new System.Windows.Forms.Padding(2);
            this.dgwLessonTaught.Name = "dgwLessonTaught";
            this.dgwLessonTaught.RowHeadersWidth = 51;
            this.dgwLessonTaught.Size = new System.Drawing.Size(767, 218);
            this.dgwLessonTaught.TabIndex = 1;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblUserDetails.Location = new System.Drawing.Point(5, 18);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(110, 20);
            this.lblUserDetails.TabIndex = 3;
            this.lblUserDetails.Text = "Genel Bilgiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Öğrenciler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUserDetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwLessonTaught);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeacherMainForm_FormClosing);
            this.Load += new System.EventHandler(this.TeacherMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessonTaught)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğretmenEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aragörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aragörüntüleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwLessonTaught;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tümİşlemlerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}