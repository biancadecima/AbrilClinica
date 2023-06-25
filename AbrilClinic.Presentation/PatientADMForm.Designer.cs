namespace AbrilClinica.UI
{
    partial class PatientADMForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_patients = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_surname = new System.Windows.Forms.TextBox();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.btn_JSONreport = new System.Windows.Forms.Button();
            this.btn_CSVreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_patients
            // 
            this.dgv_patients.AllowUserToResizeColumns = false;
            this.dgv_patients.AllowUserToResizeRows = false;
            this.dgv_patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patients.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_patients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_patients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_patients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_patients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_patients.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_patients.EnableHeadersVisualStyles = false;
            this.dgv_patients.GridColor = System.Drawing.Color.White;
            this.dgv_patients.Location = new System.Drawing.Point(32, 253);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_patients.RowHeadersVisible = false;
            this.dgv_patients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_patients.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_patients.RowTemplate.Height = 25;
            this.dgv_patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_patients.Size = new System.Drawing.Size(1005, 293);
            this.dgv_patients.TabIndex = 0;
            this.dgv_patients.DoubleClick += new System.EventHandler(this.dgv_patients_DoubleClick);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(32, 42);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(189, 21);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Gestión de Pacientes";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(32, 92);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(189, 32);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modify.ForeColor = System.Drawing.Color.White;
            this.btn_modify.Location = new System.Drawing.Point(32, 144);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(189, 32);
            this.btn_modify.TabIndex = 3;
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
            this.btn_delete.Location = new System.Drawing.Point(32, 198);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(189, 32);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(344, 86);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(169, 23);
            this.txb_name.TabIndex = 5;
            // 
            // txb_surname
            // 
            this.txb_surname.Location = new System.Drawing.Point(579, 86);
            this.txb_surname.Name = "txb_surname";
            this.txb_surname.Size = new System.Drawing.Size(169, 23);
            this.txb_surname.TabIndex = 6;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(344, 198);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(169, 23);
            this.txb_username.TabIndex = 7;
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(810, 86);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(169, 23);
            this.txb_dni.TabIndex = 8;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(579, 198);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(169, 23);
            this.txb_password.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(344, 67);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 17);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Nombre:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(579, 67);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(65, 17);
            this.lbl_surname.TabIndex = 11;
            this.lbl_surname.Text = "Apellido:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(344, 178);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 17);
            this.lbl_username.TabIndex = 12;
            this.lbl_username.Text = "Usuario:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.Location = new System.Drawing.Point(579, 178);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(88, 17);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Contraseña:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dni.Location = new System.Drawing.Point(810, 67);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(35, 17);
            this.lbl_dni.TabIndex = 14;
            this.lbl_dni.Text = "DNI:";
            // 
            // btn_JSONreport
            // 
            this.btn_JSONreport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_JSONreport.FlatAppearance.BorderSize = 0;
            this.btn_JSONreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JSONreport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JSONreport.ForeColor = System.Drawing.Color.White;
            this.btn_JSONreport.Location = new System.Drawing.Point(810, 189);
            this.btn_JSONreport.Name = "btn_JSONreport";
            this.btn_JSONreport.Size = new System.Drawing.Size(189, 32);
            this.btn_JSONreport.TabIndex = 15;
            this.btn_JSONreport.Text = "Generar Informe JSON";
            this.btn_JSONreport.UseVisualStyleBackColor = false;
            this.btn_JSONreport.Click += new System.EventHandler(this.btn_JSONreport_Click);
            // 
            // btn_CSVreport
            // 
            this.btn_CSVreport.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CSVreport.FlatAppearance.BorderSize = 0;
            this.btn_CSVreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CSVreport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CSVreport.ForeColor = System.Drawing.Color.White;
            this.btn_CSVreport.Location = new System.Drawing.Point(810, 144);
            this.btn_CSVreport.Name = "btn_CSVreport";
            this.btn_CSVreport.Size = new System.Drawing.Size(189, 32);
            this.btn_CSVreport.TabIndex = 16;
            this.btn_CSVreport.Text = "Generar Informe CSV";
            this.btn_CSVreport.UseVisualStyleBackColor = false;
            this.btn_CSVreport.Click += new System.EventHandler(this.btn_CSVreport_Click);
            // 
            // PatientADMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 576);
            this.Controls.Add(this.btn_CSVreport);
            this.Controls.Add(this.btn_JSONreport);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_dni);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.txb_surname);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv_patients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientADMForm";
            this.Text = "PatientADMForm";
            this.Load += new System.EventHandler(this.PatientADMForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_patients;
        private Label lbl_title;
        private Button btn_add;
        private Button btn_modify;
        private Button btn_delete;
        private TextBox txb_name;
        private TextBox txb_surname;
        private TextBox txb_username;
        private TextBox txb_dni;
        private TextBox txb_password;
        private Label lbl_name;
        private Label lbl_surname;
        private Label lbl_username;
        private Label lbl_password;
        private Label lbl_dni;
        private Button btn_JSONreport;
        private Button btn_CSVreport;
    }
}