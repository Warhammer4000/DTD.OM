using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.FormsControl.CustomControls;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.Dialogues
{
    public partial class StatementBreakdownForm : Form
    {
        public BreakDown Breakdown { get; set; }
        public StatementBreakdownForm(BreakDown breakDown)
        {
            InitializeComponent();
            Breakdown = breakDown;
        }

        private void InitializeData()
        {
            
        }


        private void AddItem_Click(object sender, EventArgs e)
        {
            var dailyExpense= new DailyExpenseControl(){Dock = DockStyle.Top};
            ViewPanel.Controls.Add(dailyExpense);
        }
    }
}
