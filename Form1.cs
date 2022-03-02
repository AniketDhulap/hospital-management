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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            Form7 Doctor = new Form7();
            Doctor.Show();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            Form8 Nurse = new Form8();
            Nurse.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            Form2 Appointment = new Form2();
            Appointment.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Form_5_ Patient = new Form_5_();
            Patient.Show();
        }

        private void btnAddDoc_Click(object sender, EventArgs e)
        {
            Form3 Doctor = new Form3();
            Doctor.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to close the program", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnAddNurse_Click(object sender, EventArgs e)
        {
            Form4 Nurse = new Form4();
            Nurse.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Form_6_ Payment = new Form_6_();
            Payment.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Form11 Medicine = new Form11();
            Medicine.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
            
            Form12 About = new Form12();
            About.Show();
        }

        private void btnDoctorList_Click(object sender, EventArgs e)
        {
            Form10 doctorlist = new Form10();
            doctorlist.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure want to Logout From Admin Login ?", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                
                btnPayment.Enabled = false;
                btnAddNurse.Enabled = false;
                btnAddDoc.Enabled = false;
                btnPatient.Enabled = false;
                btnExport.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Pass")
            {
                btnPatient.Enabled = true;
                btnDoctor.Enabled = true;
                btnNurse.Enabled = true;
                btnPayment.Enabled = true;
                btnAddNurse.Enabled = true;
                btnAddDoc.Enabled = true;
                btnAppointment.Enabled = true;
                btnDoctorList.Enabled = true;
                btnAbout.Enabled = true;
                btnExport.Enabled = true;
                btnLogOut.Enabled = true;
                btnExport.Enabled = true;


                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter correct Login details", "Hospital Management System");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

            btnPayment.Enabled = false;
            btnAddDoc.Enabled = false;
            btnAddNurse.Enabled = false;
            btnPatient.Enabled = false;
            btnLogOut.Enabled = false;
            btnExport.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPatient.Enabled = false;
            btnDoctor.Enabled = true;
            btnNurse.Enabled = true;
            btnPayment.Enabled = false;
            btnAddNurse.Enabled = false;
            btnAddDoc.Enabled = false;
            btnAppointment.Enabled = true;
            btnDoctorList.Enabled = true;
            btnAbout.Enabled = true;
            btnExport.Enabled = true;
            btnLogOut.Enabled = false;
            btnExport.Enabled = false;
            
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
