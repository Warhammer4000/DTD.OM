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
using DTD.OM.Reporting;
using DTD.OM.Serializer;
using DTD.OM.ViewModels;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.FormsControl.CustomControls
{
    public partial class StatementAllocationControl : UserControl
    {
        public Statement Statement { get; set; }
        public StatementAllocationControl(string name)
        {
            InitializeComponent();
            Statement=new Statement(DateTime.Today.Month,DateTime.Today.Year);
            StatementLable.Text = name;
        }

        public StatementAllocationControl(Statement statement)
        {
            InitializeComponent();
            Statement = statement;
            Allocated.Value = Statement.Allocated;
            Left.Value = Statement.Left;
            StatementLable.Text=statement.Name;
        }

        private void BreakDownButton_Click(object sender, EventArgs e)
        {
            var form= new StatementBreakdownForm(Statement);
            if (form.ShowDialog() == DialogResult.OK)
            {
                
                SaveAndLoad.SaveLocalData("Fundallocation.json", Globals.ViewModelGlobals.FundAllocation);
                Statement = form.Statement;
                UpdateViewData();
            }

        }

        private void UpdateViewData()
        {
            Left.Value = Statement.Left;
     
        }


        private void Allocated_ValueChanged(object sender, EventArgs e)
        {
            Statement.Allocated = Allocated.Value;
          

        }

        private void Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = ".xlsx",
                Filter = @"Office Files|*.xlsx"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelMaker excelMaker= new ExcelMaker(fileDialog.FileName);
                excelMaker.ExportDailyData(Statement);
            }
        }
    }
}
