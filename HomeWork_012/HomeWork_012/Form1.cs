using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_012
{
    public partial class frmTempCheck : Form
    {
        public frmTempCheck()
        {
            InitializeComponent();
        }

        private void gboxPerson_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtClass.Text == "" || txtNumber.Text == "" || txtDorm.Text == "" || txtTemp.Text == "")
            {
                MessageBox.Show("信息填写不玩整");
                txtName.Focus();
            }
            else
            {
                if (double.Parse(txtTemp.Text) > 38)
                { 
                    btnColor.BackColor = Color.Red;
                    MessageBox.Show("体温异常，请立即去医院就诊！");
                }
                else
                {
                    btnColor.BackColor = Color.Green;
                    MessageBox.Show("体温正常，请佩戴好口罩进入教室！");
                }
            }
        }
    }
}
