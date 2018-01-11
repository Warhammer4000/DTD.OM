using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.FormsControl.CustomControls;
using DTD.OM.FormsControl.Dialogues;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.Accounts.SubTab
{
    public partial class FundAllocationControl : UserControl
    {
        public FundAllocation FundAllocation { get; set; }
        public FundAllocationControl()
        {
            InitializeComponent();
            FundAllocation=new FundAllocation();
            Globals.ViewModelGlobals.FundAllocation = FundAllocation;
        }

        public FundAllocationControl(FundAllocation fundAllocation)
        {
            InitializeComponent();
            FundAllocation = fundAllocation;
            //Globals.ViewModelGlobals.FundAllocation = FundAllocation; will probably come from globals
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            var statementForm= new NewStatement(Globals.ViewModelGlobals.FinancialStatements.StatementNamesList);
            if (statementForm.ShowDialog() == DialogResult.OK)
            {
                FundAllocation.MonthlyAllocations.Add(statementForm.MonthlyAllocation);
                UpdateView();
               
            }

        }

        private void UpdateView()
        {
            MonthlyPanel.Controls.Clear();
            foreach (MonthlyAllocation allocation in FundAllocation.MonthlyAllocations)
            {
                RadioButton radioButton = new RadioButton(){Name = allocation.ViewName,Text = allocation.ViewName};
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                MonthlyPanel.Controls.Add(radioButton);
            }

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton) sender;
            MonthlyAllocation allocation = FundAllocation.MonthlyAllocations.Find(r => r.ViewName == radioButton.Name);
            ShowAllocations(allocation.Statements);
        }

        private void ShowAllocations(List<Statement> statements)
        {
            ViewPanel.Controls.Clear();
            foreach (var statement in statements)
            {
                var statementAllocationControl = new StatementAllocationControl(statement)
                {
                    Dock = DockStyle.Top

                };
                ViewPanel.Controls.Add(statementAllocationControl);
            }
        }


    }
}
