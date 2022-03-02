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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.hospitalDataSet.Appointment);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (appointment_Ref_NoTextBox.Text == "")
            {
                MessageBox.Show("Enter the Appointment Ref No....");

            }
            else
            {
                if (first_NmaeTextBox.Text == "")
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
                                                    MessageBox.Show("Choose The Marital Status From Boxx");
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
                                                            if (comboBoxCountry1.Text == "")
                                                            {
                                                                MessageBox.Show("Choose The Country From Box");
                                                            }
                                                            else
                                                            {
                                                                if (comboBoxstate1.Text == "")
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
                                                                        if (doctor_NameTextBox.Text == "")
                                                                        {
                                                                            MessageBox.Show("Enter Doctor Name");
                                                                        }
                                                                        else
                                                                        {
                                                                            if (doctor_Ref_NoTextBox.Text == "")
                                                                            {
                                                                                MessageBox.Show("Enter Dr Ref Number ");
                                                                            }
                                                                            else
                                                                            {
                                                                                if (date_TimeDateTimePicker.Text == "")
                                                                                {
                                                                                    MessageBox.Show("Chooose the Date From Combobox");
                                                                                }
                                                                                else
                                                                                {
                                                                                    this.appointmentBindingSource.AddNew();
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
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.appointmentBindingSource.RemoveCurrent();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (appointment_Ref_NoTextBox.Text == "" || first_NmaeTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || date_of_BirthDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || comboBoxCountry1.Text == "" || comboBoxstate1.Text == "" || cityTextBox.Text == "" || doctor_NameTextBox.Text == "" || doctor_Ref_NoTextBox.Text == "" || date_TimeDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait..........");
                this.appointmentBindingSource.RemoveCurrent();
            }
            else
            {
                this.appointmentBindingSource.MoveNext();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (appointment_Ref_NoTextBox.Text == "" || first_NmaeTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || date_of_BirthDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || comboBoxCountry1.Text == "" || comboBoxstate1.Text == "" || cityTextBox.Text == "" || doctor_NameTextBox.Text == "" || doctor_Ref_NoTextBox.Text == "" || date_TimeDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait..........");
                this.appointmentBindingSource.RemoveCurrent();
            }
            else
            {
                this.appointmentBindingSource.MovePrevious();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (appointment_Ref_NoTextBox.Text == "")
            {
                MessageBox.Show("Fill The All Details.....");

            }
            else
            {
                if (first_NmaeTextBox.Text == "")
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
                                                    MessageBox.Show("Choose The Marital Status From Boxx");
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
                                                            if (comboBoxCountry1.Text == "")
                                                            {
                                                                MessageBox.Show("Choose The Country From Box");
                                                            }
                                                            else
                                                            {
                                                                if (comboBoxstate1.Text == "")
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
                                                                        if (doctor_NameTextBox.Text == "")
                                                                        {
                                                                            MessageBox.Show("Enter Doctor Name");
                                                                        }
                                                                        else
                                                                        {
                                                                            if (doctor_Ref_NoTextBox.Text == "")
                                                                            {
                                                                                MessageBox.Show("Enter Dr Ref Number ");
                                                                            }
                                                                            else
                                                                            {
                                                                                if (date_TimeDateTimePicker.Text == "")
                                                                                {
                                                                                    MessageBox.Show("Chooose the Date From Combobox");
                                                                                }
                                                                                else
                                                                                {
                                                                                    this.Validate();
                                                                                    this.appointmentBindingSource.EndEdit();
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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to close the appointment page", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
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

        private void comboBoxCountry1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

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

        private void first_NmaeTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(first_NmaeTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.first_NmaeTextBox, "Plzzz provide correct name");
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
                errorProvider1.SetError(this.middle_NameTextBox, "Enter Correct Middle Name");
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
                errorProvider1.SetError(this.last_NameTextBox, "Enter Correct Last Name");
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
                errorProvider1.SetError(this.cityTextBox, "Enter Correct City Name");
                return;
            }
        }

        private void doctor_NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(doctor_NameTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.doctor_NameTextBox, "Enter Correct Doctor Name");
                return;
            }
        }

        private void contact_NoTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            if (Regex.IsMatch(contact_NoTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.contact_NoTextBox, "Enter Correct Contact Number");
                return;
            }
        }

        private void appointment_Ref_NoTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{0}\)?-? *\d{0}-? *-?\d{1}";
            if (Regex.IsMatch(appointment_Ref_NoTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.appointment_Ref_NoTextBox, "Enter sequencially and Correct Ref No");
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
                errorProvider1.SetError(this.postal_CodeTextBox, "Enter correct postal Code");
                return;
            }

        }

        private void doctor_Ref_NoTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{0}\)?-? *\d{0}-? *-?\d{1}";
            if (Regex.IsMatch(doctor_Ref_NoTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.doctor_Ref_NoTextBox, "Enter Correct Ref No");
                return;
            }
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (appointment_Ref_NoTextBox.Text == "" || first_NmaeTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || date_of_BirthDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || comboBoxCountry1.Text == "" || comboBoxstate1.Text == "" || cityTextBox.Text == "" || doctor_NameTextBox.Text == "" || doctor_Ref_NoTextBox.Text == "" || date_TimeDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Fill the All Details......");

            }
            else
            {
                this.appointmentBindingSource.AddNew();
            }


        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KeyPr(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KeyPress2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP2(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP3(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP4(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP5(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP7(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP6(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP8(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP9(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void date_TimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_of_BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void area_CodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                errorProvider1.SetError(this.marital_StatusComboBox, "Plzzz provide correct status.....");
                return;
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxstate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void KeyPress22(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

    }
}