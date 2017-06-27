using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penalty_Calculation_Application
{
    public partial class PenCalcMainForm : Form
    {
        int rowIndex;
        private IBMData idb;

        public PenCalcMainForm(IBMData IBMobject)
        {
            InitializeComponent();
            idb = IBMobject;
            SetupEmployerList();
        }

        public PenCalcMainForm()
        {
            InitializeComponent();
        }

        private List<Contributions> _userContValuesComplete = new List<Contributions>();
        private Contributions completeList = new Contributions();
        
        public void SetupEmployerList()
        {
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            idb.getEmployers(DataCollection);
            Emp_TextBox.AutoCompleteCustomSource = DataCollection;
        }

        private void Calc_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                double c;

                if (GetMonthDifference(
                    new DateTime(Convert.ToInt32(Contribution_Grid.Rows[0].Cells["Year"].Value),
                        Convert.ToInt32(Contribution_Grid.Rows[0].Cells["Month"].Value), 1),
                    Convert.ToDateTime(PayDate_DatePicker.Text)) < 0)
                    throw new Exception("Your payment date must be later than the initial contribution period");

                foreach (DataGridViewRow row in Contribution_Grid.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (!(int.TryParse(row.Cells["Year"].Value.ToString(), out a) && int.TryParse(row.Cells["Month"].Value.ToString(), out b)
                        && double.TryParse(row.Cells["Contribution"].Value.ToString(), out c)))
                    throw new Exception("Invalid input, please review contribution values");
                }

                Error_label.Visible = false;
                BuildList(Convert.ToInt32(Contribution_Grid.Rows[0].Cells["Year"].Value),
                    Convert.ToInt32(Contribution_Grid.Rows[0].Cells["Month"].Value),
                    Convert.ToDouble(Contribution_Grid.Rows[0].Cells["Contribution"].Value));
            }
            catch(Exception ex)
            {
                Error_label.Text = ex.Message;
                Error_label.Visible = true;
            }
        }

        public void BuildList(int year, int month, double contribution)
        {
            var periods = GetMonthDifference(new DateTime(year, month, 1), Convert.ToDateTime(PayDate_DatePicker.Text));
            var currentYear = year;
            var currentMonth = month;
            var currentContribution = contribution;
            String s, s2;
            StringBuilder aStringBuilder;

            completeList.ClearList(); //move to function
            for (var i = 0; i <= periods; i++)
            {
                System.Diagnostics.Debug.WriteLine(i);
                foreach (DataGridViewRow row in Contribution_Grid.Rows)
                {
                    if (row.IsNewRow) continue;
                    if(Convert.ToInt32(row.Cells["Year"].Value) == currentYear && Convert.ToInt32(row.Cells["Month"].Value) == currentMonth)
                        currentContribution = Convert.ToDouble(row.Cells["Contribution"].Value);
                }
                completeList.Add(CalculateSurcharge(currentYear, currentMonth, currentContribution));
                currentMonth++;
                if (currentMonth <= 12) continue;
                    currentMonth = 1;
                    currentYear++;
            }

            completeList.OutputContribution();

            s = "000000000";
            s2 = Emp_TextBox.Text.Substring(0, Emp_TextBox.Text.IndexOf(' '));
            aStringBuilder = new StringBuilder(s);
            aStringBuilder.Remove(9 - s2.Length, s2.Length);
            aStringBuilder.Insert(9 - s2.Length, s2);
            s = aStringBuilder.ToString() + "-000 " + Emp_TextBox.Text.Substring(Emp_TextBox.Text.IndexOf(' ') + 1);

            ReportParameter[] rparams = new ReportParameter[3];
            rparams[0] = new ReportParameter("Employer_no", s, false);
            rparams[1] = new ReportParameter("Payment_date", PayDate_DatePicker.Text, false);
            rparams[2] = new ReportParameter("Employment_sector", Sector_label.Text, false);

            this.reportViewer1.LocalReport.SetParameters(rparams);

            ContributionsBindingSource.DataSource = completeList.GetContributionList();
            reportViewer1.RefreshReport();
        }

        public Contributions CalculateSurcharge(int year, int month, double contribution)
        {
            var periods = GetMonthDifference(new DateTime(year, month, 1), Convert.ToDateTime(PayDate_DatePicker.Text));

            double fivepercentUp = RoundDown(contribution + RoundDown(contribution*0.05, 2),2) - 0.01;
            double twopercent = RoundDown(fivepercentUp * 0.02, 2);
            double surchargeSum = twopercent;

            if (periods == 2)
                return new Contributions(year, month, contribution, RoundDown(contribution * 0.05,2), 0, RoundDown(contribution +(contribution * 0.05),2));

            if (periods <= 1)
                return new Contributions(year, month, contribution, 0, 0, contribution);

            for (int i = 0; i <= periods - 4; i++)
            {
                fivepercentUp += fivepercentUp * 0.02;
                twopercent = fivepercentUp * 0.02;
                surchargeSum += twopercent;
            }
            
            return new Contributions(year, month, contribution, contribution * 0.05, surchargeSum, (surchargeSum + contribution + (contribution * 0.05)));

        }

        public static double RoundDown(double d, int decimals)
        {
            double degree = Math.Pow(10, decimals);
            return Math.Floor(d * degree) / degree;
        }

        public static int GetMonthDifference(DateTime endDate, DateTime startDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return monthsApart;
        }

        private void PenCalcMainForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

 

        private void Contribution_Grid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                this.Contribution_Grid.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                this.Contribution_Grid.CurrentCell = this.Contribution_Grid.Rows[e.RowIndex].Cells[1];
                this.DeleteRowCMS.Show(this.Contribution_Grid, e.Location);
                DeleteRowCMS.Show(Cursor.Position);
            }
        }

        private void DeleteRowCMS_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteRowCMS_Click(object sender, EventArgs e)
        {
            if (!this.Contribution_Grid.Rows[this.rowIndex].IsNewRow)
            {
                this.Contribution_Grid.Rows.RemoveAt(this.rowIndex);
            }
        }
    }


}
