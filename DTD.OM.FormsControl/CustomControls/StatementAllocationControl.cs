using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.FormsControl.Dialogues;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.CustomControls
{
    public partial class StatementAllocationControl : UserControl
    {
        public Statement Statement { get; set; }
        public StatementAllocationControl()
        {
            InitializeComponent();
            Statement=new Statement(DateTime.Today.Month,DateTime.Today.Year);
        }

        public StatementAllocationControl(Statement statement)
        {
            InitializeComponent();
            Statement = statement;
            Allocated.Value = Statement.Allocated;
            Left.Value = Statement.Left;
            StatementLable.Text=new DateTimeFormatInfo().GetMonthName(statement.Month)+@","+statement.Year;
        }

        private void BreakDownButton_Click(object sender, EventArgs e)
        {
            var form= new StatementBreakdownForm(Statement.BreakDown,Statement.Month,Statement.Year);
            if (form.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void Allocated_ValueChanged(object sender, EventArgs e)
        {
            Statement.Allocated = Allocated.Value;
        }
    }
}
