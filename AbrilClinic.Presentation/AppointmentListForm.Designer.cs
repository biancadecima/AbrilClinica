namespace AbrilClinica.UI
{
    partial class AppointmentListForm
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
            this.dgv_appointment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_appointment
            // 
            this.dgv_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_appointment.Location = new System.Drawing.Point(37, 70);
            this.dgv_appointment.Name = "dgv_appointment";
            this.dgv_appointment.RowTemplate.Height = 25;
            this.dgv_appointment.Size = new System.Drawing.Size(725, 339);
            this.dgv_appointment.TabIndex = 0;
            // 
            // AppointmentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_appointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentListForm";
            this.Text = "Lista de Turnos";
            this.Load += new System.EventHandler(this.AppointmentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_appointment;
    }
}