﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XWPF.UserModel;
using NPOI.HSSF.Util;
using System.IO;
using System.Linq;

namespace Asc
{
    public class Efa_Dic_StringList_DoubleList_Fpi
    {
        public string SheetName;
        public string FilePath;

        public ConcurrentDictionary<string, List<string>> dicListDate = new ConcurrentDictionary<string, List<string>>();
        public ConcurrentDictionary<string, List<double>> dicListFpi = new ConcurrentDictionary<string, List<double>>();

        public void CreateExcel()
        {
            IWorkbook workbook = new XSSFWorkbook();
            try
            {
                ISheet sheet = workbook.CreateSheet(SheetName);
                ICellStyle cellStyle = workbook.CreateCellStyle();
                IDataFormat format = workbook.CreateDataFormat();
                cellStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

                var RowIter = 0;
                var ColIter = 0;

                // Header Line - Food
                var row = sheet.CreateRow(RowIter);
                ColIter = 0;
                row.CreateCell(ColIter).SetCellValue("Food");
                RowIter++;

                // Data Lines - Food
                row = sheet.CreateRow(RowIter);
                ColIter = 0;
                dicListDate.TryGetValue("Food", out List<string> ListDate);
                foreach (var val in ListDate)
                {
                    DateTime t = ParseStringToDateTime(val);
                    NPOI.SS.UserModel.ICell cell = row.CreateCell(ColIter);
                    cell.SetCellValue(t);
                    cell.CellStyle = cellStyle;
                    ColIter++;
                }
                RowIter++;

                row = sheet.CreateRow(RowIter);
                ColIter = 0;
                dicListFpi.TryGetValue("Food", out List<double> ListFpi);
                foreach (var val in ListFpi)
                {
                    row.CreateCell(ColIter).SetCellValue(val);
                    ColIter++;
                }
                RowIter++;


                foreach (KeyValuePair<string, List<double>> entry
                    in dicListFpi.OrderBy(o => o.Key).ToDictionary(o => o.Key, p => p.Value))
                {
                    if (entry.Key == "Food")
                        continue;

                    // Header Line - Except Food
                    row = sheet.CreateRow(RowIter);
                    ColIter = 0;
                    row.CreateCell(ColIter).SetCellValue(entry.Key);
                    RowIter++;

                    // Data Lines - Except Food
                    row = sheet.CreateRow(RowIter);
                    ColIter = 0;
                    foreach (var val in entry.Value)
                    {
                        DateTime t = ParseStringToDateTime(dicListDate[entry.Key][ColIter]);
                        NPOI.SS.UserModel.ICell cell = row.CreateCell(ColIter);
                        cell.SetCellValue(t);
                        cell.CellStyle = cellStyle;
                        //row.CreateCell(ColIter).SetCellValue(t);
                        ColIter++;
                    }
                    RowIter++;

                    row = sheet.CreateRow(RowIter);
                    ColIter = 0;
                    foreach (var val in entry.Value)
                    {
                        row.CreateCell(ColIter).SetCellValue(val);
                        ColIter++;
                    }
                    RowIter++;
                }

                // Save Workbook
                FileInfo FI = new FileInfo(FilePath);
                FI.Directory.Create();  // If the directory already exists, this method does nothing.
                FileStream file = new FileStream(FilePath, FileMode.Create);
                workbook.Write(file);
                file.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                workbook.Close();
            }
        }

        private DateTime ParseStringToDateTime(string s)
        {
            //string[] splits = s.Split('M');
            //return DateTime.Parse(splits[0] + "-" + splits[1] + "-01"); // yyyy-MM-dd
            return DateTime.Parse(s + "-01"); // yyyy-MM-01
        }
    }
}
