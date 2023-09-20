namespace tuan5_net
{
    partial class Form1_2
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.lbl_birth = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtb_birth = new System.Windows.Forms.TextBox();
            this.txtb_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(360, 175);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(187, 175);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "CLEAR";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(54, 175);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(75, 23);
            this.btn_show.TabIndex = 12;
            this.btn_show.Text = "SHOW";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lbl_birth
            // 
            this.lbl_birth.AutoSize = true;
            this.lbl_birth.Location = new System.Drawing.Point(51, 101);
            this.lbl_birth.Name = "lbl_birth";
            this.lbl_birth.Size = new System.Drawing.Size(67, 13);
            this.lbl_birth.TabIndex = 11;
            this.lbl_birth.Text = "Year of birth:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(51, 63);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Your Name:";
            // 
            // txtb_birth
            // 
            this.txtb_birth.Location = new System.Drawing.Point(140, 98);
            this.txtb_birth.Name = "txtb_birth";
            this.txtb_birth.Size = new System.Drawing.Size(147, 20);
            this.txtb_birth.TabIndex = 9;
            this.txtb_birth.TextChanged += new System.EventHandler(this.txtb_birth_TextChanged);
            this.txtb_birth.Leave += new System.EventHandler(this.txtb_birth_Leave);
            // 
            // txtb_Name
            // 
            this.txtb_Name.Location = new System.Drawing.Point(140, 60);
            this.txtb_Name.Name = "txtb_Name";
            this.txtb_Name.Size = new System.Drawing.Size(147, 20);
            this.txtb_Name.TabIndex = 8;
            this.txtb_Name.Leave += new System.EventHandler(this.txtb_Name_Leave);
            // 
            // Form1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 268);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.lbl_birth);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtb_birth);
            this.Controls.Add(this.txtb_Name);
            this.Name = "Form1_2";
            this.Text = "FrmBAITAP1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_2_FormClosing);
            this.Load += new System.EventHandler(this.Form1_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label lbl_birth;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtb_birth;
        private System.Windows.Forms.TextBox txtb_Name;
    }
}