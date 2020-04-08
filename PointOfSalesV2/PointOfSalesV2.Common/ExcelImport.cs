using Microsoft.AspNetCore.Hosting;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Common
{
    public class ExcelImport
    {

        public readonly struct EntityPropValue
        {
            public EntityPropValue(string name, Enums.ExcelColumnsDef def, string value)
            {
                this.Value = value;
                this.Name = name;
                this.ExcelDef = def;
            }
            public string Value { get; }
            public string Name { get; }

            public Enums.ExcelColumnsDef ExcelDef { get; }
        }
        public static string CreateXlsFile(string[] headers, ExcelColumnsDef[] colDef, List<string[]> dataList, IHostingEnvironment hostingEnvironment, string extension = "xls")
        {
            IWorkbook workbook;

            if (extension == "xlsx")
            {
                workbook = new XSSFWorkbook();
            }
            else if (extension == "xls")
            {
                workbook = new HSSFWorkbook();
            }
            else
            {
                throw new Exception("This format is not supported");
            }

            ISheet sheet1 = workbook.CreateSheet("Reporte");

            IRow headerRow = sheet1.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                // String columnName = headers[i];
                cell.SetCellValue(headers[i]);
            }
            for (int i = 0; i < dataList.Count; i++)
            {
                IRow currentRow = sheet1.CreateRow(i + 1);
                for (int j = 0; j < dataList[i].Length; j++)
                {
                    ICell currentCell = currentRow.CreateCell(j);
                    SetCellValue(currentCell, dataList[i][j], colDef[j]);
                }
            }
            string finalFilePath = Path.Combine(Path.Combine(hostingEnvironment.WebRootPath, "downloads\\xls"), $"reporte-{DateTime.Now.Ticks}.xls");
            FileStream xfile = new FileStream(finalFilePath, FileMode.Create, System.IO.FileAccess.Write);
            workbook.Write(xfile);
            xfile.Close();
            return finalFilePath;

        }

        public static string CreateXlsFile(string[] headers, List<List<EntityPropValue>> values, string folderPath, string extension = "xls")
        {
            IWorkbook workbook;

            if (extension == "xlsx")
            {
                workbook = new XSSFWorkbook();
            }
            else if (extension == "xls")
            {
                workbook = new HSSFWorkbook();
            }
            else
            {
                throw new Exception("This format is not supported");
            }

            ISheet sheet1 = workbook.CreateSheet("Reporte");

            IRow headerRow = sheet1.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                // String columnName = headers[i];
                cell.SetCellValue(headers[i]);
            }
            for (int i = 0; i < values.Count; i++)
            {
                IRow currentRow = sheet1.CreateRow(i + 1);
                for (int j = 0; j < values[i].Count; j++)
                {
                    ICell currentCell = currentRow.CreateCell(j);
                    SetCellValue(currentCell, values[i][j].Value, values[i][j].ExcelDef);
                }
            }
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string finalFilePath = Path.Combine(folderPath, $"reporte-{DateTime.Now.Ticks}.xls");
            FileStream xfile = new FileStream(finalFilePath, FileMode.Create, System.IO.FileAccess.Write);
            workbook.Write(xfile);
            xfile.Close();
            return finalFilePath;

        }
        //ExcelImport.DeleteFile(finalFilePath);

        public static MemoryStream CreateXlsStream(string[] headers, List<List<EntityPropValue>> values, string extension = "xls")
        {

            IWorkbook workbook;

            if (extension == "xlsx")
            {
                workbook = new XSSFWorkbook();
            }
            else if (extension == "xls")
            {
                workbook = new HSSFWorkbook();
            }
            else
            {
                throw new Exception("This format is not supported");
            }

            ISheet sheet1 = workbook.CreateSheet("Reporte");

            IRow headerRow = sheet1.CreateRow(0);
            for (int i = 0; i < headers.Length; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                // String columnName = headers[i];
                cell.SetCellValue(headers[i]);
            }
            for (int i = 0; i < values.Count; i++)
            {
                IRow currentRow = sheet1.CreateRow(i + 1);
                for (int j = 0; j < values[i].Count; j++)
                {
                    ICell currentCell = currentRow.CreateCell(j);
                    SetCellValue(currentCell, values[i][j].Value, values[i][j].ExcelDef);
                }
            }

            MemoryStream xfile = new MemoryStream();
            workbook.Write(xfile);

            return xfile;

        }

        private static void SetCellValue(ICell currentCell, string value, ExcelColumnsDef columnsDef)
        {
            switch (columnsDef)
            {
                case ExcelColumnsDef.DECIMAL:
                    currentCell.SetCellValue(Convert.ToDouble(value));
                    break;
                case ExcelColumnsDef.DATETIME:
                case ExcelColumnsDef.TEXT:
                    currentCell.SetCellValue(value);
                    break;
                case ExcelColumnsDef.INTEGER:
                    currentCell.SetCellValue(Convert.ToInt64(value));
                    break;
                default:
                    currentCell.SetCellValue(value);
                    break;

            }
        }

        public static void DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {

            }

        }

    }
}
