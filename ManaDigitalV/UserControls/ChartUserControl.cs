using dataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV.UserControls
{
    public partial class ChartUserControl : UserControl
    {
        public ChartUserControl()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
        //private void fillChart()
        //{
        //    chart1.Series["Salary"].Points.AddXY("Ajay", "10000");
        //    chart1.Series["Salary"].Points.AddXY("Ramesh", "8000");
        //    chart1.Series["Salary"].Points.AddXY("Ankit", "7000");
        //    chart1.Series["Salary"].Points.AddXY("Gurmeet", "10000");
        //    chart1.Series["Salary"].Points.AddXY("Suresh", "8500");
        //    //chart title  
        //    chart1.Titles.Add("Salary Chart");
        //}

        private void ChartUserControl_Load(object sender, EventArgs e)
        {
            fillChart1();

        }
        private void fillChart1()
        {
            phbContext pcd = new phbContext();
            chart1.DataSource = pcd.persons.ToList();
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Age of Members"].XValueMember ="fullName";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Age of Members"].YValueMembers ="Age";
            chart1.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            chart1.Titles.Add("جدول سن کارکنان شرکت مانا");
         

        }
    }
}
