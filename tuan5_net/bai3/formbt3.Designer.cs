﻿namespace bai3
{
    partial class Form_dktaikhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.lbl_xnmk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtb_ten = new System.Windows.Forms.TextBox();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(212, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(39, 36);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(90, 13);
            this.lbl_ten.TabIndex = 1;
            this.lbl_ten.Text = "Tên đăng nhập";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(39, 73);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(78, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Địa chỉ Email";
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Location = new System.Drawing.Point(39, 113);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(60, 13);
            this.lbl_mk.TabIndex = 3;
            this.lbl_mk.Text = "Mật khẩu";
            // 
            // lbl_xnmk
            // 
            this.lbl_xnmk.AutoSize = true;
            this.lbl_xnmk.Location = new System.Drawing.Point(39, 174);
            this.lbl_xnmk.Name = "lbl_xnmk";
            this.lbl_xnmk.Size = new System.Drawing.Size(115, 13);
            this.lbl_xnmk.TabIndex = 4;
            this.lbl_xnmk.Text = "Xác nhận mật khẩu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtb_ten
            // 
            this.txtb_ten.Location = new System.Drawing.Point(160, 33);
            this.txtb_ten.Name = "txtb_ten";
            this.txtb_ten.Size = new System.Drawing.Size(371, 21);
            this.txtb_ten.TabIndex = 10;
            this.txtb_ten.Leave += new System.EventHandler(this.txtb_ten_Leave);
            // 
            // txtb_email
            // 
            this.txtb_email.Location = new System.Drawing.Point(160, 73);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(371, 21);
            this.txtb_email.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(371, 21);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(371, 21);
            this.textBox4.TabIndex = 9;
            // 
            // Form_dktaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 261);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.txtb_ten);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_xnmk);
            this.Controls.Add(this.lbl_mk);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_dktaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đăng ký tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.Label lbl_xnmk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtb_ten;
        private System.Windows.Forms.TextBox txtb_email;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

