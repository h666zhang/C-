using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA6_02
{
    public partial class frmPen : Form
    {
        public frmPen()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYes.Checked)//rabtn
            {
                MessageBox.Show("你的就业情况为：" + rbtnYes.Text);
            }
            else
            {
                MessageBox.Show("未就业");
            }
        }

        private void rbtnNo_Click(object sender, EventArgs e)
        {
            //if (rbtnNo.Checked)
            //{
            //    MessageBox.Show("你的就业情况为：" + rbtnNo.Text);
            //}
            MessageBox.Show("你的就业情况为：" + rbtnNo.Text);
        }

        private void chbRead_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRead.Checked)
            {
                MessageBox.Show("您喜欢：" + chbRead.Text);
            }

            else 
            {
                MessageBox.Show("您不喜欢：" + chbRead.Text);
            }
        }

        private void chbSport_Click(object sender, EventArgs e)
        {
            if (chbSport.Checked)
            {
                MessageBox.Show("您喜欢：" + chbSport.Text);
            }

            else
            {
                MessageBox.Show("您不喜欢：" + chbSport.Text);
            }
        }
    }
}
