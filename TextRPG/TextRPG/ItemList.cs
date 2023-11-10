using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class ItemList
    {
        public int[] Code;

        public ItemList()
        {

        }
        public void ExcelDataLoad()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var path = @"D:\VisualStudio\file\TextRPG\TextRPG\ItemList.xlsx";
            var streamer = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var reader = ExcelReaderFactory.CreateReader(streamer))
            {
                // 모든 시트 로드
                DataTableCollection tables = reader.AsDataSet().Tables;
                for (var sheetIndex = 0; sheetIndex < tables.Count; sheetIndex++)
                {
                    DataTable sheet = tables[sheetIndex];

                    // 시트 이름 필터링 가능
                    Console.WriteLine($"Sheet[{sheetIndex}] Name: {sheet.TableName}");
                    for (var rowIndex = 3; rowIndex < sheet.Rows.Count; rowIndex++)
                    {
                        // 행 가져오기
                        var slot = sheet.Rows[rowIndex];
                        for (var columnIndex = 1; columnIndex < slot.ItemArray.Length; columnIndex++)
                        {
                            var item = slot.ItemArray[columnIndex];
                            //int codeArr = 0;*/
                            
                            //if (rowIndex == 4)
                            //{
                            //   // Code[codeArr] = (int)sheet.Rows[rowIndex][1];
                            //}
                            //else if (rowIndex == 5)
                            //{
                            //    //Code[codeArr] = sheet.Rows[rowIndex][1].ToString();
                            //}
                            //codeArr++;
      
                            Console.Write($"{item}    ");
                            // 열 가져오기
                            //Console.Write($"slot[{rowIndex}][{columnIndex}] : {item}");
                        }
                        Console.WriteLine();
                    }
                }
                reader.Dispose();
                reader.Close();
            }
        }
    }
}
