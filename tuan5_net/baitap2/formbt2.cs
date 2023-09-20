using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtb_a_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider err2 = new ErrorProvider();
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                err2.SetError(txtb_a, "đây không phải là số, vui lòng nhập số");
            }
            else
            {
                err2.Clear();
            }
        }

        private void txtb_b_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider err2 = new ErrorProvider();
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                err2.SetError(txtb_b, "đây không phải là số, vui lòng nhập số");
            }
            else
            {
                err2.Clear();
            }
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtb_a.Text);
            int b = Convert.ToInt32(txtb_b.Text);
            int kq = a + b;
            txtb_ketqua.Text = kq.ToString();
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtb_a.Text);
            int b = Convert.ToInt32(txtb_b.Text);
            int kq = a - b;
            txtb_ketqua.Text = kq.ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtb_a.Text);
            int b = Convert.ToInt32(txtb_b.Text);
            int kq = a * b;
            txtb_ketqua.Text = kq.ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtb_a.Text);
            int b = Convert.ToInt32(txtb_b.Text);
            int kq = a / b;
            txtb_ketqua.Text = kq.ToString();
        }

    }
}
