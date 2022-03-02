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

namespace Hospital_Management_System_Application
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void medicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.hospitalDataSet.Medicine);
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (patient_IDTextBox.Text == "")
            {
                MessageBox.Show("Enter the Patient ID....");

            }
            else
            {
                if (date_TimeDateTimePicker.Text == "")
                {
                    MessageBox.Show("Select the Date From Box");

                }
                else
                {
                    if (medicineComboBox.Text == "")
                    {
                        MessageBox.Show("Select Option For Payment");
                    }
                    else
                    {
                        if (amountTextBox.Text == "")
                        {
                            MessageBox.Show("Enter ammount ");
                        }
                        
                                else
                                {
                                    this.medicineBindingSource.AddNew();
                                }
                            }
                        }
                    }
                }
            
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit the program", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.medicineBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (patient_IDTextBox.Text == "" || date_TimeDateTimePicker.Text == "" || medicineComboBox.Text == "" || amountTextBox.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait............");
                this.medicineBindingSource.RemoveCurrent();
            }
            else
            {
                this.medicineBindingSource.MoveNext();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (patient_IDTextBox.Text == "" || date_TimeDateTimePicker.Text == "" || medicineComboBox.Text == "" || amountTextBox.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait............");
                this.medicineBindingSource.RemoveCurrent();
            }
            else
            {
                this.medicineBindingSource.MovePrevious();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (patient_IDTextBox.Text == "")
            {
                MessageBox.Show("Enter the Patient ID....");

            }
            else
            {
                if (date_TimeDateTimePicker.Text == "")
                {
                    MessageBox.Show("Select the Date From Box");

                }
                else
                {
                    if (medicineComboBox.Text == "")
                    {
                        MessageBox.Show("fill the medicine box");
                    }
                    else
                    {
                        if (amountTextBox.Text == "")
                        {
                            MessageBox.Show("Enter Ammount");
                        }

                        else
                        {
                            this.Validate();
                            this.medicineBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                        }
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to close the Medicine Section", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (patient_IDTextBox.Text == "" || date_TimeDateTimePicker.Text == "" || medicineComboBox.Text == "" || amountTextBox.Text == "")
            {
                MessageBox.Show("Plzzzzz Fill the All Details......");

            }
            else
            {
                this.medicineBindingSource.AddNew();
            }
        }

        private void patient_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{0}\)?-? *\d{0}-? *-?\d{1}";
            if (Regex.IsMatch(patient_IDTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.patient_IDTextBox, "Enter Correct patien Id");
                return;
            }
        }

        private void KP60(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP80(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Kp72(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void medicineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void date_TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void date_TimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date_TimeDateTimePicker.CustomFormat = "dd-MM-yyyy hh:mm";
        }

        private void date_TimeDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                date_TimeDateTimePicker.CustomFormat = " ";
            }
        }
    }
}
