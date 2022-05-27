
namespace MS_SQL_DB
{
    partial class AddTreatmentForm
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
            this.PatientNametextBox = new System.Windows.Forms.TextBox();
            this.PatientBirthdaytextBox = new System.Windows.Forms.TextBox();
            this.comboBoxTreatment = new System.Windows.Forms.ComboBox();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.numericUpDownVisit = new System.Windows.Forms.NumericUpDown();
            this.buttonSetTreatment = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientNametextBox
            // 
            this.PatientNametextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientNametextBox.Location = new System.Drawing.Point(12, 12);
            this.PatientNametextBox.Name = "PatientNametextBox";
            this.PatientNametextBox.ReadOnly = true;
            this.PatientNametextBox.Size = new System.Drawing.Size(847, 52);
            this.PatientNametextBox.TabIndex = 1;
            this.PatientNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientBirthdaytextBox
            // 
            this.PatientBirthdaytextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientBirthdaytextBox.Location = new System.Drawing.Point(865, 12);
            this.PatientBirthdaytextBox.Name = "PatientBirthdaytextBox";
            this.PatientBirthdaytextBox.ReadOnly = true;
            this.PatientBirthdaytextBox.Size = new System.Drawing.Size(283, 52);
            this.PatientBirthdaytextBox.TabIndex = 2;
            this.PatientBirthdaytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxTreatment
            // 
            this.comboBoxTreatment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreatment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTreatment.FormattingEnabled = true;
            this.comboBoxTreatment.Location = new System.Drawing.Point(12, 132);
            this.comboBoxTreatment.Name = "comboBoxTreatment";
            this.comboBoxTreatment.Size = new System.Drawing.Size(370, 31);
            this.comboBoxTreatment.TabIndex = 3;
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(395, 132);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(370, 31);
            this.comboBoxDoctor.TabIndex = 4;
            this.comboBoxDoctor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctor_SelectedIndexChanged);
            // 
            // dateTimePickerDateBegin
            // 
            this.dateTimePickerDateBegin.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateBegin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateBegin.Location = new System.Drawing.Point(12, 246);
            this.dateTimePickerDateBegin.Name = "dateTimePickerDateBegin";
            this.dateTimePickerDateBegin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerDateBegin.Size = new System.Drawing.Size(370, 30);
            this.dateTimePickerDateBegin.TabIndex = 5;
            // 
            // dateTimePickerDateEnd
            // 
            this.dateTimePickerDateEnd.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateEnd.Location = new System.Drawing.Point(395, 246);
            this.dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            this.dateTimePickerDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerDateEnd.Size = new System.Drawing.Size(370, 30);
            this.dateTimePickerDateEnd.TabIndex = 6;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(12, 359);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(370, 31);
            this.comboBoxRoom.TabIndex = 7;
            // 
            // numericUpDownVisit
            // 
            this.numericUpDownVisit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownVisit.Location = new System.Drawing.Point(395, 360);
            this.numericUpDownVisit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownVisit.Name = "numericUpDownVisit";
            this.numericUpDownVisit.Size = new System.Drawing.Size(370, 30);
            this.numericUpDownVisit.TabIndex = 8;
            this.numericUpDownVisit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSetTreatment
            // 
            this.buttonSetTreatment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSetTreatment.Location = new System.Drawing.Point(812, 435);
            this.buttonSetTreatment.Name = "buttonSetTreatment";
            this.buttonSetTreatment.Size = new System.Drawing.Size(165, 89);
            this.buttonSetTreatment.TabIndex = 9;
            this.buttonSetTreatment.Text = "Назначить процедуру";
            this.buttonSetTreatment.UseVisualStyleBackColor = true;
            this.buttonSetTreatment.Click += new System.EventHandler(this.buttonSetTreatment_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(370, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Процедура";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(395, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(370, 23);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Лечащий врач";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(370, 23);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Дата начала курса";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(395, 217);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(370, 23);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Дата окончания курса";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(12, 330);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(370, 23);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Номер кабинета";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(395, 330);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(370, 23);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "Количество процедур";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(983, 435);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(165, 89);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 536);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSetTreatment);
            this.Controls.Add(this.numericUpDownVisit);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.dateTimePickerDateEnd);
            this.Controls.Add(this.dateTimePickerDateBegin);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.comboBoxTreatment);
            this.Controls.Add(this.PatientBirthdaytextBox);
            this.Controls.Add(this.PatientNametextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTreatmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Назначение процедуры";
            this.Load += new System.EventHandler(this.AddTreatmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatientNametextBox;
        private System.Windows.Forms.TextBox PatientBirthdaytextBox;
        private System.Windows.Forms.ComboBox comboBoxTreatment;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEnd;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.NumericUpDown numericUpDownVisit;
        private System.Windows.Forms.Button buttonSetTreatment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button CancelButton;
    }
}