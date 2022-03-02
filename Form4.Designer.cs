namespace Hospital_Management_System_Application
{
    partial class Form4
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
            System.Windows.Forms.Label nurse_IDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label middle_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label e_mail_AddressLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label contact_NoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label postal_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label area_CodeLabel;
            System.Windows.Forms.Label marital_StatusLabel;
            System.Windows.Forms.Label cuntryLabel;
            System.Windows.Forms.Label stateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.hospitalDataSet = new Hospital_Management_System_Application.HospitalDataSet();
            this.nurseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nurseTableAdapter = new Hospital_Management_System_Application.HospitalDataSetTableAdapters.NurseTableAdapter();
            this.tableAdapterManager = new Hospital_Management_System_Application.HospitalDataSetTableAdapters.TableAdapterManager();
            this.nurse_IDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.middle_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.e_mail_AddressTextBox = new System.Windows.Forms.TextBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contact_NoTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.postal_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nurseDataGridView = new System.Windows.Forms.DataGridView();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.area_CodeComboBox = new System.Windows.Forms.ComboBox();
            this.marital_StatusComboBox = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry2 = new System.Windows.Forms.ComboBox();
            this.comboBoxstate2 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnX = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.nurse1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            nurse_IDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            middle_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            e_mail_AddressLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            contact_NoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            postal_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            area_CodeLabel = new System.Windows.Forms.Label();
            marital_StatusLabel = new System.Windows.Forms.Label();
            cuntryLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurse1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nurse_IDLabel
            // 
            nurse_IDLabel.AutoSize = true;
            nurse_IDLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nurse_IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            nurse_IDLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            nurse_IDLabel.Location = new System.Drawing.Point(288, 97);
            nurse_IDLabel.Name = "nurse_IDLabel";
            nurse_IDLabel.Size = new System.Drawing.Size(121, 38);
            nurse_IDLabel.TabIndex = 1;
            nurse_IDLabel.Text = "Nurse ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            first_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            first_NameLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            first_NameLabel.Location = new System.Drawing.Point(263, 151);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(146, 38);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // middle_NameLabel
            // 
            middle_NameLabel.AutoSize = true;
            middle_NameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            middle_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            middle_NameLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            middle_NameLabel.Location = new System.Drawing.Point(235, 205);
            middle_NameLabel.Name = "middle_NameLabel";
            middle_NameLabel.Size = new System.Drawing.Size(173, 38);
            middle_NameLabel.TabIndex = 5;
            middle_NameLabel.Text = "Middle Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            last_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            last_NameLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            last_NameLabel.Location = new System.Drawing.Point(268, 258);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(141, 38);
            last_NameLabel.TabIndex = 7;
            last_NameLabel.Text = "Last Name:";
            // 
            // e_mail_AddressLabel
            // 
            e_mail_AddressLabel.AutoSize = true;
            e_mail_AddressLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            e_mail_AddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            e_mail_AddressLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            e_mail_AddressLabel.Location = new System.Drawing.Point(215, 313);
            e_mail_AddressLabel.Name = "e_mail_AddressLabel";
            e_mail_AddressLabel.Size = new System.Drawing.Size(191, 38);
            e_mail_AddressLabel.TabIndex = 9;
            e_mail_AddressLabel.Text = "E-mail Address:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dOBLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dOBLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            dOBLabel.Location = new System.Drawing.Point(333, 421);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(74, 38);
            dOBLabel.TabIndex = 13;
            dOBLabel.Text = "DOB:";
            // 
            // contact_NoLabel
            // 
            contact_NoLabel.AutoSize = true;
            contact_NoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            contact_NoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            contact_NoLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            contact_NoLabel.Location = new System.Drawing.Point(259, 529);
            contact_NoLabel.Name = "contact_NoLabel";
            contact_NoLabel.Size = new System.Drawing.Size(147, 38);
            contact_NoLabel.TabIndex = 17;
            contact_NoLabel.Text = "Contact No:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            addressLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            addressLabel.Location = new System.Drawing.Point(294, 637);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(112, 38);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "Address:";
            // 
            // postal_CodeLabel
            // 
            postal_CodeLabel.AutoSize = true;
            postal_CodeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            postal_CodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            postal_CodeLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            postal_CodeLabel.Location = new System.Drawing.Point(251, 691);
            postal_CodeLabel.Name = "postal_CodeLabel";
            postal_CodeLabel.Size = new System.Drawing.Size(154, 38);
            postal_CodeLabel.TabIndex = 23;
            postal_CodeLabel.Text = "Postal Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            cityLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            cityLabel.Location = new System.Drawing.Point(339, 853);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(66, 38);
            cityLabel.TabIndex = 29;
            cityLabel.Text = "City:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dateLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            dateLabel.Location = new System.Drawing.Point(330, 907);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(76, 38);
            dateLabel.TabIndex = 31;
            dateLabel.Text = "Date:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            genderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            genderLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            genderLabel.Location = new System.Drawing.Point(304, 367);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(104, 38);
            genderLabel.TabIndex = 43;
            genderLabel.Text = "Gender:";
            // 
            // area_CodeLabel
            // 
            area_CodeLabel.AutoSize = true;
            area_CodeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            area_CodeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            area_CodeLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            area_CodeLabel.Location = new System.Drawing.Point(269, 475);
            area_CodeLabel.Name = "area_CodeLabel";
            area_CodeLabel.Size = new System.Drawing.Size(138, 38);
            area_CodeLabel.TabIndex = 44;
            area_CodeLabel.Text = "Area Code:";
            // 
            // marital_StatusLabel
            // 
            marital_StatusLabel.AutoSize = true;
            marital_StatusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            marital_StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            marital_StatusLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            marital_StatusLabel.Location = new System.Drawing.Point(226, 583);
            marital_StatusLabel.Name = "marital_StatusLabel";
            marital_StatusLabel.Size = new System.Drawing.Size(180, 38);
            marital_StatusLabel.TabIndex = 45;
            marital_StatusLabel.Text = "Marital Status:";
            // 
            // cuntryLabel
            // 
            cuntryLabel.AutoSize = true;
            cuntryLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cuntryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            cuntryLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            cuntryLabel.Location = new System.Drawing.Point(307, 745);
            cuntryLabel.Name = "cuntryLabel";
            cuntryLabel.Size = new System.Drawing.Size(97, 38);
            cuntryLabel.TabIndex = 46;
            cuntryLabel.Text = "Cuntry:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            stateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            stateLabel.Font = new System.Drawing.Font("Segoe Marker", 13F);
            stateLabel.Location = new System.Drawing.Point(326, 800);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(80, 38);
            stateLabel.TabIndex = 47;
            stateLabel.Text = "State:";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nurseBindingSource
            // 
            this.nurseBindingSource.DataMember = "Nurse";
            this.nurseBindingSource.DataSource = this.hospitalDataSet;
            // 
            // nurseTableAdapter
            // 
            this.nurseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.MedicineTableAdapter = null;
            this.tableAdapterManager.NurseTableAdapter = this.nurseTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hospital_Management_System_Application.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nurse_IDTextBox
            // 
            this.nurse_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Nurse_ID", true));
            this.nurse_IDTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurse_IDTextBox.Location = new System.Drawing.Point(492, 97);
            this.nurse_IDTextBox.MaxLength = 4;
            this.nurse_IDTextBox.Name = "nurse_IDTextBox";
            this.nurse_IDTextBox.Size = new System.Drawing.Size(200, 40);
            this.nurse_IDTextBox.TabIndex = 2;
            this.nurse_IDTextBox.TextChanged += new System.EventHandler(this.nurse_IDTextBox_TextChanged);
            this.nurse_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP21);
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "First_Name", true));
            this.first_NameTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_NameTextBox.Location = new System.Drawing.Point(492, 150);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(200, 40);
            this.first_NameTextBox.TabIndex = 4;
            this.first_NameTextBox.TextChanged += new System.EventHandler(this.first_NameTextBox_TextChanged);
            this.first_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP24);
            // 
            // middle_NameTextBox
            // 
            this.middle_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Middle_Name", true));
            this.middle_NameTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle_NameTextBox.Location = new System.Drawing.Point(492, 203);
            this.middle_NameTextBox.Name = "middle_NameTextBox";
            this.middle_NameTextBox.Size = new System.Drawing.Size(200, 40);
            this.middle_NameTextBox.TabIndex = 6;
            this.middle_NameTextBox.TextChanged += new System.EventHandler(this.middle_NameTextBox_TextChanged);
            this.middle_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP25);
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Last_Name", true));
            this.last_NameTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_NameTextBox.Location = new System.Drawing.Point(492, 256);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(200, 40);
            this.last_NameTextBox.TabIndex = 8;
            this.last_NameTextBox.TextChanged += new System.EventHandler(this.last_NameTextBox_TextChanged);
            this.last_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP26);
            // 
            // e_mail_AddressTextBox
            // 
            this.e_mail_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "E-mail_Address", true));
            this.e_mail_AddressTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_mail_AddressTextBox.Location = new System.Drawing.Point(491, 309);
            this.e_mail_AddressTextBox.Name = "e_mail_AddressTextBox";
            this.e_mail_AddressTextBox.Size = new System.Drawing.Size(200, 40);
            this.e_mail_AddressTextBox.TabIndex = 10;
            this.e_mail_AddressTextBox.TextChanged += new System.EventHandler(this.e_mail_AddressTextBox_TextChanged);
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nurseBindingSource, "DOB", true));
            this.dOBDateTimePicker.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBDateTimePicker.Location = new System.Drawing.Point(490, 416);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(200, 40);
            this.dOBDateTimePicker.TabIndex = 14;
            // 
            // contact_NoTextBox
            // 
            this.contact_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Contact_No", true));
            this.contact_NoTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_NoTextBox.Location = new System.Drawing.Point(489, 523);
            this.contact_NoTextBox.MaxLength = 10;
            this.contact_NoTextBox.Name = "contact_NoTextBox";
            this.contact_NoTextBox.Size = new System.Drawing.Size(200, 40);
            this.contact_NoTextBox.TabIndex = 18;
            this.contact_NoTextBox.TextChanged += new System.EventHandler(this.contact_NoTextBox_TextChanged);
            this.contact_NoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP22);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(488, 630);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 40);
            this.addressTextBox.TabIndex = 22;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // postal_CodeTextBox
            // 
            this.postal_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Postal_Code", true));
            this.postal_CodeTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postal_CodeTextBox.Location = new System.Drawing.Point(488, 683);
            this.postal_CodeTextBox.MaxLength = 6;
            this.postal_CodeTextBox.Name = "postal_CodeTextBox";
            this.postal_CodeTextBox.Size = new System.Drawing.Size(200, 40);
            this.postal_CodeTextBox.TabIndex = 24;
            this.postal_CodeTextBox.TextChanged += new System.EventHandler(this.postal_CodeTextBox_TextChanged);
            this.postal_CodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP23);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(488, 844);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 40);
            this.cityTextBox.TabIndex = 30;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            this.cityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP31);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nurseBindingSource, "Date", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDateTimePicker.Location = new System.Drawing.Point(488, 897);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 40);
            this.dateDateTimePicker.TabIndex = 32;
            // 
            // nurseDataGridView
            // 
            this.nurseDataGridView.AutoGenerateColumns = false;
            this.nurseDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.nurseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn16});
            this.nurseDataGridView.DataSource = this.nurseBindingSource;
            this.nurseDataGridView.Location = new System.Drawing.Point(809, 97);
            this.nurseDataGridView.Name = "nurseDataGridView";
            this.nurseDataGridView.RowTemplate.Height = 31;
            this.nurseDataGridView.Size = new System.Drawing.Size(1176, 840);
            this.nurseDataGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nurse_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nurse_ID";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "E-mail_Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "E-mail_Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn7.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Area_Code";
            this.dataGridViewTextBoxColumn8.HeaderText = "Area_Code";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Contact_No";
            this.dataGridViewTextBoxColumn9.HeaderText = "Contact_No";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Marital_Status";
            this.dataGridViewTextBoxColumn10.HeaderText = "Marital_Status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Postal_Code";
            this.dataGridViewTextBoxColumn12.HeaderText = "Postal_Code";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Cuntry";
            this.dataGridViewTextBoxColumn13.HeaderText = "Cuntry";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn14.HeaderText = "State";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn15.HeaderText = "City";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn16.HeaderText = "Date";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Indigo;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1384, 999);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 69);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Indigo;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(710, 999);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 69);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Indigo;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(927, 999);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 69);
            this.btnNext.TabIndex = 39;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Indigo;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(1134, 999);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(186, 69);
            this.btnPrevious.TabIndex = 40;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Indigo;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1591, 999);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 69);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Indigo;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1798, 999);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 69);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(503, 999);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 69);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Gender", true));
            this.genderComboBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "N/A"});
            this.genderComboBox.Location = new System.Drawing.Point(490, 362);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 41);
            this.genderComboBox.TabIndex = 44;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            this.genderComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP27);
            // 
            // area_CodeComboBox
            // 
            this.area_CodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Area_Code", true));
            this.area_CodeComboBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.area_CodeComboBox.Location = new System.Drawing.Point(490, 469);
            this.area_CodeComboBox.MaxLength = 3;
            this.area_CodeComboBox.Name = "area_CodeComboBox";
            this.area_CodeComboBox.Size = new System.Drawing.Size(200, 41);
            this.area_CodeComboBox.TabIndex = 45;
            this.area_CodeComboBox.SelectedIndexChanged += new System.EventHandler(this.area_CodeComboBox_SelectedIndexChanged);
            // 
            // marital_StatusComboBox
            // 
            this.marital_StatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Marital_Status", true));
            this.marital_StatusComboBox.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marital_StatusComboBox.FormattingEnabled = true;
            this.marital_StatusComboBox.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Separated",
            "Widowed"});
            this.marital_StatusComboBox.Location = new System.Drawing.Point(488, 576);
            this.marital_StatusComboBox.Name = "marital_StatusComboBox";
            this.marital_StatusComboBox.Size = new System.Drawing.Size(200, 41);
            this.marital_StatusComboBox.TabIndex = 46;
            this.marital_StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.marital_StatusComboBox_SelectedIndexChanged);
            this.marital_StatusComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP28);
            // 
            // comboBoxCountry2
            // 
            this.comboBoxCountry2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "Cuntry", true));
            this.comboBoxCountry2.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCountry2.FormattingEnabled = true;
            this.comboBoxCountry2.Items.AddRange(new object[] {
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
            this.comboBoxCountry2.Location = new System.Drawing.Point(488, 736);
            this.comboBoxCountry2.Name = "comboBoxCountry2";
            this.comboBoxCountry2.Size = new System.Drawing.Size(200, 41);
            this.comboBoxCountry2.TabIndex = 47;
            this.comboBoxCountry2.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry2_SelectedIndexChanged);
            this.comboBoxCountry2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP29);
            // 
            // comboBoxstate2
            // 
            this.comboBoxstate2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nurseBindingSource, "State", true));
            this.comboBoxstate2.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxstate2.FormattingEnabled = true;
            this.comboBoxstate2.Items.AddRange(new object[] {
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
            this.comboBoxstate2.Location = new System.Drawing.Point(488, 790);
            this.comboBoxstate2.Name = "comboBoxstate2";
            this.comboBoxstate2.Size = new System.Drawing.Size(200, 41);
            this.comboBoxstate2.TabIndex = 48;
            this.comboBoxstate2.SelectedIndexChanged += new System.EventHandler(this.comboBoxstate2_SelectedIndexChanged);
            this.comboBoxstate2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KP30);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Britannic Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(1908, 1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 44);
            this.btnX.TabIndex = 63;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.Location = new System.Drawing.Point(1832, 1);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(75, 44);
            this.btnMinimise.TabIndex = 62;
            this.btnMinimise.Text = "--";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // nurse1BindingSource
            // 
            this.nurse1BindingSource.DataMember = "Nurse1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.comboBoxstate2);
            this.Controls.Add(cuntryLabel);
            this.Controls.Add(this.comboBoxCountry2);
            this.Controls.Add(marital_StatusLabel);
            this.Controls.Add(this.marital_StatusComboBox);
            this.Controls.Add(area_CodeLabel);
            this.Controls.Add(this.area_CodeComboBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nurseDataGridView);
            this.Controls.Add(nurse_IDLabel);
            this.Controls.Add(this.nurse_IDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(middle_NameLabel);
            this.Controls.Add(this.middle_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(e_mail_AddressLabel);
            this.Controls.Add(this.e_mail_AddressTextBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(contact_NoLabel);
            this.Controls.Add(this.contact_NoTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(postal_CodeLabel);
            this.Controls.Add(this.postal_CodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nurse1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource nurseBindingSource;
        private HospitalDataSetTableAdapters.NurseTableAdapter nurseTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nurse_IDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox middle_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox e_mail_AddressTextBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox contact_NoTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox postal_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DataGridView nurseDataGridView;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource nurse1BindingSource;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox area_CodeComboBox;
        private System.Windows.Forms.ComboBox marital_StatusComboBox;
        private System.Windows.Forms.ComboBox comboBoxCountry2;
        private System.Windows.Forms.ComboBox comboBoxstate2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMinimise;
    }
}