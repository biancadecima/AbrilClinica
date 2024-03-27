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
            pnl_title = new Panel();
            btn_restore = new PictureBox();
            btn_minimize = new PictureBox();
            btn_maximize = new PictureBox();
            btn_close = new PictureBox();
            pnl_verticalmenu = new Panel();
            pbx_menu = new PictureBox();
            btn_appointment = new Button();
            btn_apptview = new Button();
            btn_apptmngmt = new Button();
            btn_doclistview = new Button();
            btn_patientmngmt = new Button();
            pnl_container = new Panel();
            pbx_central = new PictureBox();
            pictureBox2 = new PictureBox();
            pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_restore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            pnl_verticalmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_menu).BeginInit();
            pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_central).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnl_title
            // 
            pnl_title.BackColor = SystemColors.HotTrack;
            pnl_title.Controls.Add(btn_restore);
            pnl_title.Controls.Add(btn_minimize);
            pnl_title.Controls.Add(btn_maximize);
            pnl_title.Controls.Add(btn_close);
            pnl_title.Dock = DockStyle.Top;
            pnl_title.Location = new Point(0, 0);
            pnl_title.Name = "pnl_title";
            pnl_title.Size = new Size(1300, 35);
            pnl_title.TabIndex = 3;
            pnl_title.MouseDown += pnl_title_MouseDown;
            pnl_title.MouseMove += pnl_title_MouseMove;
            pnl_title.MouseUp += pnl_title_MouseUp;
            // 
            // btn_restore
            // 
            btn_restore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_restore.Cursor = Cursors.Hand;
            btn_restore.Image = AbrilClinica.UI.Properties.Resources.minimizar;
            btn_restore.Location = new Point(1219, 4);
            btn_restore.Name = "btn_restore";
            btn_restore.Size = new Size(25, 25);
            btn_restore.SizeMode = PictureBoxSizeMode.Zoom;
            btn_restore.TabIndex = 3;
            btn_restore.TabStop = false;
            btn_restore.Visible = false;
            btn_restore.Click += btn_restore_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Image = AbrilClinica.UI.Properties.Resources.menos;
            btn_minimize.Location = new Point(1174, 4);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(25, 25);
            btn_minimize.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimize.TabIndex = 2;
            btn_minimize.TabStop = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_maximize
            // 
            btn_maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_maximize.Cursor = Cursors.Hand;
            btn_maximize.Image = AbrilClinica.UI.Properties.Resources.maximizar;
            btn_maximize.Location = new Point(1219, 4);
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(25, 25);
            btn_maximize.SizeMode = PictureBoxSizeMode.Zoom;
            btn_maximize.TabIndex = 1;
            btn_maximize.TabStop = false;
            btn_maximize.Click += btn_maximize_Click;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.Cursor = Cursors.Hand;
            btn_close.Image = AbrilClinica.UI.Properties.Resources.cerrar;
            btn_close.Location = new Point(1263, 4);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(25, 25);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 0;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // pnl_verticalmenu
            // 
            pnl_verticalmenu.BackColor = Color.FromArgb(0, 74, 173);
            pnl_verticalmenu.Controls.Add(pbx_menu);
            pnl_verticalmenu.Controls.Add(btn_appointment);
            pnl_verticalmenu.Controls.Add(btn_apptview);
            pnl_verticalmenu.Controls.Add(btn_apptmngmt);
            pnl_verticalmenu.Controls.Add(btn_doclistview);
            pnl_verticalmenu.Controls.Add(btn_patientmngmt);
            pnl_verticalmenu.Dock = DockStyle.Left;
            pnl_verticalmenu.Location = new Point(0, 35);
            pnl_verticalmenu.Name = "pnl_verticalmenu";
            pnl_verticalmenu.Size = new Size(217, 615);
            pnl_verticalmenu.TabIndex = 4;
            // 
            // pbx_menu
            // 
            pbx_menu.Image = AbrilClinica.UI.Properties.Resources.ABRIL_CLÍNICA_blanco;
            pbx_menu.InitialImage = AbrilClinica.UI.Properties.Resources.ABRIL_CLÍNICA_blanco;
            pbx_menu.Location = new Point(0, 0);
            pbx_menu.Name = "pbx_menu";
            pbx_menu.Size = new Size(220, 61);
            pbx_menu.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_menu.TabIndex = 7;
            pbx_menu.TabStop = false;
            // 
            // btn_appointment
            // 
            btn_appointment.FlatAppearance.BorderSize = 0;
            btn_appointment.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btn_appointment.FlatStyle = FlatStyle.Flat;
            btn_appointment.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_appointment.ForeColor = Color.White;
            btn_appointment.Location = new Point(3, 67);
            btn_appointment.Name = "btn_appointment";
            btn_appointment.Size = new Size(217, 32);
            btn_appointment.TabIndex = 0;
            btn_appointment.Text = "Solicitar turno";
            btn_appointment.UseVisualStyleBackColor = true;
            btn_appointment.Click += btn_appointment_Click;
            // 
            // btn_apptview
            // 
            btn_apptview.FlatAppearance.BorderSize = 0;
            btn_apptview.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btn_apptview.FlatStyle = FlatStyle.Flat;
            btn_apptview.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_apptview.ForeColor = Color.White;
            btn_apptview.Location = new Point(0, 105);
            btn_apptview.Name = "btn_apptview";
            btn_apptview.Size = new Size(217, 32);
            btn_apptview.TabIndex = 11;
            btn_apptview.Text = "Ver Mis Turnos";
            btn_apptview.UseVisualStyleBackColor = true;
            btn_apptview.Click += btn_apptview_Click;
            // 
            // btn_apptmngmt
            // 
            btn_apptmngmt.FlatAppearance.BorderSize = 0;
            btn_apptmngmt.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btn_apptmngmt.FlatStyle = FlatStyle.Flat;
            btn_apptmngmt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_apptmngmt.ForeColor = Color.White;
            btn_apptmngmt.Location = new Point(0, 116);
            btn_apptmngmt.Name = "btn_apptmngmt";
            btn_apptmngmt.Size = new Size(217, 32);
            btn_apptmngmt.TabIndex = 8;
            btn_apptmngmt.Text = "Gestionar Turnos";
            btn_apptmngmt.UseVisualStyleBackColor = true;
            btn_apptmngmt.Click += btn_apptmngmt_Click;
            // 
            // btn_doclistview
            // 
            btn_doclistview.FlatAppearance.BorderSize = 0;
            btn_doclistview.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btn_doclistview.FlatStyle = FlatStyle.Flat;
            btn_doclistview.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_doclistview.ForeColor = Color.White;
            btn_doclistview.Location = new Point(0, 143);
            btn_doclistview.Name = "btn_doclistview";
            btn_doclistview.Size = new Size(217, 32);
            btn_doclistview.TabIndex = 10;
            btn_doclistview.Text = "Ver Lista de Medicos";
            btn_doclistview.UseVisualStyleBackColor = true;
            btn_doclistview.Click += btn_doclistview_Click;
            // 
            // btn_patientmngmt
            // 
            btn_patientmngmt.FlatAppearance.BorderSize = 0;
            btn_patientmngmt.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btn_patientmngmt.FlatStyle = FlatStyle.Flat;
            btn_patientmngmt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_patientmngmt.ForeColor = Color.White;
            btn_patientmngmt.Location = new Point(3, 67);
            btn_patientmngmt.Name = "btn_patientmngmt";
            btn_patientmngmt.Size = new Size(217, 32);
            btn_patientmngmt.TabIndex = 9;
            btn_patientmngmt.Text = "Gestionar Pacientes";
            btn_patientmngmt.UseVisualStyleBackColor = true;
            btn_patientmngmt.Click += btn_patientmngmt_Click;
            // 
            // pnl_container
            // 
            pnl_container.BackColor = Color.White;
            pnl_container.Controls.Add(pbx_central);
            pnl_container.Controls.Add(pictureBox2);
            pnl_container.Dock = DockStyle.Fill;
            pnl_container.ForeColor = Color.Black;
            pnl_container.Location = new Point(217, 35);
            pnl_container.Name = "pnl_container";
            pnl_container.Size = new Size(1083, 615);
            pnl_container.TabIndex = 5;
            // 
            // pbx_central
            // 
            pbx_central.Image = AbrilClinica.UI.Properties.Resources.ABRIL_CLÍNICA_azul;
            pbx_central.Location = new Point(286, 126);
            pbx_central.Name = "pbx_central";
            pbx_central.Size = new Size(499, 328);
            pbx_central.SizeMode = PictureBoxSizeMode.Zoom;
            pbx_central.TabIndex = 7;
            pbx_central.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1095, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 650);
            Controls.Add(pnl_container);
            Controls.Add(pnl_verticalmenu);
            Controls.Add(pnl_title);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MenuForm";
            Text = "Menu Principal";
            Load += MenuForm_Load;
            pnl_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_restore).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            pnl_verticalmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_menu).EndInit();
            pnl_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_central).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
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
        private PictureBox pbx_menu;
        private PictureBox pbx_central;
    }
}