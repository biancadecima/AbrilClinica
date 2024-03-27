namespace AbrilClinica.UI
{
    partial class AppointmentDMForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txb_dniPatient = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_appointments = new System.Windows.Forms.DataGridView();
            this.dtp_appntDate = new System.Windows.Forms.DateTimePicker();
            this.cbx_specialField = new System.Windows.Forms.ComboBox();
            this.btn_CSVreport = new System.Windows.Forms.Button();
            this.btn_JSONreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(39, 46);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(158, 21);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Gestión de Turnos";
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.Location = new System.Drawing.Point(39, 94);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(189, 32);
            this.btn_modify.TabIndex = 4;
            this.btn_modify.Text = "Modificar";
            this.btn_modify.UseVisualStyleBackColor = false;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(39, 164);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(189, 32);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txb_dniPatient
            // 
            this.txb_dniPatient.Location = new System.Drawing.Point(302, 87);
            this.txb_dniPatient.Name = "txb_dniPatient";
            this.txb_dniPatient.Size = new System.Drawing.Size(169, 23);
            this.txb_dniPatient.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(302, 67);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(97, 17);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "DNI paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Especialidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(521, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha:";
            // 
            // dgv_appointments
            // 
            this.dgv_appointments.AllowUserToResizeColumns = false;
            this.dgv_appointments.AllowUserToResizeRows = false;
            this.dgv_appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_appointments.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_appointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_appointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_appointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_appointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_appointments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_appointments.GridColor = System.Drawing.Color.White;
            this.dgv_appointments.Location = new System.Drawing.Point(39, 240);
            this.dgv_appointments.Name = "dgv_appointments";
            this.dgv_appointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_appointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_appointments.RowHeadersVisible = false;
            this.dgv_appointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_appointments.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_appointments.RowTemplate.Height = 25;
            this.dgv_appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_appointments.Size = new System.Drawing.Size(986, 304);
            this.dgv_appointments.TabIndex = 0;
            this.dgv_appointments.DoubleClick += new System.EventHandler(this.dgv_appointments_DoubleClick);
            // 
            // dtp_appntDate
            // 
            this.dtp_appntDate.Location = new System.Drawing.Point(521, 87);
            this.dtp_appntDate.Name = "dtp_appntDate";
            this.dtp_appntDate.Size = new System.Drawing.Size(248, 23);
            this.dtp_appntDate.TabIndex = 17;
            // 
            // cbx_specialField
            // 
            this.cbx_specialField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_specialField.FormattingEnabled = true;
            this.cbx_specialField.Items.AddRange(new object[] {
            "Medicina Familiar",
            "Ginecologia",
            "Nutricion",
            "Kinesiologia",
            "Obstetricia"});
            this.cbx_specialField.Location = new System.Drawing.Point(302, 173);
            this.cbx_specialField.Name = "cbx_specialField";
            this.cbx_specialField.Size = new System.Drawing.Size(169, 23);
            this.cbx_specialField.TabIndex = 18;
            // 
            // btn_CSVreport
            // 
            this.btn_CSVreport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CSVreport.FlatAppearance.BorderSize = 0;
            this.btn_CSVreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CSVreport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CSVreport.ForeColor = System.Drawing.Color.White;
            this.btn_CSVreport.Location = new System.Drawing.Point(822, 152);
            this.btn_CSVreport.Name = "btn_CSVreport";
            this.btn_CSVreport.Size = new System.Drawing.Size(203, 32);
            this.btn_CSVreport.TabIndex = 19;
            this.btn_CSVreport.Text = "Generar Informe CSV";
            this.btn_CSVreport.UseVisualStyleBackColor = false;
            this.btn_CSVreport.Click += new System.EventHandler(this.btn_CSVreport_Click);
            // 
            // btn_JSONreport
            // 
            this.btn_JSONreport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_JSONreport.FlatAppearance.BorderSize = 0;
            this.btn_JSONreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JSONreport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JSONreport.ForeColor = System.Drawing.Color.White;
            this.btn_JSONreport.Location = new System.Drawing.Point(822, 190);
            this.btn_JSONreport.Name = "btn_JSONreport";
            this.btn_JSONreport.Size = new System.Drawing.Size(203, 32);
            this.btn_JSONreport.TabIndex = 20;
            this.btn_JSONreport.Text = "Generar Informe JSON";
            this.btn_JSONreport.UseVisualStyleBackColor = false;
            this.btn_JSONreport.Click += new System.EventHandler(this.btn_JSONreport_Click);
            // 
            // AppointmentDMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.btn_JSONreport);
            this.Controls.Add(this.btn_CSVreport);
            this.Controls.Add(this.cbx_specialField);
            this.Controls.Add(this.dtp_appntDate);
            this.Controls.Add(this.dgv_appointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txb_dniPatient);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentDMForm";
            this.Text = "AppointmentDMForm";
            this.Load += new System.EventHandler(this.AppointmentDMForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Button btn_modify;
        private Button btn_delete;
        private Label lbl_name;
        private Label label1;
        private Label label2;
        private DataGridView dgv_appointments;
        private DateTimePicker dtp_appntDate;
        private TextBox txb_dniPatient;
        private ComboBox cbx_specialField;
        private Button btn_CSVreport;
        private Button btn_JSONreport;
    }
}