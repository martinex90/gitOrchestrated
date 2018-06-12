using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office;
using Microsoft.Office.Core;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace gitOrchestrated
{
    public class ExcelImport
    {
        public ExcelImport(string filepath)
        {
            Microsoft.Office.Interop.Excel.Application ExcelObject = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = ExcelObject.Workbooks.Open(filepath);

            int i = 0;
            foreach (Worksheet ws in wb.Worksheets)
            {
                if (ws.Name == "Hardware Requirement")
                    i = ws.Index;
            }
            if (i == 0)
            {
                throw new ArgumentOutOfRangeException("Excel Column must be within A-Z, and letter must be capitalized");
            }
            worksheet = wb.Worksheets[i];
            usedrange = worksheet.UsedRange;

            lastrow = worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
        }

        
        Worksheet worksheet;
        Range usedrange;
        int lastrow;


        public string ReadCell(string columnLetter, int rowNumber)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("A", 1);
            dictionary.Add("B", 2);
            dictionary.Add("C", 3);
            dictionary.Add("D", 4);
            dictionary.Add("E", 5);
            dictionary.Add("F", 6);
            dictionary.Add("G", 7);
            dictionary.Add("H", 8);
            dictionary.Add("I", 9);
            dictionary.Add("J", 10);
            dictionary.Add("K", 11);
            dictionary.Add("L", 12);
            dictionary.Add("M", 13);
            dictionary.Add("N", 14);
            dictionary.Add("O", 15);
            dictionary.Add("P", 16);
            dictionary.Add("Q", 17);
            dictionary.Add("R", 18);
            dictionary.Add("S", 19);
            dictionary.Add("T", 20);
            dictionary.Add("U", 21);
            dictionary.Add("V", 22);
            dictionary.Add("W", 23);
            dictionary.Add("X", 24);
            dictionary.Add("Y", 25);
            dictionary.Add("Z", 26);

            dictionary.TryGetValue(columnLetter, out int i);

            if (worksheet.Cells[rowNumber, i].Value2 != null)
                return worksheet.Cells[rowNumber, i].Value2;
            else
                return "";

        }

        public void ExcelImportServer()
        {
            MessageBox.Show(lastrow.ToString());
            MessageBox.Show(worksheet.Cells[1, 1].Value2);
            
            foreach(ListObject lobj in worksheet.Columns)
            {
                MessageBox.Show(lobj.Name);
            }

            for (int i = 1; i <= usedrange.Rows.Count; i++)
            {
                if (worksheet.Cells[i, 12].Value2 != null)
                    MessageBox.Show(worksheet.Cells[i, 12].Value2);
            }
            MessageBox.Show(usedrange.Rows.Count.ToString());
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
