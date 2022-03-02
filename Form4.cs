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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void nurseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nurseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.Nurse' table. You can move, or remove it, as needed.
            this.nurseTableAdapter.Fill(this.hospitalDataSet.Nurse);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (nurse_IDTextBox.Text == "")
            {
                MessageBox.Show("Enter the Nurse ID....");

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
                                    if (dOBDateTimePicker.Text == "")
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
                                                    MessageBox.Show("Choose The Status Frem Boxx");
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
                                                            if (comboBoxCountry2.Text == "")
                                                            {
                                                                MessageBox.Show("Choose The Country From Box");
                                                            }
                                                            else
                                                            {
                                                                if (comboBoxstate2.Text == "")
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
                                                                        if(dateDateTimePicker.Text =="")
                                                                        {
                                                                            MessageBox.Show("Select Date.....From Boxx");
                                                                        }
                                                                        
                                                                        else
                                                                        {
                                                                                 this.nurseBindingSource.AddNew();
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
            this.nurseBindingSource.RemoveCurrent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nurse_IDTextBox.Text == "" || first_NameTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || dOBDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || comboBoxCountry2.Text == "" || comboBoxstate2.Text == "" || cityTextBox.Text == "" || dateDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait........");
                this.nurseBindingSource.RemoveCurrent();
            }
            else
            {
                this.nurseBindingSource.MoveNext();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (nurse_IDTextBox.Text == "" || first_NameTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || dOBDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || comboBoxCountry2.Text == "" || comboBoxstate2.Text == "" || cityTextBox.Text == "" || dateDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Wait........");
                this.nurseBindingSource.RemoveCurrent();
            }
            else
            {
                this.nurseBindingSource.MovePrevious();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (nurse_IDTextBox.Text == "")
            {
                MessageBox.Show("Enter the  Nurse ID....");

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
                                    if (dOBDateTimePicker.Text == "")
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
                                                            if (comboBoxCountry2.Text == "")
                                                            {
                                                                MessageBox.Show("Choose The Country From Box");
                                                            }
                                                            else
                                                            {
                                                                if (comboBoxstate2.Text == "")
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
                                                                        if(dateDateTimePicker.Text =="")
                                                                        {
                                                                            MessageBox.Show("Select Date.....From Boxx");
                                                                        }
                                                                        
                                                                        else
                                                                        {
                                                                                 this.Validate();
                                                                                 this.nurseBindingSource.EndEdit();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to close the nurse page", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (nurse_IDTextBox.Text == "" || first_NameTextBox.Text == "" || middle_NameTextBox.Text == "" || last_NameTextBox.Text == "" || e_mail_AddressTextBox.Text == "" || genderComboBox.Text == "" || dOBDateTimePicker.Text == "" || area_CodeComboBox.Text == "" || marital_StatusComboBox.Text == "" || contact_NoTextBox.Text == "" || addressTextBox.Text == "" || postal_CodeTextBox.Text == "" || comboBoxCountry2.Text == "" || comboBoxstate2.Text == "" || cityTextBox.Text == "" || dateDateTimePicker.Text == "")
            {
                MessageBox.Show("Plzzzzz Fill the All Details......");

            }
            else
            {
                this.nurseBindingSource.AddNew();
            }
        }

        private void nurse_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\(?\d{0}\)?-? *\d{0}-? *-?\d{1}";
            if (Regex.IsMatch(nurse_IDTextBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.nurse_IDTextBox, "Enter sequencially and Correcct Nurse ID.....");
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

        private void marital_StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pattern = @"^([A-z-a-z][a-z-a-z][a-z-a-z]+)$";
            if (Regex.IsMatch(marital_StatusComboBox.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.marital_StatusComboBox, "Plzzz provide correct detail from box...");
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
                errorProvider1.SetError(this.postal_CodeTextBox, "Enter correct postal code.....");
                return;
            }
        }

        private void comboBoxCountry2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxstate2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void area_CodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KP21(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP22(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP23(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP24(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP25(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP26(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP27(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP28(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP29(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP30(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KP31(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
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
    }
}
