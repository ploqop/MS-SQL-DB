
namespace MS_SQL_DB
{
    partial class NewPatientForm
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
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSurname.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxSurname.Location = new System.Drawing.Point(12, 12);
            this.textBoxSurname.MaxLength = 30;
            this.textBoxSurname.MinimumSize = new System.Drawing.Size(125, 25);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(200, 27);
            this.textBoxSurname.TabIndex = 4;
            this.textBoxSurname.Text = "Фамилия";
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurname.Enter += new System.EventHandler(this.textBoxSurname_Enter);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxAddress.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxAddress.Location = new System.Drawing.Point(788, 12);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.MinimumSize = new System.Drawing.Size(125, 25);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(455, 27);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxAddress.Text = "Адрес проживания";
            this.textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBirthday.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxBirthday.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxBirthday.Location = new System.Drawing.Point(630, 12);
            this.textBoxBirthday.MinimumSize = new System.Drawing.Size(125, 25);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(152, 27);
            this.textBoxBirthday.TabIndex = 6;
            this.textBoxBirthday.Text = "Дата рождения";
            this.textBoxBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBirthday.Enter += new System.EventHandler(this.textBoxBirthDay_Enter);
            this.textBoxBirthday.Leave += new System.EventHandler(this.textBoxBirthDay_Leave);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxSecondName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxSecondName.Location = new System.Drawing.Point(424, 12);
            this.textBoxSecondName.MaxLength = 30;
            this.textBoxSecondName.MinimumSize = new System.Drawing.Size(125, 25);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(200, 27);
            this.textBoxSecondName.TabIndex = 7;
            this.textBoxSecondName.Text = "Отчество";
            this.textBoxSecondName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSecondName.Enter += new System.EventHandler(this.textBoxSecondName_Enter);
            this.textBoxSecondName.Leave += new System.EventHandler(this.textBoxSecondName_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxName.Location = new System.Drawing.Point(218, 12);
            this.textBoxName.MaxLength = 25;
            this.textBoxName.MinimumSize = new System.Drawing.Size(125, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 27);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Text = "Имя";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPatient.Location = new System.Drawing.Point(440, 100);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(170, 60);
            this.buttonAddPatient.TabIndex = 9;
            this.buttonAddPatient.Text = "Добавить";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(630, 100);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(170, 60);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 172);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый пациент";
            this.Load += new System.EventHandler(this.NewPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxBirthday;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.Button CancelButton;
    }
}