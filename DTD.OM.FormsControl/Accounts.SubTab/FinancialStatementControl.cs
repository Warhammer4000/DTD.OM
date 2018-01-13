using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTD.OM.Globals;
using DTD.OM.Serializer;
using DTD.OM.ViewModels.Accounts;
using MetroFramework;

namespace DTD.OM.FormsControl.Accounts.SubTab
{
    public partial class FinancialStatementControl : UserControl
    {
        private FinancialStatements FinancialStatements { get; }


        public FinancialStatementControl(FinancialStatements financialStatements)
        {
            InitializeComponent();
            FinancialStatements = financialStatements;
            ViewModelGlobals.FinancialStatements = FinancialStatements;
            LoadView();
        }

        private void LoadView()
        {
            checkedListBox.Items.AddRange(FinancialStatements.StatementNamesList.ToArray<object>());
        }


        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox.CheckedItems.Count >= 0) RemoveButton.Visible = true;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No) return;

            var selecteditems = new List<string>();
            foreach (string item in checkedListBox.CheckedItems) selecteditems.Add(item);

            foreach (var item in selecteditems) checkedListBox.Items.Remove(item);
            UpdateStatementList();
            RemoveButton.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ValueBox.Text)) return;
            if (!checkedListBox.Items.Contains(ValueBox.Text))
            {
                checkedListBox.Items.Add(ValueBox.Text);
                UpdateStatementList();
                ValueBox.Text = "";
            }
            else
            {
                MessageBox.Show(@"Already exists", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        private void UpdateStatementList()
        {
            FinancialStatements.StatementNamesList = new List<string>();
            foreach (string item in checkedListBox.Items) FinancialStatements.StatementNamesList.Add(item);
            SaveAndLoad.SaveLocalData("FinancialStatements.json", FinancialStatements);
        }
    }
}