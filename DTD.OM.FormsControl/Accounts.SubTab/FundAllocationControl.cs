using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTD.OM.FormsControl.CustomControls;
using DTD.OM.FormsControl.Dialogues;
using DTD.OM.Serializer;
using DTD.OM.ViewModels;
using DTD.OM.ViewModels.Accounts;
using MetroFramework.Controls;

namespace DTD.OM.FormsControl.Accounts.SubTab
{
    public partial class FundAllocationControl : UserControl
    {
        public FundAllocation FundAllocation { get; set; }
     

        public FundAllocationControl(FundAllocation fundAllocation)
        {
            InitializeComponent();
            FundAllocation = fundAllocation;
            UpdateView();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            var statementForm= new NewStatement(Globals.ViewModelGlobals.FinancialStatements.StatementNamesList);
            if (statementForm.ShowDialog() != DialogResult.OK) return;
            if (FundAllocation.MonthlyAllocations.Find(r =>
                    r.ViewName == statementForm.MonthlyAllocation.ViewName) == null)
            {
                FundAllocation.MonthlyAllocations.Add(statementForm.MonthlyAllocation);
                Log log = new Log
                {
                    Message = statementForm.MonthlyAllocation.ViewName + @" was added by" + @" Super User",//TODO change with valid user later
                    LogObject = Factory<MonthlyAllocation>.ToJson(statementForm.MonthlyAllocation)
                };
                
                //FundAllocation.AllocationLog.Push(log);
                UpdateView();
            }
            else
            {
                MessageBox.Show(@"Already exists",@"Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }

        private void UpdateView()
        {
            MonthlyPanel.Controls.Clear();
      
            foreach (var allocation in FundAllocation.MonthlyAllocations)
            {
                var radioButton = new MetroRadioButton(){Name = allocation.ViewName,Text = allocation.ViewName};
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                if (allocation.Month==DateTime.Now.Month && allocation.Year==DateTime.Now.Year)
                {
                    radioButton.Checked = true;
                }
                MonthlyPanel.Controls.Add(radioButton);
            }

            //Save update
            SaveAndLoad.SaveLocalData("Fundallocation.json",FundAllocation);

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (MetroRadioButton) sender;
            var allocation = FundAllocation.MonthlyAllocations.Find(r => r.ViewName == radioButton.Name);
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
