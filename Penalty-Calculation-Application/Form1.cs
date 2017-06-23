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

        public PenCalcMainForm()
        {
            InitializeComponent();
        }
        
        private List<Contributions> _userContValuesComplete = new List<Contributions>();
        private Contributions completeList = new Contributions();

        public class ContributionDetails
        {
            private  int _year;
            private  int _month;
            private  double _amount;
            private  double _surcharge;
            private  double _additionalSurcharge;
            private  double _totalDebt;

            public ContributionDetails()
            {
                _year = 1990;
                _month = 1;
                _amount = 0.00;
                _surcharge = 0.00;
                _additionalSurcharge = 0.00;
                _totalDebt = 0.00;
            }

            public ContributionDetails(int a, int b, double c, double d, double e, double f)
            {
                _year = a;
                _month = b;
                _amount = c;
                _surcharge = d;
                _additionalSurcharge = e;
                _totalDebt = f;
            }

            public int GetYear()
            {
                return _year;
            }
            public int GetMonth()
            {
                return _month;
            }
            public double GetAmount()
            {
                return _amount;
            }
            public double GetSurcharge()
            {
                return _surcharge;
            }
            public double AdditionalSurcharge()
            {
                return _additionalSurcharge;
            }
            public double GetTotalDebt()
            {
                return _totalDebt;
            }

            public string Details()
            {
                return _year + @" " + _month + @" " + Math.Round(_amount, 2, MidpointRounding.AwayFromZero) + @" " + Math.Round(_surcharge, 2, MidpointRounding.AwayFromZero) + @" " + Math.Round(_additionalSurcharge, 2, MidpointRounding.AwayFromZero) + @" " +
                       Math.Round(_totalDebt, 2, MidpointRounding.AwayFromZero);
            }
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
            
            ReportParameter[] rparams = new ReportParameter[3];
            rparams[0] = new ReportParameter("Employer_no", Emp_TextBox.Text, false);
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

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }


}
