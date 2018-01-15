using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTD.OM.FormsControl.CustomControls;
using DTD.OM.FormsControl.Dialogues;
using DTD.OM.Serializer;
using DTD.OM.ViewModels;
using DTD.OM.ViewModels.Accounts;
using MetroFramework;
using MetroFramework.Controls;

namespace DTD.OM.FormsControl.Accounts.SubTab
{
    public partial class FundAllocationControl : UserControl
    {
        public FundAllocation FundAllocation { get; set; }
        private MonthlyAllocation MonthlyAllocation { get; set; }

        public FundAllocationControl(FundAllocation fundAllocation)
        {
            InitializeComponent();
            FundAllocation = fundAllocation;
            UpdateView();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            var statementForm= new NewStatement();
            if (statementForm.ShowDialog() != DialogResult.OK) return;
            if (FundAllocation.MonthlyAllocations.Find(r =>
                    r.ViewName == statementForm.MonthlyAllocation.ViewName) == null)
            {

                foreach (Statement statement in statementForm.MonthlyAllocation.Statements)
                {
                    statement.Month = statementForm.MonthlyAllocation.Month;
                    statement.Year = statementForm.MonthlyAllocation.Year;
                }



                FundAllocation.MonthlyAllocations.Add(statementForm.MonthlyAllocation);
                
                //Log log = new Log
                //{
                //    Message = statementForm.MonthlyAllocation.ViewName + @" was added by" + @" Super User",//TODO change with valid user later
                //    LogObject = Factory<MonthlyAllocation>.ToJson(statementForm.MonthlyAllocation)
                //};
                
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
      
            foreach (MonthlyAllocation allocation in FundAllocation.MonthlyAllocations)
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
            SaveData();

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (MetroRadioButton) sender;
            MonthlyAllocation = FundAllocation.MonthlyAllocations.Find(r => r.ViewName == radioButton.Name);
            
            ShowAllocations(MonthlyAllocation.Statements);
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
                statementAllocationControl.StatementTextBox.TextChanged += StatementAllocation_TextChanged;
                statementAllocationControl.StatementTextBox.SelectedIndexChanged += StatementAllocation_TextChanged;
                statementAllocationControl.RemoveButton.Click += RemoveButton_Click;
                ViewPanel.Controls.Add(statementAllocationControl);
            }
        }

        private void newStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MonthlyAllocation == null)
            {
                MetroMessageBox.Show(this, "Select/Create Month");
                return;
            }
            Statement statement = new Statement(MonthlyAllocation.Month, MonthlyAllocation.Year);
            
            MonthlyAllocation.Statements.Add(statement);
            StatementAllocationControl statementAllocation= new StatementAllocationControl(statement){Dock = DockStyle.Top};
            statementAllocation.StatementTextBox.TextChanged += StatementAllocation_TextChanged;
            statementAllocation.StatementTextBox.SelectedIndexChanged+= StatementAllocation_TextChanged;
            statementAllocation.RemoveButton.Click += RemoveButton_Click;
            ViewPanel.Controls.Add(statementAllocation);
           
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            MonthlyAllocation.Statements.Clear();
            foreach (StatementAllocationControl statementAllocation in ViewPanel.Controls)
            {
                MonthlyAllocation.Statements.Add(statementAllocation.Statement);
            }
            SaveData();
            
        }

        private void StatementAllocation_TextChanged(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            SaveAndLoad.SaveLocalData("Fundallocation.json", FundAllocation);
        }

    }
}
