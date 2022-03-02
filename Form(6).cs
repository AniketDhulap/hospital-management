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
    public partial class Form_6_ : Form
    {
        public Form_6_()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form_6__Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.hospitalDataSet.Payment);

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
                    if (method_of_PaymentComboBox.Text == "")
                    {
                        MessageBox.Show("Select Option For Payment");
                    }
                    else
                    {
                        if (card_NumberTextBox.Text == "")
                        {
                            MessageBox.Show("Enter Last 4 Digit Of Payment Card");
                        }
                        else
                        {
                            if (pin_NumberTextBox.Text == "")
                            {
                                MessageBox.Show("Enter Pin Number");
                            }
                            else
                            {
                                if (ammount_PaidTextBox.Text == "")
                                {
                                    MessageBox.Show("Enter total Ammount Of Payment");
                                }


                                else
                                {
                                    this.paymentBindingSource.AddNew();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (patient_IDTextBox.Text == "" || date_TimeDateTimePicker.Text == "" || method_of_PaymentComboBox.Text == "" || card_NumberTextBox.Text == "" || pin_NumberTextBox.Text == "" || ammount_PaidTextBox.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait...........");
                this.paymentBindingSource.RemoveCurrent();
            }
            else
            {
                this.paymentBindingSource.MoveNext();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (patient_IDTextBox.Text == "" || date_TimeDateTimePicker.Text == "" || method_of_PaymentComboBox.Text == "" || card_NumberTextBox.Text == "" || pin_NumberTextBox.Text == "" || ammount_PaidTextBox.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait...........");
                this.paymentBindingSource.RemoveCurrent();
            }
            else
            {
                this.paymentBindingSource.MovePrevious();
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
                    if (method_of_PaymentComboBox.Text == "")
                    {
                        MessageBox.Show("Select Option For Payment");
                    }
                    else
                    {
                        if (card_NumberTextBox.Text == "")
                        {
                            MessageBox.Show("Enter Last 4 Digit Of Payment Card");
                        }
                        else
                        {
                            if (pin_NumberTextBox.Text == "")
                            {
                                MessageBox.Show("Enter Pin Number");
                            }
                            else
                            {
                                if (ammount_PaidTextBox.Text == "")
                                {
                                    MessageBox.Show("Enter total Ammount Of Payment");
                                }


                                else
                                {
                                    this.Validate();
                                    this.paymentBindingSource.EndEdit();
                                    this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to close the payment page", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit the apllication", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
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
                errorProvider1.SetError(this.patient_IDTextBox, "Enter correct patient ID");
                return;
            }
        }

        private void card_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{1}\)?-? *\d{1}-? *-?\d{2}";
            if (Regex.IsMatch(card_NumberTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.card_NumberTextBox, "Enter Last 4 digit....");
                return;
            }
        }

        private void pin_NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{1}\)?-? *\d{1}-? *-?\d{2}";
            if (Regex.IsMatch(pin_NumberTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.pin_NumberTextBox, "enter 4 digit Pin Number");
                return;
            }
        }

        private void ammount_PaidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void method_of_PaymentComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void card_NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pin_NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void patient_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
