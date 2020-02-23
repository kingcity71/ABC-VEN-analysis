using ABCVEN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace ABCVEN.BLL
{
    public class FileUploadService : IFileUploadService
    {
        public string[,] ReadFile(string filePath)
        {
            Excel.Application ObjWorkExcel = new Excel.Application(); //открыть эксель
            Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);//1 ячейку
            var list = new string[lastCell.Row, lastCell.Column]; // массив значений с листа равен по размеру листу
            for (int i = 0; i < lastCell.Row; i++)
                for (int j = 0; j < lastCell.Column; j++)
                {
                    var res = ObjWorkSheet.Cells[i + 1, j + 1].Text.ToString();//считываем текст в строку
                    list[i, j] = res;
                }
            ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            ObjWorkExcel.Quit(); // выйти из экселя
            GC.Collect(); // убрать за собой
            return list;
        }
    }
}
