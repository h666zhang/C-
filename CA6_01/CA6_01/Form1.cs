using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA6_01
{
    public partial class frmGraduateDatails : Form
    {
        public frmGraduateDatails()
        {
            InitializeComponent();
        }
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            //txtName.Text = txtNumber.Text;
        }

        private void frmGraduateDatails_Load(object sender, EventArgs e)
        {
            //格式：控件名.Items.Add();this是干嘛的,this可以不打
            this.lbDeptName.Items.Add("机械学院");
            this.lbDeptName.Items.Add("电气学院");
            this.lbDeptName.Items.Add("航空学院");
            this.lbDeptName.Items.Add("交通学院");
            this.lbDeptName.Items.Add("贸易学院");
            this.lbDeptName.Items.Add("经管学院");
            this.lbDeptName.Items.Add("艺术学院");
            this.cboxGraYear.Items.Add(2026);
            this.cboxGraYear.Items.Add(2025);
            this.cboxGraYear.Items.Add("2024");
            this.cboxGraYear.Items.Add("2023");
            this.cboxGraYear.Items.Add("2022");
            this.cboxGraYear.Items.Add("2021");
            this.cboxGraYear.SelectedIndex = 0;
            //cboxGraYear.Text = "2026";
            //禁用相关控件
            txtName.Enabled = false;
            txtNumber.Enabled = false;
            cboxGraYear.Enabled = false;
        }

        private void lbDeptName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("你所在的学院为"+lbDeptName.Text);
        }

        private void cboxGraYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("毕业年份" + cboxGraYear.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtNumber.Enabled = true;
            cboxGraYear.Enabled = true;
            lbDeptName.Enabled = true;
            lbDeptName.SelectedIndex = 0;
            txtName.Focus();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //文本框清除内容
            txtName.Text = "";
            txtNumber.Clear();
            //组合框恢复默认值
            cboxGraYear.SelectedIndex = 0; 
            //列表框清除选项
            lbDeptName.ClearSelected();
            //光标聚焦txtname
            txtName.Focus();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < lbDeptName.SelectedItems.Count; i++) 
            {
                str += "\n" + lbDeptName.SelectedItems[i];
            }
            MessageBox.Show("姓名：" + txtName.Text+ "\r\n学号：" + txtNumber.Text+ "\r\n毕业年份：" + cboxGraYear.Text+"\r\n你所在的学院为" + str);
            //exit
            Application.Exit();
        }
    }
}
