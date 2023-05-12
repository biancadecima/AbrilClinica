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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_patients
            // 
            this.dgv_patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_patients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_patients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patients.Location = new System.Drawing.Point(32, 253);
            this.dgv_patients.Name = "dgv_patients";
            this.dgv_patients.RowTemplate.Height = 25;
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
            this.txb_name.Location = new System.Drawing.Point(351, 120);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(169, 23);
            this.txb_name.TabIndex = 5;
            // 
            // txb_surname
            // 
            this.txb_surname.Location = new System.Drawing.Point(579, 120);
            this.txb_surname.Name = "txb_surname";
            this.txb_surname.Size = new System.Drawing.Size(169, 23);
            this.txb_surname.TabIndex = 6;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(351, 198);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(169, 23);
            this.txb_username.TabIndex = 7;
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(810, 120);
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
            this.lbl_name.Location = new System.Drawing.Point(351, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 17);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Nombre:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(579, 92);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(65, 17);
            this.lbl_surname.TabIndex = 11;
            this.lbl_surname.Text = "Apellido:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(351, 175);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 17);
            this.lbl_username.TabIndex = 12;
            this.lbl_username.Text = "Usuario:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.Location = new System.Drawing.Point(579, 175);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(88, 17);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Contraseña:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dni.Location = new System.Drawing.Point(810, 92);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(35, 17);
            this.lbl_dni.TabIndex = 14;
            this.lbl_dni.Text = "DNI:";
            // 
            // PatientADMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 576);
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
    }
}