using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace bai3
{
    public partial class Form_dktaikhoan : Form
    {
        public Form_dktaikhoan()
        {
            InitializeComponent();
        }


        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);

            return regex.IsMatch(email);
        }

        private void txtb_ten_Leave(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                err.SetError(ctr, "không được bỏ trống tên !!!");
            }
            else
            {
                err.Clear();
            }
        }

        private void txtb_email_Leave(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                err.SetError(ctr, "không được bỏ trống email !!!");
            }
            else
            {
                err.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                err.SetError(ctr, "không được bỏ trống mật khẩu !!!");
            }
            else
            {
                err.Clear();
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                err.SetError(ctr, "xui lòng xác nhận mật khẩu !!!");
            }
            else
            {
                err.Clear();
            }
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            else
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        private void txtb_email_TextChanged(object sender, EventArgs e)
        {
            //string email = txtb_email.Text;
            //if(IsEmail(email)){

            //}
        }
    
    }
}
