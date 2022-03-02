namespace Hospital_Management_System_Application
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOutDoc = new System.Windows.Forms.Button();
            this.btnClearDoc = new System.Windows.Forms.Button();
            this.txtPasswordDoc = new System.Windows.Forms.TextBox();
            this.txtUsernameDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoginDoc = new System.Windows.Forms.Button();
            this.btnAddDoctorDoc = new System.Windows.Forms.Button();
            this.btnPatientDoc = new System.Windows.Forms.Button();
            this.btnAppointmentDoc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnLogOutDoc);
            this.panel1.Controls.Add(this.btnClearDoc);
            this.panel1.Controls.Add(this.txtPasswordDoc);
            this.panel1.Controls.Add(this.txtUsernameDoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLoginDoc);
            this.panel1.Location = new System.Drawing.Point(241, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 511);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogOutDoc
            // 
            this.btnLogOutDoc.BackColor = System.Drawing.Color.White;
            this.btnLogOutDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutDoc.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutDoc.ForeColor = System.Drawing.Color.Black;
            this.btnLogOutDoc.Location = new System.Drawing.Point(393, 379);
            this.btnLogOutDoc.Name = "btnLogOutDoc";
            this.btnLogOutDoc.Size = new System.Drawing.Size(103, 66);
            this.btnLogOutDoc.TabIndex = 24;
            this.btnLogOutDoc.Text = "Log Out";
            this.btnLogOutDoc.UseVisualStyleBackColor = false;
            this.btnLogOutDoc.Click += new System.EventHandler(this.btnLogOutDoc_Click);
            // 
            // btnClearDoc
            // 
            this.btnClearDoc.BackColor = System.Drawing.Color.Indigo;
            this.btnClearDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDoc.Font = new System.Drawing.Font("Impact", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDoc.ForeColor = System.Drawing.Color.White;
            this.btnClearDoc.Location = new System.Drawing.Point(490, 255);
            this.btnClearDoc.Name = "btnClearDoc";
            this.btnClearDoc.Size = new System.Drawing.Size(186, 69);
            this.btnClearDoc.TabIndex = 22;
            this.btnClearDoc.Text = "Clear";
            this.btnClearDoc.UseVisualStyleBackColor = false;
            this.btnClearDoc.Click += new System.EventHandler(this.btnClearDoc_Click);
            // 
            // txtPasswordDoc
            // 
            this.txtPasswordDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordDoc.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordDoc.Location = new System.Drawing.Point(296, 143);
            this.txtPasswordDoc.Multiline = true;
            this.txtPasswordDoc.Name = "txtPasswordDoc";
            this.txtPasswordDoc.PasswordChar = '*';
            this.txtPasswordDoc.Size = new System.Drawing.Size(427, 55);
            this.txtPasswordDoc.TabIndex = 21;
            // 
            // txtUsernameDoc
            // 
            this.txtUsernameDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameDoc.Font = new System.Drawing.Font("Rockwell", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameDoc.Location = new System.Drawing.Point(296, 35);
            this.txtUsernameDoc.Multiline = true;
            this.txtUsernameDoc.Name = "txtUsernameDoc";
            this.txtUsernameDoc.Size = new System.Drawing.Size(427, 55);
            this.txtUsernameDoc.TabIndex = 18;
            this.txtUsernameDoc.TextChanged += new System.EventHandler(this.txtUsernameDoc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Marker", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 55);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 55);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username :";
            // 
            // btnLoginDoc
            // 
            this.btnLoginDoc.BackColor = System.Drawing.Color.Indigo;
            this.btnLoginDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginDoc.Font = new System.Drawing.Font("Impact", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginDoc.ForeColor = System.Drawing.Color.White;
            this.btnLoginDoc.Location = new System.Drawing.Point(218, 255);
            this.btnLoginDoc.Name = "btnLoginDoc";
            this.btnLoginDoc.Size = new System.Drawing.Size(177, 69);
            this.btnLoginDoc.TabIndex = 14;
            this.btnLoginDoc.Text = "Log In";
            this.btnLoginDoc.UseVisualStyleBackColor = false;
            this.btnLoginDoc.Click += new System.EventHandler(this.btnLoginDoc_Click);
            // 
            // btnAddDoctorDoc
            // 
            this.btnAddDoctorDoc.BackColor = System.Drawing.Color.Indigo;
            this.btnAddDoctorDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDoctorDoc.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctorDoc.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctorDoc.Location = new System.Drawing.Point(1428, 607);
            this.btnAddDoctorDoc.Name = "btnAddDoctorDoc";
            this.btnAddDoctorDoc.Size = new System.Drawing.Size(353, 69);
            this.btnAddDoctorDoc.TabIndex = 38;
            this.btnAddDoctorDoc.Text = "Add Doctor";
            this.btnAddDoctorDoc.UseVisualStyleBackColor = false;
            this.btnAddDoctorDoc.Click += new System.EventHandler(this.btnAddDoctorDoc_Click);
            // 
            // btnPatientDoc
            // 
            this.btnPatientDoc.BackColor = System.Drawing.Color.Indigo;
            this.btnPatientDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDoc.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDoc.ForeColor = System.Drawing.Color.White;
            this.btnPatientDoc.Location = new System.Drawing.Point(1428, 397);
            this.btnPatientDoc.Name = "btnPatientDoc";
            this.btnPatientDoc.Size = new System.Drawing.Size(353, 69);
            this.btnPatientDoc.TabIndex = 37;
            this.btnPatientDoc.Text = "Patients";
            this.btnPatientDoc.UseVisualStyleBackColor = false;
            this.btnPatientDoc.Click += new System.EventHandler(this.btnPatientDoc_Click);
            // 
            // btnAppointmentDoc
            // 
            this.btnAppointmentDoc.BackColor = System.Drawing.Color.Indigo;
            this.btnAppointmentDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentDoc.Font = new System.Drawing.Font("Segoe Marker", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentDoc.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentDoc.Location = new System.Drawing.Point(1428, 187);
            this.btnAppointmentDoc.Name = "btnAppointmentDoc";
            this.btnAppointmentDoc.Size = new System.Drawing.Size(353, 69);
            this.btnAppointmentDoc.TabIndex = 36;
            this.btnAppointmentDoc.Text = "See Appointment List";
            this.btnAppointmentDoc.UseVisualStyleBackColor = false;
            this.btnAppointmentDoc.Click += new System.EventHandler(this.btnAppointmentDoc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1428, 817);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 69);
            this.button1.TabIndex = 40;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Britannic Bold", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(1934, 2);
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
            this.btnMinimise.Location = new System.Drawing.Point(1862, 2);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(75, 44);
            this.btnMinimise.TabIndex = 62;
            this.btnMinimise.Text = "--";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1044);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddDoctorDoc);
            this.Controls.Add(this.btnPatientDoc);
            this.Controls.Add(this.btnAppointmentDoc);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.Text = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOutDoc;
        private System.Windows.Forms.Button btnClearDoc;
        private System.Windows.Forms.TextBox txtPasswordDoc;
        private System.Windows.Forms.TextBox txtUsernameDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoginDoc;
        private System.Windows.Forms.Button btnAddDoctorDoc;
        private System.Windows.Forms.Button btnPatientDoc;
        private System.Windows.Forms.Button btnAppointmentDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnMinimise;
    }
}