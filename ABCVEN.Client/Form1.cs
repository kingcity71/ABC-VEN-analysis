using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ABCVEN.Interfaces;
using Microsoft.Office.Interop.Excel;

namespace ABCVEN
{
    public partial class Form1 : Form
    {
        private readonly IFileUploadService fileUploadService;

        public Form1(IFileUploadService fileUploadService)
        {
            this.fileUploadService = fileUploadService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.FileName;
            var file = fileUploadService.ReadFile(fileName);
            //var fileText = System.IO.File.ReadAllText(fileName);
           // var list = ReadExcel(fileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var app = new Excel.Application();
            app.Visible = true;
            var pathName = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", "") + "Template.xlsx";
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet;
            workbook = app.Workbooks.Add(1);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            try
            {
                //worksheet.Range["A1"].Validation.Add(Excel.XlDVType.xlValidateList, Type.Missing,
                //    Excel.XlFormatConditionOperator.xlBetween, "a,b,c,x");
                var row = 1;
                var cell = (Excel.Range)worksheet.Cells[row, 8];
                cell.Validation.Delete();
                cell.Validation.Add(
                   XlDVType.xlValidateList,
                   XlDVAlertStyle.xlValidAlertInformation,
                   XlFormatConditionOperator.xlBetween,
                   "a,b,c,v",
                   Type.Missing);

                cell.Validation.IgnoreBlank = true;
                cell.Validation.InCellDropdown = true;
            }
            catch(Exception ex)
            {
                
            }
            workbook.SaveAs("123.xlsx");
        }

        
    }
}
