using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_013
{
    public partial class frmSimpleCom : Form
    {
        public frmSimpleCom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cboxCom_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void frmSimpleCom_Load(object sender, EventArgs e)
        {
            cboxCom.Items.Add("COM1");
            cboxCom.Items.Add("COM2");
            cboxCom.Items.Add("COM3");
            cboxCom.Items.Add("COM4");
            cboxCom.Items.Add("COM5");
            cboxCom.Items.Add("COM6");
            cboxCom.Items.Add("COM7");
            cboxCom.Items.Add("COM8");
            cboxCom.Items.Add("COM9");
            cboxCom.Items.Add("COM10");
            cboxCom.SelectedIndex = 0;
        }
    }
}
