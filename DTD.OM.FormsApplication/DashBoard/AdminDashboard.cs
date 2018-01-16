using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.FormsControl.MainTabs;
using DTD.OM.Globals;
using DTD.OM.Serializer;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsApplication.DashBoard
{
    public partial class AdminDashboard : MetroFramework.Forms.MetroForm
    {
        public AdminDashboard()
        {
            LoadLocal();
            InitializeComponent();
            AccountingButton_Click(new object(), new EventArgs());
            
        }

        private void LoadLocal()
        {
            LocalData.DataPath = AppDomain.CurrentDomain.BaseDirectory;
            ViewModelGlobals.FundAllocation = SaveAndLoad.LoadLocalData<FundAllocation>("Fundallocation.json");
            //ViewModelGlobals.FinancialStatements = SaveAndLoad.LoadLocalData<FinancialStatements>("FinancialStatements.json");
        }

        private void AccountingButton_Click(object sender, EventArgs e)
        {
            AccountsTab accountsTab = new AccountsTab(){Dock = DockStyle.Fill};
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(accountsTab);
        }

        private void PersonnelButton_Click(object sender, EventArgs e)
        {
            PersonnelTab personnelTab = new PersonnelTab() { Dock = DockStyle.Fill };
            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(personnelTab);
        }
    }
}
