namespace AbrilClinic.Presentation
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbl_password;
            this.lbl_username = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.btn_autofill_patient = new System.Windows.Forms.Button();
            this.btn_autofill_admin = new System.Windows.Forms.Button();
            lbl_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_password.ForeColor = System.Drawing.Color.Black;
            lbl_password.Location = new System.Drawing.Point(192, 242);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new System.Drawing.Size(80, 17);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Contraseña:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(192, 175);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(123, 17);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Nombre de usuario:";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(192, 195);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(219, 23);
            this.tbx_username.TabIndex = 1;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(192, 262);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(219, 23);
            this.tbx_password.TabIndex = 3;
            // 
            // btn_logIn
            // 
            this.btn_logIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_logIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logIn.FlatAppearance.BorderSize = 0;
            this.btn_logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logIn.ForeColor = System.Drawing.Color.White;
            this.btn_logIn.Location = new System.Drawing.Point(192, 327);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(219, 33);
            this.btn_logIn.TabIndex = 4;
            this.btn_logIn.Text = "Ingresar";
            this.btn_logIn.UseVisualStyleBackColor = false;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // lbl_title1
            // 
            this.lbl_title1.AutoSize = true;
            this.lbl_title1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_title1.Location = new System.Drawing.Point(110, 79);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(398, 21);
            this.lbl_title1.TabIndex = 5;
            this.lbl_title1.Text = "Una cuenta, todos los servicios de Abril Clínica";
            // 
            // lbl_title2
            // 
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_title2.Location = new System.Drawing.Point(130, 100);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(355, 17);
            this.lbl_title2.TabIndex = 6;
            this.lbl_title2.Text = "Inicia sesión para acceder a todos los Servicios Online";
            // 
            // btn_autofill_patient
            // 
            this.btn_autofill_patient.BackColor = System.Drawing.Color.White;
            this.btn_autofill_patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_autofill_patient.FlatAppearance.BorderSize = 0;
            this.btn_autofill_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autofill_patient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_autofill_patient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_autofill_patient.Location = new System.Drawing.Point(2, 424);
            this.btn_autofill_patient.Name = "btn_autofill_patient";
            this.btn_autofill_patient.Size = new System.Drawing.Size(195, 23);
            this.btn_autofill_patient.TabIndex = 7;
            this.btn_autofill_patient.Text = "Relleno automático (paciente)";
            this.btn_autofill_patient.UseVisualStyleBackColor = false;
            this.btn_autofill_patient.Click += new System.EventHandler(this.btn_autofill_patient_Click);
            // 
            // btn_autofill_admin
            // 
            this.btn_autofill_admin.BackColor = System.Drawing.Color.White;
            this.btn_autofill_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_autofill_admin.FlatAppearance.BorderSize = 0;
            this.btn_autofill_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_autofill_admin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_autofill_admin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_autofill_admin.Location = new System.Drawing.Point(2, 395);
            this.btn_autofill_admin.Name = "btn_autofill_admin";
            this.btn_autofill_admin.Size = new System.Drawing.Size(179, 23);
            this.btn_autofill_admin.TabIndex = 8;
            this.btn_autofill_admin.Text = "Relleno automático (admin)";
            this.btn_autofill_admin.UseVisualStyleBackColor = false;
            this.btn_autofill_admin.Click += new System.EventHandler(this.btn_autofill_admin_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btn_autofill_admin);
            this.Controls.Add(this.btn_autofill_patient);
            this.Controls.Add(this.lbl_title2);
            this.Controls.Add(this.lbl_title1);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(lbl_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_username;
        private TextBox tbx_username;
        private Label lbl_password;
        private TextBox tbx_password;
        private Button btn_logIn;
        private Label lbl_title1;
        private Label lbl_title2;
        private Button btn_autofill_patient;
        private Button btn_autofill_admin;
    }
}