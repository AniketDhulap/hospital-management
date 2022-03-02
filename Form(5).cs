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
    public partial class Form_5_ : Form
    {
        public Form_5_()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form_5__Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet.Patient);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (patien_IDTextBox.Text == "" || first_NameTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || admin_DateDateTimePicker.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || date_of_BirthDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || countryComboBox.Text == "" || countryComboBox.Text == "" || cityTextBox.Text == "" || discharge_DateDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Fill the All Details......");

            }
            else
            {
                this.patientBindingSource.AddNew();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (patien_IDTextBox.Text == "")
            {
                MessageBox.Show("Enter the Patient ID....");

            }
            else
            {
                if (first_NameTextBox.Text == "")
                {
                    MessageBox.Show("Enter The First Name");

                }
                else
                {
                    if (middle_NameTextBox.Text == "")
                    {
                        MessageBox.Show("Enter the Middle Name");
                    }
                    else
                    {
                        if (last_NameTextBox.Text == "")
                        {
                            MessageBox.Show("Enter the Last Name");
                        }
                        else
                        {
                            if (admin_DateDateTimePicker.Text == "")
                            {
                                MessageBox.Show("Select Date From Combo Box....");
                            }
                            else
                            {
                                if (e_mail_AddressTextBox.Text == "")
                                {
                                    MessageBox.Show("Enter Email Address");
                                }
                                else
                                {
                                    if (genderComboBox.Text == "")
                                    {
                                        MessageBox.Show("Choose The Gender From box");
                                    }
                                    else
                                    {
                                        if (date_of_BirthDateTimePicker.Text == "")
                                        {
                                            MessageBox.Show("Select Date OF Birth");
                                        }

                                        else
                                        {
                                            if (area_CodeComboBox.Text == "")
                                            {
                                                MessageBox.Show("Choose Area Code From Box");
                                            }
                                            else
                                            {
                                                if (contact_NoTextBox.Text == "")
                                                {
                                                    MessageBox.Show("Enter Contact Number");
                                                }
                                                else
                                                {

                                                    if
                                                        (marital_StatusComboBox.Text == "")
                                                    {
                                                        MessageBox.Show("Choose The Status From Boxx");
                                                    }
                                                    else
                                                    {
                                                        if (addressTextBox.Text == "")
                                                        {
                                                            MessageBox.Show("Enter Address");
                                                        }
                                                        else
                                                        {
                                                            if (postal_CodeTextBox.Text == "")
                                                            {
                                                                MessageBox.Show("Enter Pincode of your Area");
                                                            }
                                                            else
                                                            {
                                                                if (countryComboBox.Text == "")
                                                                {
                                                                    MessageBox.Show("Choose The Country From Box");
                                                                }
                                                                else
                                                                {
                                                                    if (countryComboBox.Text == "")
                                                                    {
                                                                        MessageBox.Show("Choose the State From Box");
                                                                    }

                                                                    else
                                                                    {
                                                                        if (cityTextBox.Text == "")
                                                                        {
                                                                            MessageBox.Show("Enter City Name");
                                                                        }
                                                                        else
                                                                        {
                                                                            if (discharge_DateDateTimePicker.Text == "")
                                                                            {
                                                                                MessageBox.Show("Select Date.....From Boxx");
                                                                            }

                                                                            else
                                                                            {
                                                                                this.patientBindingSource.AddNew();
                                                                            }


                                                                        }

                                                                    }

                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            this.patientBindingSource.RemoveCurrent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (patien_IDTextBox.Text == "" || first_NameTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || admin_DateDateTimePicker.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || date_of_BirthDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || countryComboBox.Text == "" || countryComboBox.Text == "" || cityTextBox.Text == "" || discharge_DateDateTimePicker.Text == "")
            {
                MessageBox.Show("Please Wait........");
                this.patientBindingSource.RemoveCurrent();

            }
            else
            {
                this.patientBindingSource.MovePrevious();
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (patien_IDTextBox.Text == "" || first_NameTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || admin_DateDateTimePicker.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || date_of_BirthDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || countryComboBox.Text == "" || countryComboBox.Text == "" || cityTextBox.Text == "" || discharge_DateDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait.........");
                this.patientBindingSource.RemoveCurrent();

            }
            else
            {
                this.patientBindingSource.MoveNext();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (patien_IDTextBox.Text == "")
            {
                MessageBox.Show("Enter the Patient ID....");

            }
            else
            {
                if (first_NameTextBox.Text == "")
                {
                    MessageBox.Show("Enter The First Name");

                }
                else
                {
                    if (middle_NameTextBox.Text == "")
                    {
                        MessageBox.Show("Enter the Middle Name");
                    }
                    else
                    {
                        if (last_NameTextBox.Text == "")
                        {
                            MessageBox.Show("Enter the Last Name");
                        }
                        else
                        {
                            if (admin_DateDateTimePicker.Text == "")
                            {
                                MessageBox.Show("Select Date From Combo Box....");
                            }
                            else
                            {
                                if (e_mail_AddressTextBox.Text == "")
                                {
                                    MessageBox.Show("Enter Email Address");
                                }
                                else
                                {
                                    if (genderComboBox.Text == "")
                                    {
                                        MessageBox.Show("Choose The Gender From box");
                                    }
                                    else
                                    {
                                        if (date_of_BirthDateTimePicker.Text == "")
                                        {
                                            MessageBox.Show("Select Date OF Birth");
                                        }

                                        else
                                        {
                                            if (area_CodeComboBox.Text == "")
                                            {
                                                MessageBox.Show("Choose Area Code From Box");
                                            }
                                            else
                                            {
                                                if (contact_NoTextBox.Text == "")
                                                {
                                                    MessageBox.Show("Enter Contact Number");
                                                }
                                                else
                                                {

                                                    if
                                                        (marital_StatusComboBox.Text == "")
                                                    {
                                                        MessageBox.Show("Choose The Status From Boxx");
                                                    }
                                                    else
                                                    {
                                                        if (addressTextBox.Text == "")
                                                        {
                                                            MessageBox.Show("Enter Address");
                                                        }
                                                        else
                                                        {
                                                            if (postal_CodeTextBox.Text == "")
                                                            {
                                                                MessageBox.Show("Enter Pincode of your Area");
                                                            }
                                                            else
                                                            {
                                                                if (countryComboBox.Text == "")
                                                                {
                                                                    MessageBox.Show("Choose The Country From Box");
                                                                }
                                                                else
                                                                {
                                                                    if (countryComboBox.Text == "")
                                                                    {
                                                                        MessageBox.Show("Choose the State From Box");
                                                                    }

                                                                    else
                                                                    {
                                                                        if (cityTextBox.Text == "")
                                                                        {
                                                                            MessageBox.Show("Enter City Name");
                                                                        }
                                                                        else
                                                                        {
                                                                            if (discharge_DateDateTimePicker.Text == "")
                                                                            {
                                                                                MessageBox.Show("Select Date.....From Boxx");
                                                                            }

                                                                            else
                                                                            {
                                                                                this.Validate();
                                                                                this.patientBindingSource.EndEdit();
                                                                                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                                                                            }


                                                                        }

                                                                    }

                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
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
            iExit = MessageBox.Show("Confirm if you want to close the patients page", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit the application....", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void patien_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{0}\)?-? *\d{0}-? *-?\d{1}";
            if (Regex.IsMatch(patien_IDTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.patien_IDTextBox, "Enter enter sequentially and correct ID");
                return;
            }
        }

        private void first_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(first_NameTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.first_NameTextBox, "Plzzz provide correct name");
                return;
            }
        }

        private void middle_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(middle_NameTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.middle_NameTextBox, "Plzzz provide correct name");
                return;
            }
        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(last_NameTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.last_NameTextBox, "Plzzz provide correct name");
                return;
            }
        }

        private void e_mail_AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(e_mail_AddressTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.e_mail_AddressTextBox, "Plzzz provide valid Mail address");
                return;
            }
        }

        private void date_of_BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderComboBox.SelectedItem == null)
            {
                errorProvider1.SetError(genderComboBox, "Please Select the Items From the Combobox!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void contact_NoTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{1}\)?-? *\d{1}-? *-?\d{2}";
            if (Regex.IsMatch(contact_NoTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.contact_NoTextBox, "Enter Ref Number....");
                return;
            }
        }

        private void marital_StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(marital_StatusComboBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.marital_StatusComboBox, "Plzzz provide correct status from boxx....");
                return;
            }
        }

        private void postal_CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{2}\)?-? *\d{2}-? *-?\d{2}";
            if (Regex.IsMatch(postal_CodeTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.postal_CodeTextBox, "Enter Correct postal code");
                return;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(cityTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.cityTextBox, "Plzzz provide correct name");
                return;
            }
        }

        private void KK1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KKK1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void LL(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KL(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R4(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R5(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R6(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void R7(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want close", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.MoveLast();
        }
    }
}
