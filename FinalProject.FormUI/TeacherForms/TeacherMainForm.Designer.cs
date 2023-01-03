
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
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwLessonTaught = new System.Windows.Forms.DataGridView();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tümİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLessonTaught)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.menuStrip1.Size = new System.Drawing.Size(776, 34);
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
            this.öğretmenEkleToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.öğretmenEkleToolStripMenuItem.Text = "Öğretmen";
            // 
            // öğretmenEkleToolStripMenuItem1
            // 
            this.öğretmenEkleToolStripMenuItem1.Name = "öğretmenEkleToolStripMenuItem1";
            this.öğretmenEkleToolStripMenuItem1.Size = new System.Drawing.Size(208, 30);
            this.öğretmenEkleToolStripMenuItem1.Text = "Öğretmen Ekle";
            this.öğretmenEkleToolStripMenuItem1.Click += new System.EventHandler(this.öğretmenEkleToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.silToolStripMenuItem.Text = "Sil-güncelle";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // aragörüntüleToolStripMenuItem
            // 
            this.aragörüntüleToolStripMenuItem.Name = "aragörüntüleToolStripMenuItem";
            this.aragörüntüleToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
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
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.öğrenciToolStripMenuItem.Text = "Öğrenci";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.öğrenciEkleToolStripMenuItem.Text = "Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciToolStripMenuItem1
            // 
            this.öğrenciToolStripMenuItem1.Name = "öğrenciToolStripMenuItem1";
            this.öğrenciToolStripMenuItem1.Size = new System.Drawing.Size(203, 30);
            this.öğrenciToolStripMenuItem1.Text = "Sil-güncelle";
            this.öğrenciToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciToolStripMenuItem1_Click);
            // 
            // aragörüntüleToolStripMenuItem1
            // 
            this.aragörüntüleToolStripMenuItem1.Name = "aragörüntüleToolStripMenuItem1";
            this.aragörüntüleToolStripMenuItem1.Size = new System.Drawing.Size(203, 30);
            this.aragörüntüleToolStripMenuItem1.Text = "Ara/görüntüle";
            this.aragörüntüleToolStripMenuItem1.Click += new System.EventHandler(this.aragörüntüleToolStripMenuItem1_Click);
            // 
            // veliToolStripMenuItem
            // 
            this.veliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.veliToolStripMenuItem.Name = "veliToolStripMenuItem";
            this.veliToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.veliToolStripMenuItem.Text = "Veli";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.ekleToolStripMenuItem.Text = "Tüm işlemler";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // derslerToolStripMenuItem
            // 
            this.derslerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümİşlemlerToolStripMenuItem});
            this.derslerToolStripMenuItem.Name = "derslerToolStripMenuItem";
            this.derslerToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.derslerToolStripMenuItem.Text = "Dersler";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // dgwLessonTaught
            // 
            this.dgwLessonTaught.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLessonTaught.Location = new System.Drawing.Point(6, 132);
            this.dgwLessonTaught.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwLessonTaught.Name = "dgwLessonTaught";
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
            this.lblUserDetails.Size = new System.Drawing.Size(88, 16);
            this.lblUserDetails.TabIndex = 3;
            this.lblUserDetails.Text = "Genel Bilgiler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Öğrenciler";
            // 
            // tümİşlemlerToolStripMenuItem
            // 
            this.tümİşlemlerToolStripMenuItem.Name = "tümİşlemlerToolStripMenuItem";
            this.tümİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.tümİşlemlerToolStripMenuItem.Text = "Tüm işlemler";
            this.tümİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.tümİşlemlerToolStripMenuItem_Click);
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
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwLessonTaught);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}