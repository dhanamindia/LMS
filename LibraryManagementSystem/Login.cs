﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection connect = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from profile_master where pro_user_id = '" + textBox1.Text + "' and pro_password = '" +textBox2.Text + "' ", connect.activecon());
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                LMS lms_temp = new LMS();
                lms_temp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UserName or password is incorret", "Login Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }
        }


    }
}
