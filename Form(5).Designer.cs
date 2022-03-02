namespace Hospital_Management_System_Application
{
    partial class Form_5_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label patien_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label middle_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label admin_DateLabel;
            System.Windows.Forms.Label e_mail_AddressLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label area_CodeLabel;
            System.Windows.Forms.Label contact_NoLabel;
            System.Windows.Forms.Label marital_StatusLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label postal_CodeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label discharge_DateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_5_));
            this.hospitalDataSet = new Hospital_Management_System_Application.HospitalDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Hospital_Management_System_Application.HospitalDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new Hospital_Management_System_Application.HospitalDataSetTableAdapters.TableAdapterManager();
            this.patien_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.middle_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.admin_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.e_mail_AddressTextBox = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.date_of_BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.area_CodeComboBox = new System.Windows.Forms.ComboBox();
            this.contact_NoTextBox = new System.Windows.Forms.TextBox();
            this.marital_StatusComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.postal_CodeTextBox = new System.Windows.Forms.TextBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.discharge_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnX = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            patien_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            middle_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            admin_DateLabel = new System.Windows.Forms.Label();
            e_mail_AddressLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            area_CodeLabel = new System.Windows.Forms.Label();
            contact_NoLabel = new System.Windows.Forms.Label();
            marital_StatusLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            postal_CodeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            discharge_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // patien_IDLabel
            // 
            patien_IDLabel.AutoSize = true;
            patien_IDLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            patien_IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            patien_IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            patien_IDLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patien_IDLabel.Location = new System.Drawing.Point(304, 78);
            patien_IDLabel.Name = "patien_IDLabel";
            patien_IDLabel.Size = new System.Drawing.Size(109, 33);
            patien_IDLabel.TabIndex = 1;
            patien_IDLabel.Text = "Patien ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            first_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            first_NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            first_NameLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_NameLabel.Location = new System.Drawing.Point(289, 135);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(127, 33);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // middle_NameLabel
            // 
            middle_NameLabel.AutoSize = true;
            middle_NameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            middle_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            middle_NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            middle_NameLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            middle_NameLabel.Location = new System.Drawing.Point(264, 192);
            middle_NameLabel.Name = "middle_NameLabel";
            middle_NameLabel.Size = new System.Drawing.Size(150, 33);
            middle_NameLabel.TabIndex = 5;
            middle_NameLabel.Text = "Middle Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            last_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            last_NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            last_NameLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_NameLabel.Location = new System.Drawing.Point(291, 249);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(123, 33);
            last_NameLabel.TabIndex = 7;
            last_NameLabel.Text = "Last Name:";
            // 
            // admin_DateLabel
            // 
            admin_DateLabel.AutoSize = true;
            admin_DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            admin_DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            admin_DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            admin_DateLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            admin_DateLabel.Location = new System.Drawing.Point(277, 306);
            admin_DateLabel.Name = "admin_DateLabel";
            admin_DateLabel.Size = new System.Drawing.Size(135, 33);
            admin_DateLabel.TabIndex = 9;
            admin_DateLabel.Text = "Admin Date:";
            // 
            // e_mail_AddressLabel
            // 
            e_mail_AddressLabel.AutoSize = true;
            e_mail_AddressLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            e_mail_AddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            e_mail_AddressLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            e_mail_AddressLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            e_mail_AddressLabel.Location = new System.Drawing.Point(246, 363);
            e_mail_AddressLabel.Name = "e_mail_AddressLabel";
            e_mail_AddressLabel.Size = new System.Drawing.Size(166, 33);
            e_mail_AddressLabel.TabIndex = 11;
            e_mail_AddressLabel.Text = "E-mail Address:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            genderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            genderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            genderLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(321, 420);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(91, 33);
            genderLabel.TabIndex = 13;
            genderLabel.Text = "Gender:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            date_of_BirthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            date_of_BirthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            date_of_BirthLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_of_BirthLabel.Location = new System.Drawing.Point(266, 477);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(146, 33);
            date_of_BirthLabel.TabIndex = 15;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // area_CodeLabel
            // 
            area_CodeLabel.AutoSize = true;
            area_CodeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            area_CodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            area_CodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            area_CodeLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_CodeLabel.Location = new System.Drawing.Point(292, 534);
            area_CodeLabel.Name = "area_CodeLabel";
            area_CodeLabel.Size = new System.Drawing.Size(120, 33);
            area_CodeLabel.TabIndex = 17;
            area_CodeLabel.Text = "Area Code:";
            // 
            // contact_NoLabel
            // 
            contact_NoLabel.AutoSize = true;
            contact_NoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            contact_NoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            contact_NoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            contact_NoLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contact_NoLabel.Location = new System.Drawing.Point(252, 591);
            contact_NoLabel.Name = "contact_NoLabel";
            contact_NoLabel.Size = new System.Drawing.Size(160, 33);
            contact_NoLabel.TabIndex = 19;
            contact_NoLabel.Text = "Patient_Ref_ID";
            // 
            // marital_StatusLabel
            // 
            marital_StatusLabel.AutoSize = true;
            marital_StatusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            marital_StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            marital_StatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            marital_StatusLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marital_StatusLabel.Location = new System.Drawing.Point(256, 648);
            marital_StatusLabel.Name = "marital_StatusLabel";
            marital_StatusLabel.Size = new System.Drawing.Size(156, 33);
            marital_StatusLabel.TabIndex = 21;
            marital_StatusLabel.Text = "Marital Status:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            addressLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addressLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(314, 705);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(97, 33);
            addressLabel.TabIndex = 23;
            addressLabel.Text = "Address:";
            // 
            // postal_CodeLabel
            // 
            postal_CodeLabel.AutoSize = true;
            postal_CodeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            postal_CodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            postal_CodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            postal_CodeLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postal_CodeLabel.Location = new System.Drawing.Point(278, 762);
            postal_CodeLabel.Name = "postal_CodeLabel";
            postal_CodeLabel.Size = new System.Drawing.Size(134, 33);
            postal_CodeLabel.TabIndex = 25;
            postal_CodeLabel.Text = "Postal Code:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            countryLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            countryLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(313, 819);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(97, 33);
            countryLabel.TabIndex = 27;
            countryLabel.Text = "Country:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            stateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            stateLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(342, 876);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(70, 33);
            stateLabel.TabIndex = 29;
            stateLabel.Text = "State:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            cityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cityLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(354, 933);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(58, 33);
            cityLabel.TabIndex = 31;
            cityLabel.Text = "City:";
            // 
            // discharge_DateLabel
            // 
            discharge_DateLabel.AutoSize = true;
            discharge_DateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            discharge_DateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            discharge_DateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            discharge_DateLabel.Font = new System.Drawing.Font("Segoe Marker", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discharge_DateLabel.Location = new System.Drawing.Point(244, 990);
            discharge_DateLabel.Name = "discharge_DateLabel";
            discharge_DateLabel.Size = new System.Drawing.Size(167, 33);
            discharge_DateLabel.TabIndex = 33;
            discharge_DateLabel.Text = "Discharge Date:";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.MedicineTableAdapter = null;
            this.tableAdapterManager.NurseTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital_Management_System_Application.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patien_IDTextBox
            // 
            this.patien_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Patien_ID", true));
            this.patien_IDTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patien_IDTextBox.Location = new System.Drawing.Point(496, 77);
            this.patien_IDTextBox.MaxLength = 4;
            this.patien_IDTextBox.Name = "patien_IDTextBox";
            this.patien_IDTextBox.Size = new System.Drawing.Size(269, 34);
            this.patien_IDTextBox.TabIndex = 2;
            this.patien_IDTextBox.TextChanged += new System.EventHandler(this.patien_IDTextBox_TextChanged);
            this.patien_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KK1);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "First_Name", true));
            this.first_NameTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_NameTextBox.Location = new System.Drawing.Point(494, 133);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(269, 34);
            this.first_NameTextBox.TabIndex = 4;
            this.first_NameTextBox.TextChanged += new System.EventHandler(this.first_NameTextBox_TextChanged);
            this.first_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R1);
            // 
            // middle_NameTextBox
            // 
            this.middle_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Middle_Name", true));
            this.middle_NameTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_NameTextBox.Location = new System.Drawing.Point(494, 189);
            this.middle_NameTextBox.Name = "middle_NameTextBox";
            this.middle_NameTextBox.Size = new System.Drawing.Size(269, 34);
            this.middle_NameTextBox.TabIndex = 6;
            this.middle_NameTextBox.TextChanged += new System.EventHandler(this.middle_NameTextBox_TextChanged);
            this.middle_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R2);
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Last_Name", true));
            this.last_NameTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_NameTextBox.Location = new System.Drawing.Point(494, 245);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(269, 34);
            this.last_NameTextBox.TabIndex = 8;
            this.last_NameTextBox.TextChanged += new System.EventHandler(this.last_NameTextBox_TextChanged);
            this.last_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R3);
            // 
            // admin_DateDateTimePicker
            // 
            this.admin_DateDateTimePicker.CustomFormat = "dd-MM-yyyy ";
            this.admin_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Admin_Date", true));
            this.admin_DateDateTimePicker.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.admin_DateDateTimePicker.Location = new System.Drawing.Point(494, 301);
            this.admin_DateDateTimePicker.Name = "admin_DateDateTimePicker";
            this.admin_DateDateTimePicker.Size = new System.Drawing.Size(269, 34);
            this.admin_DateDateTimePicker.TabIndex = 10;
            // 
            // e_mail_AddressTextBox
            // 
            this.e_mail_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "E-mail_Address", true));
            this.e_mail_AddressTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mail_AddressTextBox.Location = new System.Drawing.Point(494, 357);
            this.e_mail_AddressTextBox.Name = "e_mail_AddressTextBox";
            this.e_mail_AddressTextBox.Size = new System.Drawing.Size(269, 34);
            this.e_mail_AddressTextBox.TabIndex = 12;
            this.e_mail_AddressTextBox.TextChanged += new System.EventHandler(this.e_mail_AddressTextBox_TextChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Gender", true));
            this.genderComboBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "N/A"});
            this.genderComboBox.Location = new System.Drawing.Point(494, 413);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(269, 34);
            this.genderComboBox.TabIndex = 14;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R4);
            // 
            // date_of_BirthDateTimePicker
            // 
            this.date_of_BirthDateTimePicker.CustomFormat = "dd-MM-yyyy ";
            this.date_of_BirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Date_of_Birth", true));
            this.date_of_BirthDateTimePicker.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_of_BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_of_BirthDateTimePicker.Location = new System.Drawing.Point(494, 472);
            this.date_of_BirthDateTimePicker.Name = "date_of_BirthDateTimePicker";
            this.date_of_BirthDateTimePicker.Size = new System.Drawing.Size(269, 34);
            this.date_of_BirthDateTimePicker.TabIndex = 16;
            this.date_of_BirthDateTimePicker.ValueChanged += new System.EventHandler(this.date_of_BirthDateTimePicker_ValueChanged);
            // 
            // area_CodeComboBox
            // 
            this.area_CodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Area_Code", true));
            this.area_CodeComboBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_CodeComboBox.FormattingEnabled = true;
            this.area_CodeComboBox.Items.AddRange(new object[] {
            "+93",
            "+1",
            "+54",
            "+61",
            "+43",
            "+32",
            "+55",
            "+95",
            "+34",
            "+56",
            "+86",
            "+61",
            "+53",
            "+45",
            "+56",
            "+20",
            "+44",
            "+33",
            "+49",
            "+30",
            "+57",
            "+44",
            "+36",
            "+91",
            "+62",
            "+98",
            "+44",
            "+39",
            "+7",
            "+60"});
            this.area_CodeComboBox.Location = new System.Drawing.Point(494, 528);
            this.area_CodeComboBox.MaxLength = 3;
            this.area_CodeComboBox.Name = "area_CodeComboBox";
            this.area_CodeComboBox.Size = new System.Drawing.Size(269, 34);
            this.area_CodeComboBox.TabIndex = 18;
            this.area_CodeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KKK1);
            // 
            // contact_NoTextBox
            // 
            this.contact_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Contact_No", true));
            this.contact_NoTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_NoTextBox.Location = new System.Drawing.Point(493, 587);
            this.contact_NoTextBox.MaxLength = 4;
            this.contact_NoTextBox.Name = "contact_NoTextBox";
            this.contact_NoTextBox.Size = new System.Drawing.Size(269, 34);
            this.contact_NoTextBox.TabIndex = 20;
            this.contact_NoTextBox.TextChanged += new System.EventHandler(this.contact_NoTextBox_TextChanged);
            this.contact_NoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KL);
            // 
            // marital_StatusComboBox
            // 
            this.marital_StatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Marital_Status", true));
            this.marital_StatusComboBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marital_StatusComboBox.FormattingEnabled = true;
            this.marital_StatusComboBox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Separated",
            "Widowed"});
            this.marital_StatusComboBox.Location = new System.Drawing.Point(493, 643);
            this.marital_StatusComboBox.Name = "marital_StatusComboBox";
            this.marital_StatusComboBox.Size = new System.Drawing.Size(269, 34);
            this.marital_StatusComboBox.TabIndex = 22;
            this.marital_StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.marital_StatusComboBox_SelectedIndexChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(493, 702);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(269, 34);
            this.addressTextBox.TabIndex = 24;
            // 
            // postal_CodeTextBox
            // 
            this.postal_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Postal_Code", true));
            this.postal_CodeTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postal_CodeTextBox.Location = new System.Drawing.Point(493, 758);
            this.postal_CodeTextBox.MaxLength = 6;
            this.postal_CodeTextBox.Name = "postal_CodeTextBox";
            this.postal_CodeTextBox.Size = new System.Drawing.Size(269, 34);
            this.postal_CodeTextBox.TabIndex = 26;
            this.postal_CodeTextBox.TextChanged += new System.EventHandler(this.postal_CodeTextBox_TextChanged);
            this.postal_CodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LL);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Country", true));
            this.countryComboBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Bangladesh",
            "Brazil",
            "Canada",
            "Australia",
            "France",
            "India",
            "Japan",
            "Pakistan",
            "United Kingdom",
            "USA"});
            this.countryComboBox.Location = new System.Drawing.Point(492, 814);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(269, 34);
            this.countryComboBox.TabIndex = 28;
            this.countryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R7);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "State", true));
            this.stateComboBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "Barisal",
            "Chittagong",
            "Dhaka",
            "Khulna",
            "Rajshahi",
            "ROngpur",
            "Federal",
            "Ceara",
            "Bahia",
            "Amapa",
            "Amazonas",
            "Acre",
            "Columbia",
            "Alberta",
            "Manitoba",
            "Ontario",
            "Queensland",
            "Victori",
            "Tasmania",
            "South Austrailia",
            "Sydney",
            "Lorraine",
            "Picardie",
            "Alsace",
            "Haute Normandie",
            "Bourgogne",
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharahstra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odhisa",
            "Punjab",
            "Rajastan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Alabama",
            "Alaska",
            "Arizon",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Shizuoka",
            "Fukuoka",
            "Hokkaido",
            "Saitama",
            "Hyogo",
            "Chiba",
            "Aichi",
            "Kanagawa",
            "Punjab",
            "Sindh",
            "Khyber Pakhtunkhwa",
            "Balochistan",
            "London",
            "West Midlands",
            "Greater Manchester",
            "West Yorkshire",
            "South Yorkshire",
            "Hampshire",
            "Surrey",
            "Merseyside"});
            this.stateComboBox.Location = new System.Drawing.Point(490, 873);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(269, 34);
            this.stateComboBox.TabIndex = 30;
            this.stateComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R6);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(491, 932);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(269, 34);
            this.cityTextBox.TabIndex = 32;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            this.cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R5);
            // 
            // discharge_DateDateTimePicker
            // 
            this.discharge_DateDateTimePicker.CustomFormat = "dd-MM-yyyy ";
            this.discharge_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientBindingSource, "Discharge_Date", true));
            this.discharge_DateDateTimePicker.Font = new System.Drawing.Font("Segoe Marker", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discharge_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.discharge_DateDateTimePicker.Location = new System.Drawing.Point(489, 988);
            this.discharge_DateDateTimePicker.Name = "discharge_DateDateTimePicker";
            this.discharge_DateDateTimePicker.Size = new System.Drawing.Size(269, 34);
            this.discharge_DateDateTimePicker.TabIndex = 34;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            this.patientDataGridView.Location = new System.Drawing.Point(830, 77);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.RowTemplate.Height = 31;
            this.patientDataGridView.Size = new System.Drawing.Size(1184, 762);
            this.patientDataGridView.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Patien_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Patien_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Middle_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Middle_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Admin_Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Admin_Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "E-mail_Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "E-mail_Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date_of_Birth";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date_of_Birth";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Area_Code";
            this.dataGridViewTextBoxColumn9.HeaderText = "Area_Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Contact_No";
            this.dataGridViewTextBoxColumn10.HeaderText = "Contact_No";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Marital_Status";
            this.dataGridViewTextBoxColumn11.HeaderText = "Marital_Status";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Postal_Code";
            this.dataGridViewTextBoxColumn13.HeaderText = "Postal_Code";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn14.HeaderText = "Country";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn15.HeaderText = "State";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn16.HeaderText = "City";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Discharge_Date";
            this.dataGridViewTextBoxColumn17.HeaderText = "Discharge_Date";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Indigo;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1817, 967);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 66);
            this.btnClose.TabIndex = 51;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Indigo;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1476, 967);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 62);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Indigo;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(1137, 967);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(145, 61);
            this.btnPrevious.TabIndex = 50;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Indigo;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(1323, 967);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 61);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Indigo;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(961, 967);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 61);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(792, 967);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 62);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Indigo;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1638, 967);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 62);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Britannic Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(1350, -74);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 44);
            this.btnX.TabIndex = 65;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.Location = new System.Drawing.Point(1274, -74);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(75, 44);
            this.btnMinimise.TabIndex = 64;
            this.btnMinimise.Text = "--";
            this.btnMinimise.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1927, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 67;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1851, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 66;
            this.button2.Text = "--";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_5_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1948, 1108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(patien_IDLabel);
            this.Controls.Add(this.patien_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(middle_NameLabel);
            this.Controls.Add(this.middle_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(admin_DateLabel);
            this.Controls.Add(this.admin_DateDateTimePicker);
            this.Controls.Add(e_mail_AddressLabel);
            this.Controls.Add(this.e_mail_AddressTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthDateTimePicker);
            this.Controls.Add(area_CodeLabel);
            this.Controls.Add(this.area_CodeComboBox);
            this.Controls.Add(contact_NoLabel);
            this.Controls.Add(this.contact_NoTextBox);
            this.Controls.Add(marital_StatusLabel);
            this.Controls.Add(this.marital_StatusComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(postal_CodeLabel);
            this.Controls.Add(this.postal_CodeTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(discharge_DateLabel);
            this.Controls.Add(this.discharge_DateDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_5_";
            this.Text = "Form_5_";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_5__Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox patien_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox middle_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.DateTimePicker admin_DateDateTimePicker;
        private System.Windows.Forms.TextBox e_mail_AddressTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker date_of_BirthDateTimePicker;
        private System.Windows.Forms.ComboBox area_CodeComboBox;
        private System.Windows.Forms.TextBox contact_NoTextBox;
        private System.Windows.Forms.ComboBox marital_StatusComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox postal_CodeTextBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker discharge_DateDateTimePicker;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMinimise;
    }
}