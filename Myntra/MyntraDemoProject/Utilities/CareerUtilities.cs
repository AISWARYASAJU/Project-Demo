using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.Utilities
{
    internal class CareerUtilities
    {
        public static List<CareerData> ReadExcelData(string excelFilePath, string sheetName)
        {
            List<CareerData> CareerDataList = new List<CareerData>();
            Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true,
                        }
                    });

                    var dataTable = result.Tables[sheetName];

                    if (dataTable != null)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            CareerData careerData = new CareerData
                            {
                                //SearchText = GetValueOrDefault(row, "searchtext"),
                                FirstNameInputBox = GetValueOrDefault(row, "firstName"),
                                LastNameInputBox= GetValueOrDefault(row, "lastName"),
                                EmailInputBox= GetValueOrDefault(row, "email"),
                                PhoneNum= GetValueOrDefault(row, "mbno"),
                                Location= GetValueOrDefault(row, "location"),

                            };

                            CareerDataList.Add(careerData);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sheet '{sheetName}' not found in the Excel file.");
                    }
                }
            }

            return CareerDataList;
        }

        static string GetValueOrDefault(DataRow row, string columnName)
        {
            Console.WriteLine(row + "  " + columnName);
            return row.Table.Columns.Contains(columnName) ? row[columnName]?.ToString() : null;
        }
    }
}



                   
