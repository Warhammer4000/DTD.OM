﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.Accounts.SubTab
{
    public partial class FinancialStatementControl : UserControl
    {
        public  FinancialStatements FinancialStatements { get; set; }
        public FinancialStatementControl()
        {
            InitializeComponent();
            FinancialStatements=new FinancialStatements();
            Globals.ViewModelGlobals.FinancialStatements = FinancialStatements;
        }

        public FinancialStatementControl(FinancialStatements financialStatements)
        {
            InitializeComponent();
            FinancialStatements = financialStatements;
            Globals.ViewModelGlobals.FinancialStatements = FinancialStatements;
            LoadView();
        }

        private void LoadView()
        {
            checkedListBox.Items.AddRange(FinancialStatements.StatementNamesList.ToArray<Object>());
        }


        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox.CheckedItems.Count>=0)
            {
                RemoveButton.Visible = true;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            List<string> selecteditems= new List<string>();
            foreach (string item in checkedListBox.CheckedItems)
            {
                selecteditems.Add(item);
            }

            foreach (var item in selecteditems)
            {
                checkedListBox.Items.Remove(item);
            }
            UpdateStatementList();
            RemoveButton.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ValueBox.Text) && !checkedListBox.Items.Contains(ValueBox.Text))
            {
                checkedListBox.Items.Add(ValueBox.Text);
                UpdateStatementList();
                ValueBox.Text = "";
            }
        }


        private void UpdateStatementList()
        {
            FinancialStatements.StatementNamesList=new List<string>();
            foreach (string item in checkedListBox.Items)
            {
                FinancialStatements.StatementNamesList.Add(item);
            }
        }

    }
}
