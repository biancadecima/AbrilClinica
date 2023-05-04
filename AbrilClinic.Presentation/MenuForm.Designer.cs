namespace AbrilClinic.Presentation
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.btn_restore = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_maximize = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.pnl_verticalmenu = new System.Windows.Forms.Panel();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_apptview = new System.Windows.Forms.Button();
            this.btn_doclistview = new System.Windows.Forms.Button();
            this.btn_patientmngmt = new System.Windows.Forms.Button();
            this.btn_apptmngmt = new System.Windows.Forms.Button();
            this.btn_appointment = new System.Windows.Forms.Button();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.pnl_verticalmenu.SuspendLayout();
            this.pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_title.Controls.Add(this.btn_restore);
            this.pnl_title.Controls.Add(this.btn_minimize);
            this.pnl_title.Controls.Add(this.btn_maximize);
            this.pnl_title.Controls.Add(this.btn_close);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(1300, 35);
            this.pnl_title.TabIndex = 3;
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restore.Image = ((System.Drawing.Image)(resources.GetObject("btn_restore.Image")));
            this.btn_restore.Location = new System.Drawing.Point(1219, 4);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(25, 25);
            this.btn_restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restore.TabIndex = 3;
            this.btn_restore.TabStop = false;
            this.btn_restore.Visible = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(1174, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximize.Image")));
            this.btn_maximize.Location = new System.Drawing.Point(1219, 4);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(25, 25);
            this.btn_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximize.TabIndex = 1;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1263, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_verticalmenu
            // 
            this.pnl_verticalmenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_verticalmenu.Controls.Add(this.btn_logOut);
            this.pnl_verticalmenu.Controls.Add(this.btn_apptview);
            this.pnl_verticalmenu.Controls.Add(this.btn_doclistview);
            this.pnl_verticalmenu.Controls.Add(this.btn_patientmngmt);
            this.pnl_verticalmenu.Controls.Add(this.btn_apptmngmt);
            this.pnl_verticalmenu.Controls.Add(this.btn_appointment);
            this.pnl_verticalmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_verticalmenu.Location = new System.Drawing.Point(0, 35);
            this.pnl_verticalmenu.Name = "pnl_verticalmenu";
            this.pnl_verticalmenu.Size = new System.Drawing.Size(217, 615);
            this.pnl_verticalmenu.TabIndex = 4;
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackColor = System.Drawing.Color.White;
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_logOut.Location = new System.Drawing.Point(0, 583);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(217, 32);
            this.btn_logOut.TabIndex = 12;
            this.btn_logOut.Text = "Cerrar sesión";
            this.btn_logOut.UseVisualStyleBackColor = false;
            // 
            // btn_apptview
            // 
            this.btn_apptview.FlatAppearance.BorderSize = 0;
            this.btn_apptview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_apptview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apptview.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_apptview.ForeColor = System.Drawing.Color.White;
            this.btn_apptview.Location = new System.Drawing.Point(0, 127);
            this.btn_apptview.Name = "btn_apptview";
            this.btn_apptview.Size = new System.Drawing.Size(217, 32);
            this.btn_apptview.TabIndex = 11;
            this.btn_apptview.Text = "Ver Mis Turnos";
            this.btn_apptview.UseVisualStyleBackColor = true;
            this.btn_apptview.Click += new System.EventHandler(this.btn_apptview_Click);
            // 
            // btn_doclistview
            // 
            this.btn_doclistview.FlatAppearance.BorderSize = 0;
            this.btn_doclistview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_doclistview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doclistview.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_doclistview.ForeColor = System.Drawing.Color.White;
            this.btn_doclistview.Location = new System.Drawing.Point(0, 165);
            this.btn_doclistview.Name = "btn_doclistview";
            this.btn_doclistview.Size = new System.Drawing.Size(217, 32);
            this.btn_doclistview.TabIndex = 10;
            this.btn_doclistview.Text = "Ver Lista de Medicos";
            this.btn_doclistview.UseVisualStyleBackColor = true;
            // 
            // btn_patientmngmt
            // 
            this.btn_patientmngmt.FlatAppearance.BorderSize = 0;
            this.btn_patientmngmt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_patientmngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_patientmngmt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_patientmngmt.ForeColor = System.Drawing.Color.White;
            this.btn_patientmngmt.Location = new System.Drawing.Point(0, 241);
            this.btn_patientmngmt.Name = "btn_patientmngmt";
            this.btn_patientmngmt.Size = new System.Drawing.Size(217, 32);
            this.btn_patientmngmt.TabIndex = 9;
            this.btn_patientmngmt.Text = "Gestionar Pacientes";
            this.btn_patientmngmt.UseVisualStyleBackColor = true;
            // 
            // btn_apptmngmt
            // 
            this.btn_apptmngmt.FlatAppearance.BorderSize = 0;
            this.btn_apptmngmt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_apptmngmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apptmngmt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_apptmngmt.ForeColor = System.Drawing.Color.White;
            this.btn_apptmngmt.Location = new System.Drawing.Point(0, 203);
            this.btn_apptmngmt.Name = "btn_apptmngmt";
            this.btn_apptmngmt.Size = new System.Drawing.Size(217, 32);
            this.btn_apptmngmt.TabIndex = 8;
            this.btn_apptmngmt.Text = "Gestionar Turnos";
            this.btn_apptmngmt.UseVisualStyleBackColor = true;
            // 
            // btn_appointment
            // 
            this.btn_appointment.FlatAppearance.BorderSize = 0;
            this.btn_appointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_appointment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_appointment.ForeColor = System.Drawing.Color.White;
            this.btn_appointment.Location = new System.Drawing.Point(0, 89);
            this.btn_appointment.Name = "btn_appointment";
            this.btn_appointment.Size = new System.Drawing.Size(217, 32);
            this.btn_appointment.TabIndex = 0;
            this.btn_appointment.Text = "Solicitar turno";
            this.btn_appointment.UseVisualStyleBackColor = true;
            this.btn_appointment.Click += new System.EventHandler(this.btn_appointment_Click);
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_container.Controls.Add(this.pictureBox2);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.ForeColor = System.Drawing.Color.Black;
            this.pnl_container.Location = new System.Drawing.Point(217, 35);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1083, 615);
            this.pnl_container.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1095, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_verticalmenu);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MenuForm";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.pnl_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.pnl_verticalmenu.ResumeLayout(false);
            this.pnl_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_title;
        private PictureBox btn_close;
        private Panel pnl_verticalmenu;
        private Panel pnl_container;
        private PictureBox btn_minimize;
        private PictureBox btn_maximize;
        private PictureBox pictureBox2;
        private PictureBox btn_restore;
        private Button btn_appointment;
        private Button btn_patientmngmt;
        private Button btn_apptmngmt;
        private Button btn_apptview;
        private Button btn_doclistview;
        private Button btn_logOut;
    }
}