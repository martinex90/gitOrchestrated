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
                if (ws.Name == "ServerList")
                    i = ws.Index;
            }
            if (i == 0)
            {
                throw new ArgumentOutOfRangeException("Worksheet \"ServerList\" not found.");
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

            System.Windows.Forms.Application.UseWaitCursor = false;

            if (worksheet.Cells[rowNumber, i].Value2 != null)
                return worksheet.Cells[rowNumber, i].Value2;
            else
                return "";

        }

        public void ExcelImportServer(chbTest form)
        {
            System.Windows.Forms.Application.UseWaitCursor = true;

            Dictionary<string, int> headers = new Dictionary<string, int>();

            //skip header row
            List<Server> servers = new List<Server>();
            int row = 2;
            int maxcolumns = 1;
            int maxrows = 1;


            //create header dictionary and count columns
            while (worksheet.Cells[1, maxcolumns].Value2 != null)
            {
                headers.Add(worksheet.Cells[1, maxcolumns].Value2.ToString(), maxcolumns);
                maxcolumns++;
            }

            //count rows
            while (worksheet.Cells[maxrows, headers["Servername"]].Value2 != null)
            {
                maxrows++;
            }

            while (row <= maxrows)
            {

                Server server = new Server();

                for (int i = 1; i <= maxcolumns; i++)
                {
                    if (worksheet.Cells[row, i].Value2 == null)
                        continue;

                    if (headers["VDCName"] == i)
                    {
                        server.VDCName = worksheet.Cells[row, headers["VDCName"]].Value2.ToString();
                        continue;
                    }

                    if (headers["Servername"] == i)
                    {
                        server.VMName = worksheet.Cells[row, headers["Servername"]].Value2.ToString();
                        continue;
                    }

                    if (headers["Template Version"] == i)
                    {
                        server.TemplateVer = worksheet.Cells[row, headers["Template Version"]].Value2.ToString();
                        continue;
                    } 

                    if (headers["Windows Version"] == i)
                    {
                        server.WinVer = worksheet.Cells[row, headers["Windows Version"]].Value2.ToString();
                        continue;
                    }

                    if (headers["Windows Edition"] == i)
                    {
                        server.WinEdition = worksheet.Cells[row, headers["Windows Edition"]].Value2.ToString();
                        continue;
                    }

                    if (headers["CPU"] == i)
                    {
                        server.CPUNo = worksheet.Cells[row, headers["CPU"]].Value2.ToString();
                        continue;
                    }

                    if (headers["RAM"] == i)
                    {
                        server.RAM = worksheet.Cells[row, headers["RAM"]].Value2.ToString();
                        continue;
                    }
                        
                    if (headers["AD Domain"] == i)
                    {
                        server.ADJoin = worksheet.Cells[row, headers["AD Domain"]].Value2.ToString();
                        continue;
                    }

                    if (headers["Network Name"] == i)
                    {
                        server.OrgNetworkName = worksheet.Cells[row, headers["Network Name"]].Value2.ToString();
                        continue;
                    }

                    if (headers["IP Address"] == i)
                    {
                        server.IPAdd = worksheet.Cells[row, headers["IP Address"]].Value2.ToString();
                        continue;
                    }

                    if (headers["DNS1"] == i)
                    {
                        server.DNS1 = worksheet.Cells[row, headers["DNS1"]].Value2.ToString();
                        continue;
                    }
                        
                    if (headers["DNS2"] == i)
                    {
                        server.DNS2 = worksheet.Cells[row, headers["DNS2"]].Value2.ToString();
                        continue;
                    }
                     
                    if (headers["Endpoint Protection"] == i)
                    {
                        server.EndpointProtection = worksheet.Cells[row, headers["Endpoint Protection"]].Value2.ToString();
                        continue;
                    }
                        
                }//for each column

                row++;

                if (server.VMName == "" || server.VMName == null)
                    continue;
                servers.Add(server);
            }


            foreach(Server server in servers)
            {
                CustomPanel pn = new CustomPanel(form);
                pn.CopyFromServer(server);
            }

            /*
            MessageBox.Show(lastrow.ToString());
            MessageBox.Show(worksheet.Cells[1, 1].Value2);
            


            for (int i = 1; i <= usedrange.Rows.Count; i++)
            {
                if (worksheet.Cells[i, 12].Value2 != null)
                    MessageBox.Show(worksheet.Cells[i, 12].Value2);
            }
            MessageBox.Show(usedrange.Rows.Count.ToString());
            */
            System.Windows.Forms.Application.UseWaitCursor = false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
