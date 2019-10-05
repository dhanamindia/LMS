using System;
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
    public partial class Role : Form
    {
        Connection connect = new Connection();

        public Role()
        {

            InitializeComponent();
        }

        private void Role_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet.Role_master' table. You can move, or remove it, as needed.
            this.role_masterTableAdapter.Fill(this.lMSDataSet.Role_master);
            dw_load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();

            SqlDataAdapter sda = new SqlDataAdapter("proc_new_role", connect.activecon());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                textBox1.Text = dt.Rows[0][0].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)

        {

            SqlCommand cmd = new SqlCommand("insert into role_master values('" + textBox1.Text + "' ,'" + textBox2.Text + "','" + comboBox1.SelectedItem + "')", connect.activecon());
            try
            {
                int ret_cnt = cmd.ExecuteNonQuery();
                if (ret_cnt > 0)
                { MessageBox.Show("Saved Successfully"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dw_load();
        }

        void dw_load()
        {
            //SqlCommand cmd = new SqlCommand("select * from role_master", connect.activecon());
            SqlDataAdapter sda = new SqlDataAdapter("select * from role_master", connect.activecon());
            DataTable dt = new DataTable();


            try
            {
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
