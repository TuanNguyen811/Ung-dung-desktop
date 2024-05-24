using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sự_kiện_SelectedIndexChanged_ListView
{
    public partial class DangNhap : Form
    {
        public string mk {  get; set; }
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mk=textBox1.Text;
        }
    }
}
