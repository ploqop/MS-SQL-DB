
namespace MS_SQL_DB
{
    partial class MainForm
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
            this.PatientsButton = new System.Windows.Forms.Button();
            this.DoctorsButton = new System.Windows.Forms.Button();
            this.ReportCabinetsButton = new System.Windows.Forms.Button();
            this.ReportPatientsButton = new System.Windows.Forms.Button();
            this.ReportDoctorButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PatientsButton
            // 
            this.PatientsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientsButton.Location = new System.Drawing.Point(44, 60);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.Size = new System.Drawing.Size(205, 68);
            this.PatientsButton.TabIndex = 0;
            this.PatientsButton.Text = "Пациенты";
            this.PatientsButton.UseVisualStyleBackColor = true;
            this.PatientsButton.Click += new System.EventHandler(this.PatientsButton_Click);
            // 
            // DoctorsButton
            // 
            this.DoctorsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorsButton.Location = new System.Drawing.Point(307, 60);
            this.DoctorsButton.Name = "DoctorsButton";
            this.DoctorsButton.Size = new System.Drawing.Size(205, 68);
            this.DoctorsButton.TabIndex = 1;
            this.DoctorsButton.Text = "Доктора";
            this.DoctorsButton.UseVisualStyleBackColor = true;
            this.DoctorsButton.Click += new System.EventHandler(this.DoctorsButton_Click);
            // 
            // ReportCabinetsButton
            // 
            this.ReportCabinetsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportCabinetsButton.Location = new System.Drawing.Point(578, 60);
            this.ReportCabinetsButton.Name = "ReportCabinetsButton";
            this.ReportCabinetsButton.Size = new System.Drawing.Size(205, 68);
            this.ReportCabinetsButton.TabIndex = 2;
            this.ReportCabinetsButton.Text = "Отчёт по работе кабинетов";
            this.ReportCabinetsButton.UseVisualStyleBackColor = true;
            this.ReportCabinetsButton.Click += new System.EventHandler(this.ReportCabinetsButton_Click);
            // 
            // ReportPatientsButton
            // 
            this.ReportPatientsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportPatientsButton.Location = new System.Drawing.Point(840, 60);
            this.ReportPatientsButton.Name = "ReportPatientsButton";
            this.ReportPatientsButton.Size = new System.Drawing.Size(205, 68);
            this.ReportPatientsButton.TabIndex = 3;
            this.ReportPatientsButton.Text = "Отчёт по пациентам";
            this.ReportPatientsButton.UseVisualStyleBackColor = true;
            this.ReportPatientsButton.Click += new System.EventHandler(this.ReportPatientsButton_Click);
            // 
            // ReportDoctorButton
            // 
            this.ReportDoctorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportDoctorButton.Location = new System.Drawing.Point(414, 250);
            this.ReportDoctorButton.Name = "ReportDoctorButton";
            this.ReportDoctorButton.Size = new System.Drawing.Size(205, 68);
            this.ReportDoctorButton.TabIndex = 4;
            this.ReportDoctorButton.Text = "Отчёт по доктору";
            this.ReportDoctorButton.UseVisualStyleBackColor = true;
            this.ReportDoctorButton.Click += new System.EventHandler(this.ReportDoctorButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(336, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(370, 23);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Доктор для отчёта";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(336, 213);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(370, 31);
            this.comboBoxDoctor.TabIndex = 13;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1070, 365);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.ReportDoctorButton);
            this.Controls.Add(this.ReportPatientsButton);
            this.Controls.Add(this.ReportCabinetsButton);
            this.Controls.Add(this.DoctorsButton);
            this.Controls.Add(this.PatientsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button PatientsButton;
        private System.Windows.Forms.Button DoctorsButton;
        private System.Windows.Forms.Button ReportCabinetsButton;
        private System.Windows.Forms.Button ReportPatientsButton;
        private System.Windows.Forms.Button ReportDoctorButton;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.ComboBox comboBoxDoctor;
    }
}