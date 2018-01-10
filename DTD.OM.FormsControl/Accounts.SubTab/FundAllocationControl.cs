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

namespace DTD.OM.FormsControl.Accounts.SubTab
{
    public partial class FundAllocationControl : UserControl
    {
        public FundAllocationControl()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var statementForm= new NewStatementForm();
            if (statementForm.ShowDialog() == DialogResult.OK)
            {
                var statementAllocationControl= new StatementAllocationControl(statementForm.Statement)
                {
                    Dock = DockStyle.Top
                    
                };
                ViewPanel.Controls.Add(statementAllocationControl);
            }

        }
    }
}
