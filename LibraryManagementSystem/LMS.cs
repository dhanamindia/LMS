using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LMS : Form
    {
         public LMS()
        {
            InitializeComponent();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Role role_temp = new Role();
            role_temp.MdiParent = this;
            role_temp.StartPosition = FormStartPosition.CenterParent;
            role_temp.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile_temp = new Profile();
            profile_temp.MdiParent = this;
            profile_temp.StartPosition = FormStartPosition.CenterParent;
            profile_temp.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section section_temp = new Section();
            section_temp.MdiParent = this;
            section_temp.StartPosition = FormStartPosition.CenterParent;
            section_temp.Show();
        }

        private void rackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rack rack_temp = new Rack();
            rack_temp.MdiParent = this;
            rack_temp.StartPosition = FormStartPosition.CenterParent;
            rack_temp.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member member_temp = new Member();
            member_temp.MdiParent = this;
            member_temp.StartPosition = FormStartPosition.CenterParent;
            member_temp.Show();
        }

        private void planToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan plan_temp = new Plan();
            plan_temp.MdiParent = this;
            plan_temp.StartPosition = FormStartPosition.CenterParent;
            plan_temp.Show();
        }

        private void sectionRackMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Section_rack_map temp = new Section_rack_map();
            temp.MdiParent = this;
            temp.StartPosition = FormStartPosition.CenterParent;
            temp.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_password cp_temp = new change_password();
            cp_temp.MdiParent = this;
            cp_temp.StartPosition = FormStartPosition.CenterParent;
            cp_temp.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase pur_temp = new Purchase();
            pur_temp.MdiParent = this;
            pur_temp.StartPosition = FormStartPosition.CenterParent;
            pur_temp.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Member mem_temp = new Member();
            mem_temp.MdiParent = this;
            mem_temp.StartPosition = FormStartPosition.CenterParent;
            mem_temp.Show();

        }

        private void bookInRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bookOutRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

         private void bookInRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookInRegister bir_temp = new BookInRegister();
            bir_temp.MdiParent = this;
            bir_temp.StartPosition = FormStartPosition.CenterParent;
            bir_temp.Show();
        }

        private void bookOutRegisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookOutRegister bor_temp = new BookOutRegister();
            bor_temp.MdiParent = this;
            bor_temp.StartPosition = FormStartPosition.CenterParent;
            bor_temp.Show();
        }

        private void memberTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberTransaction mt_temp = new MemberTransaction();
            mt_temp.MdiParent = this;
            mt_temp.StartPosition = FormStartPosition.CenterParent;
            mt_temp.Show();
        }
    }
}
