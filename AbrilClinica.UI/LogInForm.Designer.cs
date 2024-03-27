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
            Label lbl_password;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            lbl_username = new Label();
            tbx_username = new TextBox();
            tbx_password = new TextBox();
            btn_logIn = new Button();
            lbl_title1 = new Label();
            lbl_title2 = new Label();
            btn_autofill_patient = new Button();
            btn_autofill_admin = new Button();
            pbx_show = new PictureBox();
            pbx_hide = new PictureBox();
            lbl_password = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hide).BeginInit();
            SuspendLayout();
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.Black;
            lbl_password.Location = new Point(192, 242);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(80, 17);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Contraseña:";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.Black;
            lbl_username.Location = new Point(192, 175);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(123, 17);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "Nombre de usuario:";
            // 
            // tbx_username
            // 
            tbx_username.Location = new Point(192, 195);
            tbx_username.Name = "tbx_username";
            tbx_username.Size = new Size(219, 23);
            tbx_username.TabIndex = 1;
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(192, 271);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(179, 23);
            tbx_password.TabIndex = 3;
            // 
            // btn_logIn
            // 
            btn_logIn.BackColor = Color.MidnightBlue;
            btn_logIn.Cursor = Cursors.Hand;
            btn_logIn.FlatAppearance.BorderSize = 0;
            btn_logIn.FlatStyle = FlatStyle.Flat;
            btn_logIn.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logIn.ForeColor = Color.White;
            btn_logIn.Location = new Point(192, 327);
            btn_logIn.Name = "btn_logIn";
            btn_logIn.Size = new Size(219, 33);
            btn_logIn.TabIndex = 4;
            btn_logIn.Text = "Ingresar";
            btn_logIn.UseVisualStyleBackColor = false;
            btn_logIn.Click += btn_logIn_Click;
            // 
            // lbl_title1
            // 
            lbl_title1.AutoSize = true;
            lbl_title1.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title1.ForeColor = SystemColors.ControlText;
            lbl_title1.Location = new Point(110, 79);
            lbl_title1.Name = "lbl_title1";
            lbl_title1.Size = new Size(398, 21);
            lbl_title1.TabIndex = 5;
            lbl_title1.Text = "Una cuenta, todos los servicios de Abril Clínica";
            // 
            // lbl_title2
            // 
            lbl_title2.AutoSize = true;
            lbl_title2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_title2.ForeColor = SystemColors.ControlDarkDark;
            lbl_title2.Location = new Point(130, 100);
            lbl_title2.Name = "lbl_title2";
            lbl_title2.Size = new Size(355, 17);
            lbl_title2.TabIndex = 6;
            lbl_title2.Text = "Inicia sesión para acceder a todos los Servicios Online";
            // 
            // btn_autofill_patient
            // 
            btn_autofill_patient.BackColor = Color.White;
            btn_autofill_patient.Cursor = Cursors.Hand;
            btn_autofill_patient.FlatAppearance.BorderSize = 0;
            btn_autofill_patient.FlatStyle = FlatStyle.Flat;
            btn_autofill_patient.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_autofill_patient.ForeColor = Color.MidnightBlue;
            btn_autofill_patient.Location = new Point(2, 424);
            btn_autofill_patient.Name = "btn_autofill_patient";
            btn_autofill_patient.Size = new Size(195, 23);
            btn_autofill_patient.TabIndex = 7;
            btn_autofill_patient.Text = "Relleno automático (paciente)";
            btn_autofill_patient.UseVisualStyleBackColor = false;
            btn_autofill_patient.Click += btn_autofill_patient_Click;
            // 
            // btn_autofill_admin
            // 
            btn_autofill_admin.BackColor = Color.White;
            btn_autofill_admin.Cursor = Cursors.Hand;
            btn_autofill_admin.FlatAppearance.BorderSize = 0;
            btn_autofill_admin.FlatStyle = FlatStyle.Flat;
            btn_autofill_admin.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_autofill_admin.ForeColor = Color.MidnightBlue;
            btn_autofill_admin.Location = new Point(2, 395);
            btn_autofill_admin.Name = "btn_autofill_admin";
            btn_autofill_admin.Size = new Size(179, 23);
            btn_autofill_admin.TabIndex = 8;
            btn_autofill_admin.Text = "Relleno automático (admin)";
            btn_autofill_admin.UseVisualStyleBackColor = false;
            btn_autofill_admin.Click += btn_autofill_admin_Click;
            // 
            // pbx_show
            // 
            pbx_show.Image = AbrilClinica.UI.Properties.Resources.mostrar;
            pbx_show.Location = new Point(377, 271);
            pbx_show.Name = "pbx_show";
            pbx_show.Size = new Size(43, 26);
            pbx_show.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_show.TabIndex = 9;
            pbx_show.TabStop = false;
            pbx_show.Click += pbx_show_Click;
            // 
            // pbx_hide
            // 
            pbx_hide.Image = AbrilClinica.UI.Properties.Resources.ocultar;
            pbx_hide.Location = new Point(373, 271);
            pbx_hide.Name = "pbx_hide";
            pbx_hide.Size = new Size(47, 25);
            pbx_hide.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_hide.TabIndex = 10;
            pbx_hide.TabStop = false;
            pbx_hide.Click += pbx_hide_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(615, 450);
            Controls.Add(pbx_hide);
            Controls.Add(pbx_show);
            Controls.Add(btn_autofill_admin);
            Controls.Add(btn_autofill_patient);
            Controls.Add(lbl_title2);
            Controls.Add(lbl_title1);
            Controls.Add(btn_logIn);
            Controls.Add(tbx_password);
            Controls.Add(lbl_password);
            Controls.Add(tbx_username);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            Load += LogInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_show).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_hide).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private PictureBox pbx_show;
        private PictureBox pbx_hide;
    }
}