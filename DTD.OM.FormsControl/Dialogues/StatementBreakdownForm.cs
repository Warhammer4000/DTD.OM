﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using DTD.OM.FormsControl.CustomControls;
using DTD.OM.Serializer;
using DTD.OM.ViewModels;
using DTD.OM.ViewModels.Accounts;
using MetroFramework;

namespace DTD.OM.FormsControl.Dialogues
{
    public partial class StatementBreakdownForm : MetroFramework.Forms.MetroForm
    {
        public Statement Statement { get; set; }
        public MonthlyExpense Breakdown { get; set; }
        
        private DailyExpense DailyExpense { get; set; }

        public List<ItemExpense> CopyList { get; set; }


        public StatementBreakdownForm(Statement statement)
        {
            InitializeComponent();
            Statement = statement;
            Breakdown = Statement.MonthlyExpense;
            CopyList= new List<ItemExpense>();
            Allocation.Value = Statement.Allocated;
            MonthLable.Text = @","+new DateTimeFormatInfo().GetMonthName(Breakdown.Month)+ @",";
            YearLable.Text = Breakdown.Year.ToString();
            var days = DateTime.DaysInMonth(Breakdown.Year, Breakdown.Month);
            for (var i=1;i<=days;i++)
            {
                DayBox.Items.Add(i);
            }

            DayBox.SelectedIndex = DateTime.Today.Day-1;

           
        }

        private void InitializeData(int day)
        {
            DailyExpense = Breakdown.DailyExpenseList[day];
            if (DailyExpense.Threshold == 0)
            {
                DailyExpense.Threshold = Statement.Allocated / DateTime.DaysInMonth(Breakdown.Year, Breakdown.Month);
            }
            dailyThreashold.Value = DailyExpense.Threshold;

            Total.Value = DailyExpense.Total;
            ViewPanel.Controls.Clear();

            foreach (var itemExpense in DailyExpense.ItemExpenses)
            {
                var itemExpenseControl = new ItemExpenseControl(itemExpense) { Dock = DockStyle.Top };
                itemExpenseControl.ItemNameBox.TextChanged += ValueChanged;
                itemExpenseControl.value.ValueChanged += ValueChanged;
                itemExpenseControl.RemoveButton.Click += ValueChanged;
                itemExpenseControl.RemoveButton.Click += RemoveButton_Click; ;
                ViewPanel.Controls.Add(itemExpenseControl);
            }

            
            


        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //ItemExpenseControl item = (ItemExpenseControl) sender;
            //Log log = new Log
            //{
            //    Message = item.ItemNameBox.Text+" of value "+item.value + @" was removed by" + @" Super User",
            //    LogObject = Factory<ItemExpense>.ToJson(item.ItemExpense)
            //};
            //DailyExpense.DailyLogs.Push(log);

        }

        private void ValueChanged(object sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (ItemExpenseControl itemExpense in ViewPanel.Controls)
            {
                sum += itemExpense.ItemExpense.Cost;
            }
            Total.Value = sum;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            var itemExpenseControl = new ItemExpenseControl(){Dock = DockStyle.Top};
            itemExpenseControl.ItemNameBox.TextChanged += ValueChanged;
            itemExpenseControl.value.ValueChanged += ValueChanged;
            itemExpenseControl.RemoveButton.Click += ValueChanged;
        
            ViewPanel.Controls.Add(itemExpenseControl);

            //Log log = new Log
            //{
            //    Message = "New Item" + @" was added by" + @" Super User" ,
            //    LogObject = Factory<DailyExpense>.ToJson(DailyExpense)
            //};
            //DailyExpense.DailyLogs.Push(log);
        }

       

        private void Total_ValueChanged(object sender, EventArgs e)
        {
            DailyExpense.Total = Total.Value;

            decimal total = 0;
            foreach (DailyExpense dailyExpense in Breakdown.DailyExpenseList)
            {
                total += dailyExpense.Total;
            }
            Left.Value = Allocation.Value - total;

            Statement.Left = Left.Value;
            decimal difference = dailyThreashold.Value - Total.Value;
            if (difference < 0)
            {
                //InfoLable.Text = @"Daily limit crossed, Fix daily threashold";
                //InfoLable.ForeColor=Color.Red;
                MetroMessageBox.Show(this, "Daily Limit Crossed", "Information!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //Log log = new Log
                //{
                //    Message = "Daily Limit" + @" was Crossed by" + @" Super User" +"By"+(int)difference,
                //    LogObject = Factory<DailyExpense>.ToJson(DailyExpense)
                //};
                //DailyExpense.DailyLogs.Push(log);
            }
            else
            {
                //InfoLable.Text = @"You have "+(int)difference+@" Surplus for today";
                //InfoLable.ForeColor = Color.DarkGreen;
            }

        }

        private void dailyThreashold_ValueChanged(object sender, EventArgs e)
        {
            DailyExpense.Threshold = dailyThreashold.Value;
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DailyExpense.Total = Total.Value;
            DailyExpense.ItemExpenses.Clear();
            foreach (ItemExpenseControl itemExpense in ViewPanel.Controls)
            {
                DailyExpense.ItemExpenses.Add(itemExpense.ItemExpense);
            }
            DialogResult = DialogResult.OK;
            base.OnFormClosing(e);
        }

        private void DayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DailyExpense.Total = Total.Value;
                DailyExpense.ItemExpenses.Clear();
                foreach (ItemExpenseControl itemExpense in ViewPanel.Controls)
                {
                    DailyExpense.ItemExpenses.Add(itemExpense.ItemExpense);
                }
            }
            catch (Exception)
            {
                //Ignored
            }
            
            InitializeData(DayBox.SelectedIndex);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyList = DailyExpense.ItemExpenses;
            pasteToolStripMenuItem.Enabled = true;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var itemExpense in CopyList)
            {
                var itemExpenseControl = new ItemExpenseControl(itemExpense) { Dock = DockStyle.Top };
                itemExpenseControl.ItemNameBox.TextChanged += ValueChanged;
                itemExpenseControl.value.ValueChanged += ValueChanged;
                itemExpenseControl.RemoveButton.Click += ValueChanged;
                itemExpenseControl.RemoveButton.Click += RemoveButton_Click; ;
                ViewPanel.Controls.Add(itemExpenseControl);
            }
        }
    }
}
