using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBM.Data.DB2.iSeries;
using System.Windows.Forms;
using System.Data;

namespace Penalty_Calculation_Application
{
    public class IBMData
    {
        private bool status;
        private iDB2Connection cn;

        public IBMData()
        {
            
        }

        public bool SetupConnection(String uname, String pword)
        {
            if (uname == null || pword == null)
            {
                status = false;
                return status;
            }
            
            String cs = string.Format("DataSource=192.168.5.25;UserID={0};Password={1};DefaultCollection=UMISF;", uname, pword);
            cn = new iDB2Connection(cs);

            try
            {
                cn.Open();
                status = true;
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Exception: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
                return status;
            }
        }

        public void getEmployers(AutoCompleteStringCollection dataCollection)
        {
            iDB2Command command;
            iDB2DataAdapter adapter = new iDB2DataAdapter();
            DataSet ds = new DataSet();

            string sql = @"SELECT ""AS.EMPR"".RREG02, ""AS.EMPR"".BNAM02 FROM UMISF.""AS.EMPR"" AS ""AS.EMPR"" WHERE ""AS.EMPR"".ACTV02 = 'A'";
            
            try
            {
                command = new iDB2Command(sql, cn);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    dataCollection.Add(row[0].ToString().Trim() + ' ' + row[1].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }
    }
}
