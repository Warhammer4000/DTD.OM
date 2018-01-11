using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.CustomControls
{
    public partial class ItemExpenseControl : UserControl
    {
        public ItemExpense DailyExpense { get; set; }

        public ItemExpenseControl()
        {
            InitializeComponent();
            DailyExpense= new ItemExpense();
        }

        public ItemExpenseControl(ItemExpense dailyExpense)
        {
            InitializeComponent();
            DailyExpense = dailyExpense;
            ItemNameBox.Text = dailyExpense.ItemName;
            value.Value =  dailyExpense.Cost;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ItemNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DailyExpense.ItemName = ItemNameBox.Text;
            
        }

        private void value_ValueChanged(object sender, EventArgs e)
        {
            DailyExpense.Cost = value.Value;
        }
    }
}
