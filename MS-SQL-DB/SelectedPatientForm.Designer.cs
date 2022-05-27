
namespace MS_SQL_DB
{
    partial class SelectedPatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedPatientDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectedPatientTreatmentDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddTreatment = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPatientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPatientTreatmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SelectedPatientDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SelectedPatientTreatmentDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddTreatment, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 395);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectedPatientDataGridView
            // 
            this.SelectedPatientDataGridView.AllowUserToAddRows = false;
            this.SelectedPatientDataGridView.AllowUserToDeleteRows = false;
            this.SelectedPatientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedPatientDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SelectedPatientDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedPatientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedPatientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SelectedPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedPatientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedPatientDataGridView.Location = new System.Drawing.Point(3, 3);
            this.SelectedPatientDataGridView.Name = "SelectedPatientDataGridView";
            this.SelectedPatientDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedPatientDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SelectedPatientDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedPatientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SelectedPatientDataGridView.RowTemplate.Height = 27;
            this.SelectedPatientDataGridView.Size = new System.Drawing.Size(1234, 73);
            this.SelectedPatientDataGridView.TabIndex = 1;
            // 
            // SelectedPatientTreatmentDataGridView
            // 
            this.SelectedPatientTreatmentDataGridView.AllowUserToAddRows = false;
            this.SelectedPatientTreatmentDataGridView.AllowUserToDeleteRows = false;
            this.SelectedPatientTreatmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedPatientTreatmentDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SelectedPatientTreatmentDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectedPatientTreatmentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedPatientTreatmentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SelectedPatientTreatmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedPatientTreatmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedPatientTreatmentDataGridView.Location = new System.Drawing.Point(3, 82);
            this.SelectedPatientTreatmentDataGridView.Name = "SelectedPatientTreatmentDataGridView";
            this.SelectedPatientTreatmentDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectedPatientTreatmentDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SelectedPatientTreatmentDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedPatientTreatmentDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.SelectedPatientTreatmentDataGridView.RowTemplate.Height = 27;
            this.SelectedPatientTreatmentDataGridView.Size = new System.Drawing.Size(1234, 250);
            this.SelectedPatientTreatmentDataGridView.TabIndex = 2;
            // 
            // buttonAddTreatment
            // 
            this.buttonAddTreatment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddTreatment.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTreatment.Location = new System.Drawing.Point(3, 338);
            this.buttonAddTreatment.Name = "buttonAddTreatment";
            this.buttonAddTreatment.Size = new System.Drawing.Size(1234, 54);
            this.buttonAddTreatment.TabIndex = 3;
            this.buttonAddTreatment.Text = "Назначить процедуру";
            this.buttonAddTreatment.UseVisualStyleBackColor = true;
            this.buttonAddTreatment.Click += new System.EventHandler(this.buttonAddTreatment_Click);
            // 
            // SelectedPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectedPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Процедуры";
            this.Load += new System.EventHandler(this.SelectedPatientForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPatientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPatientTreatmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView SelectedPatientDataGridView;
        private System.Windows.Forms.DataGridView SelectedPatientTreatmentDataGridView;
        private System.Windows.Forms.Button buttonAddTreatment;
    }
}