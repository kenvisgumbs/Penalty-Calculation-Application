namespace Penalty_Calculation_Application
{
    partial class PenCalcMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenCalcMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ContributionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emp_Label = new System.Windows.Forms.Label();
            this.Emp_TextBox = new System.Windows.Forms.TextBox();
            this.PayDate_Label = new System.Windows.Forms.Label();
            this.PayDate_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmploymentSector_Label = new System.Windows.Forms.Label();
            this.Sector_label = new System.Windows.Forms.Label();
            this.Contribution_Grid = new System.Windows.Forms.DataGridView();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contribution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Calc_Button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contributionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteRowCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ContributionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contribution_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contributionsBindingSource1)).BeginInit();
            this.DeleteRowCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContributionsBindingSource
            // 
            this.ContributionsBindingSource.DataSource = typeof(Penalty_Calculation_Application.Contributions);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANGUILLA SOCIAL SECURITY BOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(73, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Penalty Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Emp_Label
            // 
            this.Emp_Label.AutoSize = true;
            this.Emp_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Label.Location = new System.Drawing.Point(7, 81);
            this.Emp_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emp_Label.Name = "Emp_Label";
            this.Emp_Label.Size = new System.Drawing.Size(85, 21);
            this.Emp_Label.TabIndex = 3;
            this.Emp_Label.Text = "Employer:";
            // 
            // Emp_TextBox
            // 
            this.Emp_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Emp_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Emp_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Emp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emp_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Emp_TextBox.Location = new System.Drawing.Point(97, 79);
            this.Emp_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Emp_TextBox.Name = "Emp_TextBox";
            this.Emp_TextBox.Size = new System.Drawing.Size(282, 27);
            this.Emp_TextBox.TabIndex = 4;
            // 
            // PayDate_Label
            // 
            this.PayDate_Label.AutoSize = true;
            this.PayDate_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayDate_Label.Location = new System.Drawing.Point(7, 113);
            this.PayDate_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PayDate_Label.Name = "PayDate_Label";
            this.PayDate_Label.Size = new System.Drawing.Size(128, 21);
            this.PayDate_Label.TabIndex = 5;
            this.PayDate_Label.Text = "Payment Date:";
            // 
            // PayDate_DatePicker
            // 
            this.PayDate_DatePicker.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.PayDate_DatePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PayDate_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PayDate_DatePicker.Location = new System.Drawing.Point(137, 110);
            this.PayDate_DatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.PayDate_DatePicker.Name = "PayDate_DatePicker";
            this.PayDate_DatePicker.Size = new System.Drawing.Size(242, 27);
            this.PayDate_DatePicker.TabIndex = 6;
            // 
            // EmploymentSector_Label
            // 
            this.EmploymentSector_Label.AutoSize = true;
            this.EmploymentSector_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmploymentSector_Label.Location = new System.Drawing.Point(7, 142);
            this.EmploymentSector_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmploymentSector_Label.Name = "EmploymentSector_Label";
            this.EmploymentSector_Label.Size = new System.Drawing.Size(166, 21);
            this.EmploymentSector_Label.TabIndex = 8;
            this.EmploymentSector_Label.Text = "Employment Sector:";
            // 
            // Sector_label
            // 
            this.Sector_label.AutoSize = true;
            this.Sector_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Sector_label.Location = new System.Drawing.Point(171, 142);
            this.Sector_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sector_label.Name = "Sector_label";
            this.Sector_label.Size = new System.Drawing.Size(0, 19);
            this.Sector_label.TabIndex = 9;
            // 
            // Contribution_Grid
            // 
            this.Contribution_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Contribution_Grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Contribution_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contribution_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contribution_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Contribution_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contribution_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Year,
            this.Month,
            this.Contribution});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Contribution_Grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Contribution_Grid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Contribution_Grid.Location = new System.Drawing.Point(0, -1);
            this.Contribution_Grid.Margin = new System.Windows.Forms.Padding(2);
            this.Contribution_Grid.Name = "Contribution_Grid";
            this.Contribution_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Contribution_Grid.RowTemplate.Height = 23;
            this.Contribution_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Contribution_Grid.Size = new System.Drawing.Size(366, 106);
            this.Contribution_Grid.TabIndex = 0;
            this.Contribution_Grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Contribution_Grid_CellMouseUp);
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.FillWeight = 60F;
            this.Year.HeaderText = "Year";
            this.Year.MaxInputLength = 4;
            this.Year.Name = "Year";
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Year.ToolTipText = "Contriution year";
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.FillWeight = 60F;
            this.Month.HeaderText = "Month";
            this.Month.MaxInputLength = 2;
            this.Month.Name = "Month";
            this.Month.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Month.ToolTipText = "Contribution month";
            // 
            // Contribution
            // 
            this.Contribution.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contribution.FillWeight = 60F;
            this.Contribution.HeaderText = "Contribution";
            this.Contribution.MaxInputLength = 6;
            this.Contribution.Name = "Contribution";
            this.Contribution.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Contribution.ToolTipText = "Contribution amount";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Contribution_Grid);
            this.panel1.Location = new System.Drawing.Point(11, 177);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 155);
            this.panel1.TabIndex = 11;
            // 
            // Calc_Button
            // 
            this.Calc_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(99)))));
            this.Calc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc_Button.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Calc_Button.Location = new System.Drawing.Point(11, 342);
            this.Calc_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Calc_Button.Name = "Calc_Button";
            this.Calc_Button.Size = new System.Drawing.Size(108, 35);
            this.Calc_Button.TabIndex = 12;
            this.Calc_Button.Text = "Calculate";
            this.Calc_Button.UseVisualStyleBackColor = false;
            this.Calc_Button.Click += new System.EventHandler(this.Calc_Button_Click);
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Font = new System.Drawing.Font("Leelawadee UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_label.ForeColor = System.Drawing.Color.Crimson;
            this.Error_label.Location = new System.Drawing.Point(121, 342);
            this.Error_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Error_label.MaximumSize = new System.Drawing.Size(300, 0);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(62, 13);
            this.Error_label.TabIndex = 13;
            this.Error_label.Text = "Error Label";
            this.Error_label.Visible = false;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "PenaltyData";
            reportDataSource3.Value = this.ContributionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Penalty_Calculation_Application.PenReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(397, 79);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(783, 298);
            this.reportViewer1.TabIndex = 14;
            // 
            // contributionsBindingSource1
            // 
            this.contributionsBindingSource1.DataSource = typeof(Penalty_Calculation_Application.Contributions);
            // 
            // DeleteRowCMS
            // 
            this.DeleteRowCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.DeleteRowCMS.Name = "DeleteRowCMS";
            this.DeleteRowCMS.Size = new System.Drawing.Size(134, 26);
            this.DeleteRowCMS.Opening += new System.ComponentModel.CancelEventHandler(this.DeleteRowCMS_Opening);
            this.DeleteRowCMS.Click += new System.EventHandler(this.DeleteRowCMS_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // PenCalcMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 387);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Calc_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sector_label);
            this.Controls.Add(this.EmploymentSector_Label);
            this.Controls.Add(this.PayDate_DatePicker);
            this.Controls.Add(this.PayDate_Label);
            this.Controls.Add(this.Emp_TextBox);
            this.Controls.Add(this.Emp_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PenCalcMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASSB Penalty Calculator";
            this.Load += new System.EventHandler(this.PenCalcMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContributionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contribution_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contributionsBindingSource1)).EndInit();
            this.DeleteRowCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Emp_Label;
        private System.Windows.Forms.TextBox Emp_TextBox;
        private System.Windows.Forms.Label PayDate_Label;
        private System.Windows.Forms.DateTimePicker PayDate_DatePicker;
        private System.Windows.Forms.Label EmploymentSector_Label;
        private System.Windows.Forms.Label Sector_label;
        private System.Windows.Forms.DataGridView Contribution_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Calc_Button;
        private System.Windows.Forms.Label Error_label;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContributionsBindingSource;
        private System.Windows.Forms.BindingSource contributionsBindingSource1;
        private System.Windows.Forms.ContextMenuStrip DeleteRowCMS;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contribution;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

