using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.OM.FormsControl.Dialogues;

namespace DTD.OM.FormsControl.CustomControls
{
    public partial class StatementAllocationControl : UserControl
    {
        public StatementAllocationControl()
        {
            InitializeComponent();
        }

        private void BreakDownButton_Click(object sender, EventArgs e)
        {
            StatementBreakdownForm form= new StatementBreakdownForm();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
