using System;
using System.Windows.Forms;
using DTD.OM.FormsControl.Accounts.SubTab;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.MainTabs
{
    public partial class AccountsTab : MetroFramework.Controls.MetroUserControl
    {
        public AccountsTab()
        {
            InitializeComponent();
            FundButton_Click(new object(), new EventArgs());
        }

        private void FinancialButton_Click(object sender, EventArgs e)
        {
            FinancialStatementControl control= new FinancialStatementControl(Globals.ViewModelGlobals.FinancialStatements){Dock = DockStyle.Fill};
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(control);
        }

        private void FundButton_Click(object sender, EventArgs e)
        {
            FundAllocationControl control = new FundAllocationControl(Globals.ViewModelGlobals.FundAllocation) { Dock = DockStyle.Fill };
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(control);
        }
    }
}
