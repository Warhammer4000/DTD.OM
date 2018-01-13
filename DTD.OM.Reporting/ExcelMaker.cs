using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DTD.OM.ViewModels.Accounts;

namespace DTD.OM.Reporting
{
    public class ExcelMaker
    {
        //Constructor Creates an WorkBook. And takes filepath as input.
        //Functions Populated Worksheet then save it.
        //Works For Both buyer and seller as the data has same structure
        private XLWorkbook WorkBook { get; set; }

        private IXLWorksheet WorkSheet { get; set; }

        private string FilePath { get; set; }

        public ExcelMaker(string filepath)
        {
            WorkBook = new XLWorkbook();
            
            FilePath = filepath;
        }

        public void ExportDailyData(Statement statement)
        {

         
            foreach (DailyExpense dailyExpense in statement.MonthlyExpense.DailyExpenseList)
            {
                int sheetname = dailyExpense.Day;
                WorkBook.AddWorksheet(sheetname.ToString());
                WorkSheet = WorkBook.Worksheet(sheetname.ToString());
                int row = 1;
                foreach (ItemExpense itemExpense in dailyExpense.ItemExpenses)
                {
                    WorkSheet.Cell("A" + row).Value = itemExpense.ItemName;
                    WorkSheet.Cell("B" + row).Value = (int)itemExpense.Cost;
                    row++;
                }
                WorkSheet.Cell("A" + row).Value = "Total=";
                WorkSheet.Cell("B" + row).Value = (int)dailyExpense.Total;

            }

            Save();
        }

    

   


        private void Save()
        {
            WorkBook.SaveAs(FilePath);
        }
    }
}
