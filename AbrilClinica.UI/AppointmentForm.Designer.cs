namespace AbrilClinica.UI
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.txb_dniPatient = new System.Windows.Forms.TextBox();
            this.cbx_specialField = new System.Windows.Forms.ComboBox();
            this.lbl_dniPatient = new System.Windows.Forms.Label();
            this.lbl_specialField = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_picture = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_request = new System.Windows.Forms.Button();
            this.dtp_appntDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txb_dniPatient
            // 
            this.txb_dniPatient.Location = new System.Drawing.Point(84, 154);
            this.txb_dniPatient.Name = "txb_dniPatient";
            this.txb_dniPatient.Size = new System.Drawing.Size(248, 23);
            this.txb_dniPatient.TabIndex = 0;
            // 
            // cbx_specialField
            // 
            this.cbx_specialField.FormattingEnabled = true;
            this.cbx_specialField.Items.AddRange(new object[] {
            "Medicina Familiar",
            "Ginecologia",
            "Nutricion",
            "Kinesiologia",
            "Obstetricia"});
            this.cbx_specialField.Location = new System.Drawing.Point(84, 217);
            this.cbx_specialField.Name = "cbx_specialField";
            this.cbx_specialField.Size = new System.Drawing.Size(248, 23);
            this.cbx_specialField.TabIndex = 1;
            // 
            // lbl_dniPatient
            // 
            this.lbl_dniPatient.AutoSize = true;
            this.lbl_dniPatient.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dniPatient.Location = new System.Drawing.Point(84, 134);
            this.lbl_dniPatient.Name = "lbl_dniPatient";
            this.lbl_dniPatient.Size = new System.Drawing.Size(93, 17);
            this.lbl_dniPatient.TabIndex = 3;
            this.lbl_dniPatient.Text = "Ingrese su DNI:";
            // 
            // lbl_specialField
            // 
            this.lbl_specialField.AutoSize = true;
            this.lbl_specialField.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_specialField.Location = new System.Drawing.Point(84, 197);
            this.lbl_specialField.Name = "lbl_specialField";
            this.lbl_specialField.Size = new System.Drawing.Size(174, 17);
            this.lbl_specialField.TabIndex = 4;
            this.lbl_specialField.Text = "Seleccione la especialidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Elija la fecha:";
            // 
            // pnl_picture
            // 
            this.pnl_picture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnl_picture.BackgroundImage = AbrilClinica.UI.Properties.Resources.appnt_panel;
            this.pnl_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_picture.Location = new System.Drawing.Point(456, -7);
            this.pnl_picture.Name = "pnl_picture";
            this.pnl_picture.Size = new System.Drawing.Size(628, 628);
            this.pnl_picture.TabIndex = 6;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(37, 81);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(369, 22);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Solicite su turno completando los datos.";
            // 
            // btn_request
            // 
            this.btn_request.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_request.FlatAppearance.BorderSize = 0;
            this.btn_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_request.ForeColor = System.Drawing.Color.White;
            this.btn_request.Location = new System.Drawing.Point(84, 423);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(248, 33);
            this.btn_request.TabIndex = 8;
            this.btn_request.Text = "Solicitar turno";
            this.btn_request.UseVisualStyleBackColor = false;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // dtp_appntDate
            // 
            this.dtp_appntDate.Location = new System.Drawing.Point(84, 283);
            this.dtp_appntDate.Name = "dtp_appntDate";
            this.dtp_appntDate.Size = new System.Drawing.Size(248, 23);
            this.dtp_appntDate.TabIndex = 9;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 615);
            this.Controls.Add(this.dtp_appntDate);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_picture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_specialField);
            this.Controls.Add(this.lbl_dniPatient);
            this.Controls.Add(this.cbx_specialField);
            this.Controls.Add(this.txb_dniPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentForm";
            this.Text = "Solicitar Turno";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_dniPatient;
        private ComboBox cbx_specialField;
        private Label lbl_dniPatient;
        private Label lbl_specialField;
        private Label label1;
        private Panel pnl_picture;
        private Label lbl_title;
        private Button btn_request;
        private DateTimePicker dtp_appntDate;
    }
}