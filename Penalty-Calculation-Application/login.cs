using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penalty_Calculation_Application
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            IBMData IBMobject = new IBMData();
            if (IBMobject.SetupConnection(uname_textbox.Text, pword_textbox.Text))
            {
                PenCalcMainForm PenCalcMain = new PenCalcMainForm(IBMobject);
                this.Visible = false;
                PenCalcMain.Show();
                PenCalcMain.Visible = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoginButton_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void pword_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoginButton_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void uname_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoginButton_Click(this, new EventArgs());
                e.Handled = true;
            }
        }
    }
}
