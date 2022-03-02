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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnLoginDoc_Click(object sender, EventArgs e)
        {
            if (txtUsernameDoc.Text == "Doctor" && txtPasswordDoc.Text == "Pass")
            {
                btnAppointmentDoc.Enabled = true;
                btnPatientDoc.Enabled = true;
                btnAddDoctorDoc.Enabled = true;
                btnLogOutDoc.Enabled = true;


                txtUsernameDoc.Clear();
                txtPasswordDoc.Clear();
            }
            else
            {
                MessageBox.Show("Please Enter correct Login details", "Hospital Management System");
                txtUsernameDoc.Clear();
                txtPasswordDoc.Clear();
                txtUsernameDoc.Focus();
            }
        }

        private void btnClearDoc_Click(object sender, EventArgs e)
        {
            txtUsernameDoc.Clear();
            txtPasswordDoc.Clear();
            txtUsernameDoc.Focus();

            btnAppointmentDoc.Enabled = false;
            btnPatientDoc.Enabled = false;
            btnAddDoctorDoc.Enabled = false;
            btnLogOutDoc.Enabled = false;
        }

        private void btnLogOutDoc_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are you sure want to Logout From Doctor Login ?", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                txtUsernameDoc.Clear();
                txtPasswordDoc.Clear();
                txtUsernameDoc.Focus();

                btnAppointmentDoc.Enabled = false;
                btnPatientDoc.Enabled = false;
                btnAddDoctorDoc.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            btnAppointmentDoc.Enabled = false;
            btnPatientDoc.Enabled = false;
            btnAddDoctorDoc.Enabled = false;
            btnLogOutDoc.Enabled = false;
        }

        private void btnAppointmentDoc_Click(object sender, EventArgs e)
        {
            Form9 Appointment = new Form9();
            Appointment.Show();
        }

        private void btnPatientDoc_Click(object sender, EventArgs e)
        {
            Form_5_ Patient = new Form_5_();
            Patient.Show();
        }

        private void btnAddDoctorDoc_Click(object sender, EventArgs e)
        {
            Form3 Doctor = new Form3();
            Doctor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to close the Doctor Login", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
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

        private void txtUsernameDoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
