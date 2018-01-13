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
using MetroFramework;

namespace DTD.OM.FormsControl.CustomControls
{
    public partial class ItemExpenseControl : UserControl
    {
        public ItemExpense ItemExpense { get; set; }

        public ItemExpenseControl()
        {
            InitializeComponent();
            ItemExpense= new ItemExpense();
        }

        public ItemExpenseControl(ItemExpense itemExpense)
        {
            InitializeComponent();
            ItemExpense = itemExpense;
            ItemNameBox.Text = itemExpense.ItemName;
            value.Value =  itemExpense.Cost;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (MetroMessageBox.Show(this, "Are you sure?", "Warning", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dispose();
            }
           
        }

        private void ItemNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemExpense.ItemName = ItemNameBox.Text;
            
        }

        private void value_ValueChanged(object sender, EventArgs e)
        {
            ItemExpense.Cost = value.Value;
        }
    }
}
