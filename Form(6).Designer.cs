namespace Hospital_Management_System_Application
{
    partial class Form_6_
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
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label date_TimeLabel;
            System.Windows.Forms.Label method_of_PaymentLabel;
            System.Windows.Forms.Label card_NumberLabel;
            System.Windows.Forms.Label pin_NumberLabel;
            System.Windows.Forms.Label ammount_PaidLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_6_));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.hospitalDataSet = new Hospital_Management_System_Application.HospitalDataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Hospital_Management_System_Application.HospitalDataSetTableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new Hospital_Management_System_Application.HospitalDataSetTableAdapters.TableAdapterManager();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.date_TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.method_of_PaymentComboBox = new System.Windows.Forms.ComboBox();
            this.card_NumberTextBox = new System.Windows.Forms.TextBox();
            this.pin_NumberTextBox = new System.Windows.Forms.TextBox();
            this.ammount_PaidTextBox = new System.Windows.Forms.TextBox();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            patient_IDLabel = new System.Windows.Forms.Label();
            date_TimeLabel = new System.Windows.Forms.Label();
            method_of_PaymentLabel = new System.Windows.Forms.Label();
            card_NumberLabel = new System.Windows.Forms.Label();
            pin_NumberLabel = new System.Windows.Forms.Label();
            ammount_PaidLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            patient_IDLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            patient_IDLabel.Font = new System.Drawing.Font("Segoe Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(259, 240);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(152, 42);
            patient_IDLabel.TabIndex = 66;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // date_TimeLabel
            // 
            date_TimeLabel.AutoSize = true;
            date_TimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            date_TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            date_TimeLabel.Font = new System.Drawing.Font("Segoe Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            date_TimeLabel.Location = new System.Drawing.Point(253, 327);
            date_TimeLabel.Name = "date_TimeLabel";
            date_TimeLabel.Size = new System.Drawing.Size(156, 42);
            date_TimeLabel.TabIndex = 68;
            date_TimeLabel.Text = "Date Time:";
            // 
            // method_of_PaymentLabel
            // 
            method_of_PaymentLabel.AutoSize = true;
            method_of_PaymentLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            method_of_PaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            method_of_PaymentLabel.Font = new System.Drawing.Font("Segoe Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            method_of_PaymentLabel.Location = new System.Drawing.Point(129, 414);
            method_of_PaymentLabel.Name = "method_of_PaymentLabel";
            method_of_PaymentLabel.Size = new System.Drawing.Size(275, 42);
            method_of_PaymentLabel.TabIndex = 70;
            method_of_PaymentLabel.Text = "Method of Payment:";
            // 
            // card_NumberLabel
            // 
            card_NumberLabel.AutoSize = true;
            card_NumberLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            card_NumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            card_NumberLabel.Font = new System.Drawing.Font("Segoe Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            card_NumberLabel.Location = new System.Drawing.Point(210, 501);
            card_NumberLabel.Name = "card_NumberLabel";
            card_NumberLabel.Size = new System.Drawing.Size(196, 42);
            card_NumberLabel.TabIndex = 72;
            card_NumberLabel.Text = "Card Number:";
            // 
            // pin_NumberLabel
            // 
            pin_NumberLabel.AutoSize = true;
            pin_NumberLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            pin_NumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pin_NumberLabel.Font = new System.Drawing.Font("Segoe Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pin_NumberLabel.Location = new System.Drawing.Point(229, 588);
            pin_NumberLabel.Name = "pin_NumberLabel";
            pin_NumberLabel.Size = new System.Drawing.Size(177, 42);
            pin_NumberLabel.TabIndex = 74;
            pin_NumberLabel.Text = "Pin Number:";
            // 
            // ammount_PaidLabel
            // 
            ammount_PaidLabel.AutoSize = true;
            ammount_PaidLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ammount_PaidLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            ammount_PaidLabel.Font = new System.Drawing.Font("Segoe Marker", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ammount_PaidLabel.Location = new System.Drawing.Point(192, 675);
            ammount_PaidLabel.Name = "ammount_PaidLabel";
            ammount_PaidLabel.Size = new System.Drawing.Size(213, 42);
            ammount_PaidLabel.TabIndex = 76;
            ammount_PaidLabel.Text = "Ammount Paid:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Segoe Marker", 27F);
            label1.ForeColor = System.Drawing.Color.Indigo;
            label1.Location = new System.Drawing.Point(1431, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(397, 219);
            label1.TabIndex = 78;
            label1.Text = "We Think....\r\n     About You.....\r\n\r\n";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Indigo;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1737, 904);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 69);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Indigo;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1540, 904);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 69);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Indigo;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1343, 904);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 69);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Indigo;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe Marker", 16F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(1088, 904);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(186, 69);
            this.btnPrevious.TabIndex = 47;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Indigo;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(891, 904);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(128, 69);
            this.btnNext.TabIndex = 46;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Indigo;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe Marker", 16F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(684, 904);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 69);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Indigo;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(487, 904);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 69);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Britannic Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(1932, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 44);
            this.btnX.TabIndex = 65;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimise.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.Location = new System.Drawing.Point(1856, 2);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(75, 44);
            this.btnMinimise.TabIndex = 64;
            this.btnMinimise.Text = "--";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.hospitalDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.MedicineTableAdapter = null;
            this.tableAdapterManager.NurseTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hospital_Management_System_Application.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient_ID", true));
            this.patient_IDTextBox.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_IDTextBox.Location = new System.Drawing.Point(493, 240);
            this.patient_IDTextBox.MaxLength = 4;
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(268, 46);
            this.patient_IDTextBox.TabIndex = 67;
            this.patient_IDTextBox.TextChanged += new System.EventHandler(this.patient_IDTextBox_TextChanged);
            this.patient_IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_IDTextBox_KeyPress);
            // 
            // date_TimeDateTimePicker
            // 
            this.date_TimeDateTimePicker.CustomFormat = " ";
            this.date_TimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.paymentBindingSource, "Date_Time", true));
            this.date_TimeDateTimePicker.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_TimeDateTimePicker.Location = new System.Drawing.Point(493, 326);
            this.date_TimeDateTimePicker.Name = "date_TimeDateTimePicker";
            this.date_TimeDateTimePicker.Size = new System.Drawing.Size(268, 46);
            this.date_TimeDateTimePicker.TabIndex = 69;
            this.date_TimeDateTimePicker.ValueChanged += new System.EventHandler(this.date_TimeDateTimePicker_ValueChanged);
            this.date_TimeDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_TimeDateTimePicker_KeyDown);
            // 
            // method_of_PaymentComboBox
            // 
            this.method_of_PaymentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Method_of_Payment", true));
            this.method_of_PaymentComboBox.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method_of_PaymentComboBox.FormattingEnabled = true;
            this.method_of_PaymentComboBox.Items.AddRange(new object[] {
            "Visa Card",
            "Debit Card",
            "Master Card",
            "Creadit Card",
            "Visa Debit",
            "Cash Paid"});
            this.method_of_PaymentComboBox.Location = new System.Drawing.Point(493, 412);
            this.method_of_PaymentComboBox.Name = "method_of_PaymentComboBox";
            this.method_of_PaymentComboBox.Size = new System.Drawing.Size(268, 47);
            this.method_of_PaymentComboBox.TabIndex = 71;
            this.method_of_PaymentComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.method_of_PaymentComboBox_KeyPress);
            // 
            // card_NumberTextBox
            // 
            this.card_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Card_Number", true));
            this.card_NumberTextBox.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_NumberTextBox.Location = new System.Drawing.Point(492, 499);
            this.card_NumberTextBox.MaxLength = 4;
            this.card_NumberTextBox.Name = "card_NumberTextBox";
            this.card_NumberTextBox.Size = new System.Drawing.Size(268, 46);
            this.card_NumberTextBox.TabIndex = 73;
            this.card_NumberTextBox.TextChanged += new System.EventHandler(this.card_NumberTextBox_TextChanged);
            this.card_NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.card_NumberTextBox_KeyPress);
            // 
            // pin_NumberTextBox
            // 
            this.pin_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Pin_Number", true));
            this.pin_NumberTextBox.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_NumberTextBox.Location = new System.Drawing.Point(491, 585);
            this.pin_NumberTextBox.MaxLength = 4;
            this.pin_NumberTextBox.Name = "pin_NumberTextBox";
            this.pin_NumberTextBox.Size = new System.Drawing.Size(268, 46);
            this.pin_NumberTextBox.TabIndex = 75;
            this.pin_NumberTextBox.TextChanged += new System.EventHandler(this.pin_NumberTextBox_TextChanged);
            this.pin_NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pin_NumberTextBox_KeyPress);
            // 
            // ammount_PaidTextBox
            // 
            this.ammount_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Ammount_Paid", true));
            this.ammount_PaidTextBox.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammount_PaidTextBox.Location = new System.Drawing.Point(489, 672);
            this.ammount_PaidTextBox.Name = "ammount_PaidTextBox";
            this.ammount_PaidTextBox.Size = new System.Drawing.Size(268, 46);
            this.ammount_PaidTextBox.TabIndex = 77;
            this.ammount_PaidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ammount_PaidTextBox_KeyPress);
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AutoGenerateColumns = false;
            this.paymentDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.paymentDataGridView.DataSource = this.paymentBindingSource;
            this.paymentDataGridView.Location = new System.Drawing.Point(829, 240);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.RowTemplate.Height = 31;
            this.paymentDataGridView.Size = new System.Drawing.Size(1178, 482);
            this.paymentDataGridView.TabIndex = 77;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Patient_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Patient_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date_Time";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date_Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Method_of_Payment";
            this.dataGridViewTextBoxColumn3.HeaderText = "Method_of_Payment";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Card_Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Card_Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pin_Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pin_Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ammount_Paid";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ammount_Paid";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_6_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1948, 1108);
            this.Controls.Add(label1);
            this.Controls.Add(this.paymentDataGridView);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(date_TimeLabel);
            this.Controls.Add(this.date_TimeDateTimePicker);
            this.Controls.Add(method_of_PaymentLabel);
            this.Controls.Add(this.method_of_PaymentComboBox);
            this.Controls.Add(card_NumberLabel);
            this.Controls.Add(this.card_NumberTextBox);
            this.Controls.Add(pin_NumberLabel);
            this.Controls.Add(this.pin_NumberTextBox);
            this.Controls.Add(ammount_PaidLabel);
            this.Controls.Add(this.ammount_PaidTextBox);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_6_";
            this.Text = "Form_6_";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_6__Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMinimise;
        private HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private HospitalDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.DateTimePicker date_TimeDateTimePicker;
        private System.Windows.Forms.ComboBox method_of_PaymentComboBox;
        private System.Windows.Forms.TextBox card_NumberTextBox;
        private System.Windows.Forms.TextBox pin_NumberTextBox;
        private System.Windows.Forms.TextBox ammount_PaidTextBox;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}