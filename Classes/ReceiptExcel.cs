using Microsoft.Office.Interop.Excel;

namespace ZdoroviaNaDoloni.Classes
{
    public class ReceiptExcel
    {
        public static string CreateReceiptSelfPickup(List<OrderBasket.Feedback> panelDataList, decimal totalPrice, int totalCount, List<MapManager.Pharmacy> pharmacyMarks)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excelApp.Workbooks.Add();
                Worksheet worksheet = (Worksheet)workbook.Sheets[1];

                AddTitle(worksheet);
                AddProductsInfo(worksheet, panelDataList);
                AddTotalInfo(worksheet, totalPrice, totalCount);
                if (pharmacyMarks.Count > 0)
                {
                    AddPharmaciesInfo(worksheet, pharmacyMarks);
                }
                string finalFileName = SaveWorkbook(workbook);
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return finalFileName;
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при створенні документа: {ex.Message}");
            }
        }

        public static string CreateReceiptDelivery(List<OrderBasket.Feedback> panelDataList, decimal totalPrice, int totalCount, OrderBasket userinfo)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excelApp.Workbooks.Add();
                Worksheet worksheet = (Worksheet)workbook.Sheets[1];

                AddTitle(worksheet);
                AddUserInfo(worksheet, userinfo);
                AddProductsInfo(worksheet, panelDataList);
                AddTotalInfo(worksheet, totalPrice, totalCount);
                string finalFileName = SaveWorkbook(workbook);
                workbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return finalFileName;
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при створенні документа: {ex.Message}");
            }
        }

        private static void AddTitle(Worksheet worksheet)
        {
            worksheet.Cells[1, 1] = "Ваше замовлення";
            Microsoft.Office.Interop.Excel.Range titleRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 4]];
            titleRange.Merge();
            titleRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            titleRange.Font.Size = 16;
            titleRange.Font.Bold = true;
        }

        private static void AddUserInfo(Worksheet worksheet, OrderBasket userinfo)
        {
            worksheet.Cells[3, 1] = $"Користувач: {userinfo.Name}";
            worksheet.Cells[4, 1] = $"Номер телефону: +380{userinfo.NumTel}";
            worksheet.Cells[5, 1] = $"Область: {userinfo.Region}";
            worksheet.Cells[6, 1] = $"Місто: {userinfo.City}";
            worksheet.Cells[7, 1] = $"Відділення: {userinfo.NumNP}";
        }

        private static void AddProductsInfo(Worksheet worksheet, List<OrderBasket.Feedback> panelDataList)
        {
            int startRow = 9;
            worksheet.Cells[startRow, 1] = "Товари:";
            worksheet.Cells[startRow, 1].Font.Bold = true;

            for (int i = 0; i < panelDataList.Count; i++)
            {
                int row = startRow + i + 1;
                var productData = panelDataList[i].Product;
                worksheet.Cells[row, 1] = $"Товар {i + 1}: Назва: {productData.Name}; Виробник: {productData.Developer}";
            }
        }

        private static void AddTotalInfo(Worksheet worksheet, decimal totalPrice, int totalCount)
        {
            int startRow = worksheet.UsedRange.Rows.Count + 2;
            worksheet.Cells[startRow, 1] = $"Загальна сума: {totalPrice} ₴";
            worksheet.Cells[startRow + 1, 1] = $"Загальна кількість товарів: {totalCount} шт.";
        }

        private static void AddPharmaciesInfo(Worksheet worksheet, List<MapManager.Pharmacy> pharmacyMarks)
        {
            int startRow = worksheet.UsedRange.Rows.Count + 2;
            worksheet.Cells[startRow, 1] = "Забрати у аптеці:";
            worksheet.Cells[startRow, 1].Font.Bold = true;

            for (int i = 0; i < pharmacyMarks.Count; i++)
            {
                int row = startRow + i + 1;
                var pharmacy = pharmacyMarks[i];
                worksheet.Cells[row, 1] = $"Назва: {pharmacy.Name}, Lat: {pharmacy.Latitude}, Long: {pharmacy.Longitude}, Інформація: {pharmacy.Information}";
                Microsoft.Office.Interop.Excel.Range mergedRange = worksheet.Range[worksheet.Cells[row, 1], worksheet.Cells[row, 3]];
                mergedRange.Merge();
            }
        }

        private static string SaveWorkbook(Workbook workbook)
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            string fileName = "OrderReceipt";
            string fileExtension = ".xlsx";
            int count = 1;
            while (File.Exists(Path.Combine(projectDirectory, fileName + "_" + count + fileExtension)))
            {
                count++;
            }
            string finalFileName = Path.Combine(projectDirectory, fileName + "_" + count + fileExtension);
            workbook.SaveAs(finalFileName);
            return finalFileName;
        }
    }
}
