using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System_Application
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnLoginNur_Click(object sender, EventArgs e)
        {
            if (txtUsernameNur.Text == "Nurse" && txtPasswordNur.Text == "Pass")
            {
                btnAppointmentNur.Enabled = true;
                btnPatientNur.Enabled = true;
                btnAddNur.Enabled = true;
                btnLogOutNur.Enabled = true;


                txtUsernameNur.Clear();
                txtPasswordNur.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter correct Login details", "Hospital Management System");
                txtUsernameNur.Clear();
                txtPasswordNur.Clear();
                txtUsernameNur.Focus();
            }
        }

        private void btnClearNur_Click(object sender, EventArgs e)
        {
            txtUsernameNur.Clear();
            txtPasswordNur.Clear();
            txtUsernameNur.Focus();

            btnAppointmentNur.Enabled = false;
            btnPatientNur.Enabled = false;
            btnAddNur.Enabled = false;
            btnLogOutNur.Enabled = false;
        }

        private void btnLogOutNur_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure want to Logout From Nurse Login ?", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                txtUsernameNur.Clear();
                txtPasswordNur.Clear();
                txtUsernameNur.Focus();

                btnAppointmentNur.Enabled = false;
                btnPatientNur.Enabled = false;
                btnAddNur.Enabled = false;
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            btnAppointmentNur.Enabled = false;
            btnPatientNur.Enabled = false;
            btnAddNur.Enabled = false;
            btnLogOutNur.Enabled = false;
        }

        private void btnAddNur_Click(object sender, EventArgs e)
        {
            Form4 Nurse = new Form4();
            Nurse.Show();
        }

        private void btnPatientNur_Click(object sender, EventArgs e)
        {
            Form_5_ Patient = new Form_5_();
            Patient.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to close the Nurse Login", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnAppointmentNur_Click(object sender, EventArgs e)
        {
            Form11 Medicine = new Form11();
            Medicine.Show();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want close", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
