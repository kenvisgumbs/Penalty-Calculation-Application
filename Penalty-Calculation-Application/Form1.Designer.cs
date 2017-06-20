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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Emp_Label = new System.Windows.Forms.Label();
            this.Emp_TextBox = new System.Windows.Forms.TextBox();
            this.PayDate_Label = new System.Windows.Forms.Label();
            this.PayDate_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.EmploymentSector_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Contribution_Grid = new System.Windows.Forms.DataGridView();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contribution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Calc_Button = new System.Windows.Forms.Button();
            this.Error_label = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ContributionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contributionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contribution_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContributionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contributionsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(191, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANGUILLA SOCIAL SECURITY BOARD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.label2.Location = new System.Drawing.Point(191, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Penalty Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Emp_Label
            // 
            this.Emp_Label.AutoSize = true;
            this.Emp_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Label.Location = new System.Drawing.Point(65, 238);
            this.Emp_Label.Name = "Emp_Label";
            this.Emp_Label.Size = new System.Drawing.Size(170, 39);
            this.Emp_Label.TabIndex = 3;
            this.Emp_Label.Text = "Employer:";
            // 
            // Emp_TextBox
            // 
            this.Emp_TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.Emp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Emp_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Emp_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Emp_TextBox.Location = new System.Drawing.Point(244, 235);
            this.Emp_TextBox.Name = "Emp_TextBox";
            this.Emp_TextBox.Size = new System.Drawing.Size(562, 47);
            this.Emp_TextBox.TabIndex = 4;
            // 
            // PayDate_Label
            // 
            this.PayDate_Label.AutoSize = true;
            this.PayDate_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayDate_Label.Location = new System.Drawing.Point(65, 300);
            this.PayDate_Label.Name = "PayDate_Label";
            this.PayDate_Label.Size = new System.Drawing.Size(251, 39);
            this.PayDate_Label.TabIndex = 5;
            this.PayDate_Label.Text = "Payment Date:";
            // 
            // PayDate_DatePicker
            // 
            this.PayDate_DatePicker.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.PayDate_DatePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PayDate_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PayDate_DatePicker.Location = new System.Drawing.Point(323, 294);
            this.PayDate_DatePicker.Name = "PayDate_DatePicker";
            this.PayDate_DatePicker.Size = new System.Drawing.Size(481, 47);
            this.PayDate_DatePicker.TabIndex = 6;
            // 
            // EmploymentSector_Label
            // 
            this.EmploymentSector_Label.AutoSize = true;
            this.EmploymentSector_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmploymentSector_Label.Location = new System.Drawing.Point(65, 356);
            this.EmploymentSector_Label.Name = "EmploymentSector_Label";
            this.EmploymentSector_Label.Size = new System.Drawing.Size(328, 39);
            this.EmploymentSector_Label.TabIndex = 8;
            this.EmploymentSector_Label.Text = "Employment Sector:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(391, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ipsonian Lebadium";
            // 
            // Contribution_Grid
            // 
            this.Contribution_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.Contribution_Grid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Contribution_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contribution_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Contribution_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Contribution_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Contribution_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Year,
            this.Month,
            this.Contribution});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Contribution_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Contribution_Grid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Contribution_Grid.Location = new System.Drawing.Point(-1, -1);
            this.Contribution_Grid.Name = "Contribution_Grid";
            this.Contribution_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Contribution_Grid.RowTemplate.Height = 23;
            this.Contribution_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Contribution_Grid.Size = new System.Drawing.Size(731, 204);
            this.Contribution_Grid.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(72, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 258);
            this.panel1.TabIndex = 11;
            // 
            // Calc_Button
            // 
            this.Calc_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(99)))));
            this.Calc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc_Button.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_Button.ForeColor = System.Drawing.SystemColors.Window;
            this.Calc_Button.Location = new System.Drawing.Point(72, 740);
            this.Calc_Button.Name = "Calc_Button";
            this.Calc_Button.Size = new System.Drawing.Size(215, 67);
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
            this.Error_label.Location = new System.Drawing.Point(293, 740);
            this.Error_label.MaximumSize = new System.Drawing.Size(600, 0);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(112, 30);
            this.Error_label.TabIndex = 13;
            this.Error_label.Text = "Error Label";
            this.Error_label.Visible = false;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PenaltyData";
            reportDataSource1.Value = this.ContributionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Penalty_Calculation_Application.PenReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(843, 235);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(896, 457);
            this.reportViewer1.TabIndex = 14;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ContributionsBindingSource
            // 
            this.ContributionsBindingSource.DataSource = typeof(Penalty_Calculation_Application.Contributions);
            // 
            // contributionsBindingSource1
            // 
            this.contributionsBindingSource1.DataSource = typeof(Penalty_Calculation_Application.Contributions);
            // 
            // PenCalcMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1932, 843);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.Calc_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmploymentSector_Label);
            this.Controls.Add(this.PayDate_DatePicker);
            this.Controls.Add(this.PayDate_Label);
            this.Controls.Add(this.Emp_TextBox);
            this.Controls.Add(this.Emp_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PenCalcMainForm";
            this.Text = "ASSB Penalty Calculator";
            this.Load += new System.EventHandler(this.PenCalcMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contribution_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContributionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contributionsBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Contribution_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Calc_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contribution;
        private System.Windows.Forms.Label Error_label;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ContributionsBindingSource;
        private System.Windows.Forms.BindingSource contributionsBindingSource1;
    }
}

