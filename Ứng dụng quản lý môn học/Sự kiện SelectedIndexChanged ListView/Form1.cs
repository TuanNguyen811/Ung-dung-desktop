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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thêm_môn_học monhoc = new Thêm_môn_học();
            if (monhoc.ShowDialog() == DialogResult.OK)
            {
                bool kiemtra = false;
                ListViewItem item = new ListViewItem(monhoc.tenMonHoc);
                item.SubItems.Add(monhoc.tinChi);
                foreach (ListViewItem it in listView1.Items)
                {
                    if (it.Text == item.Text)
                    {
                        kiemtra = true;
                    }
                }
                if (kiemtra == false)
                {
                    listView1.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Mon hoc bi trung");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn muốn xóa môn học", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dt == DialogResult.OK)
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        item.Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("Khong thanh cong");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int soluong = listView2.Items.Count;
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dt = MessageBox.Show("Bạn muốn dang ky mon hoc", "Thong bao", MessageBoxButtons.OKCancel);
                if (dt == DialogResult.OK)
                {
                    foreach(ListViewItem item in listView1.SelectedItems)
                    {
                        bool kiemtra = true;
                        ListViewItem a = new ListViewItem((soluong + 1).ToString());
                        a.SubItems.Add(item.Text); // Thêm SubItem cho cột thứ 2
                        a.SubItems.Add(item.SubItems[1].Text); // Thêm SubItem cho cột thứ 3
                        foreach (ListViewItem it2 in listView2.Items)
                        {
                            if (it2.SubItems[1].Text == a.SubItems[1].Text)
                            {
                                kiemtra= false;
                                break;
                            }
                        }
                        if (kiemtra == true)
                        {
                            listView2.Items.Add(a);
                            soluong++;
                        }
                        else
                        {
                            MessageBox.Show("Mon: " + a.SubItems[1].Text+" Bi trung");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Khong thanh cong");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int soluong = listView2.Items.Count -listView2.SelectedItems.Count;
            if (listView2.SelectedItems.Count > 0)
            {
                DialogResult dt = MessageBox.Show("ban muon xoa mon hoc", "Thong bao", MessageBoxButtons.OK);
                if (dt == DialogResult.OK)
                {
                    foreach(ListViewItem it in listView2.SelectedItems)
                    {
                        it.Remove();
                    }
                }
            }
            for(int i = 0; i < soluong; i++)
            {
                listView2.Items[i].Text= (i+1).ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem a = listView1.SelectedItems[0];
                string monhoc = a.SubItems[0].Text;
                label2.Text = "dang chon: "+monhoc;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
