using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sự_kiện_SelectedIndexChanged_ListView
{
    public partial class Thêm_môn_học : Form
    {
        public string tenMonHoc { get; set; }
        public string tinChi {  get; set; }
        public Thêm_môn_học()
        {
            InitializeComponent();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            tenMonHoc=txt_mon.Text;
            tinChi=txt_tc.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_mon_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_mon_Enter(object sender, EventArgs e)
        {
            if (txt_mon.Text == "Nhap mon hoc")
            {
                txt_mon.Text =string.Empty ;
            }
        }

        private void txt_mon_Leave(object sender, EventArgs e)
        {
            if (txt_mon.Text == string.Empty)
            {
                txt_mon.Text = "Nhap mon hoc";
            }
        }
    }
}
