using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using DTD.OM.ViewModels.Accounts;
using LiveCharts;
using LiveCharts.Wpf;

namespace DTD.OM.FormsControl.Dialogues
{
    public partial class StatementChart : MetroFramework.Forms.MetroForm
    {
        private Statement Statement { get; set; }

        public StatementChart(Statement statement)
        {
            Statement = statement;
            InitializeComponent();
            UpdateCharts();
        }


        private void UpdateCharts()
        {
            ChartValues<double> chartValues= new ChartValues<double>();
            List<string> chartLables= new List<string>();
            foreach (DailyExpense dailyExpense in Statement.MonthlyExpense.DailyExpenseList)
            {
                chartValues.Add((double)dailyExpense.Total);
                chartLables.Add(dailyExpense.Day.ToString());
            }


            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Day",
                Labels = chartLables.ToArray(),
                
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Cost",
                LabelFormatter = value => value.ToString()+" Taka"
            });

         
            cartesianChart.Series.Add(new LineSeries
            {
                Values = chartValues,
                Title = "Expense:",
                LineSmoothness = 0, //straight lines, 1 really smooth lines,
                PointGeometrySize = 10
            });


        }
    }
}
