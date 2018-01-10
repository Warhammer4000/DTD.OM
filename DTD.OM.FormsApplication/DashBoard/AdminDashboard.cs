using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.FormsControl.MainTabs;

namespace DTD.OM.FormsApplication.DashBoard
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            AccountingButton_Click(new object(), new EventArgs());
        }

        private void AccountingButton_Click(object sender, EventArgs e)
        {
            AccountsTab accountsTab = new AccountsTab(){Dock = DockStyle.Fill};
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(accountsTab);
        }
    }
}
