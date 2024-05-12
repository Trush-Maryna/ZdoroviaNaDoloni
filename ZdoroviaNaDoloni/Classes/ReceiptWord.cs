using Microsoft.Office.Interop.Word;
using Document = Microsoft.Office.Interop.Word.Document;

namespace ZdoroviaNaDoloni.Classes
{
    public class ReceiptWord
    {
        public static object CreateReceipt(List<OrderBasket.Feedback> panelDataList, decimal totalPrice, int totalCount, List<MapManager.Pharmacy> pharmacyMarks)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = true;

                Document doc = wordApp.Documents.Add();

                AddTitle(doc);
                AddProductsInfo(doc, panelDataList);
                AddTotalInfo(doc, totalPrice, totalCount);
                if (pharmacyMarks.Count > 0)
                {
                    AddPharmaciesInfo(doc, pharmacyMarks);
                }

                string finalFileName = SaveDocument(doc);
                return finalFileName;
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при створенні документа: {ex.Message}");
            }
        }

        private static void AddTitle(Document doc)
        {
            Paragraph title = doc.Content.Paragraphs.Add();
            title.Range.Text = "Ваше замовлення";
            title.Format.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.Font.Size = 16;
            title.Range.Font.Bold = 1;
            title.Format.SpaceAfter = 10;
            title.Range.InsertParagraphAfter();
        }

        private static void AddProductsInfo(Document doc, List<OrderBasket.Feedback> panelDataList)
        {
            Paragraph productsHeader = doc.Content.Paragraphs.Add();
            productsHeader.Range.Text = "Товари:";
            productsHeader.Format.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
            productsHeader.Range.Font.Size = 14;
            productsHeader.Range.Font.Italic = 1;
            productsHeader.Range.InsertParagraphAfter();

            for (int i = 0; i < panelDataList.Count; i++)
            {
                string panelInfo = $"Товар {i + 1}:";
                productsHeader.Range.Font.Size = 14;
                productsHeader.Range.Font.Italic = 0;
                productsHeader.Range.Font.Bold = 1;
                productsHeader.Range.InsertAfter(panelInfo);
                productsHeader.Range.InsertParagraphAfter();

                var productData = panelDataList[i].Product;
                string productInfo = $"Назва: {productData.Name}; \nВиробник: {productData.Developer}";
                productsHeader.Range.Font.Bold = 0;
                productsHeader.Range.InsertAfter(productInfo);
                productsHeader.Range.InsertParagraphAfter();
            }
        }

        private static void AddTotalInfo(Document doc, decimal totalPrice, int totalCount)
        {
            Paragraph totalInfo = doc.Content.Paragraphs.Add();
            totalInfo.Range.InsertParagraphAfter();
            totalInfo.Range.Text = $"Загальна сума: {totalPrice} ₴";
            totalInfo.Range.Font.Bold = 0;
            totalInfo.Range.Font.Color = WdColor.wdColorRed;
            totalInfo.Range.InsertParagraphAfter();
            totalInfo.Range.Text += $"Загальна кількість товарів: {totalCount} шт.";
            totalInfo.Range.InsertParagraphAfter();
        }

        private static void AddPharmaciesInfo(Document doc, List<MapManager.Pharmacy> pharmacyMarks)
        {
            Paragraph pharmaciesInfo = doc.Content.Paragraphs.Add();
            pharmaciesInfo.Range.InsertParagraphAfter();
            pharmaciesInfo.Range.Text = "Забрати у аптеці:";
            pharmaciesInfo.Range.Font.Bold = 1;

            foreach (var pharmacy in pharmacyMarks)
            {
                string pharmacyInfo = $"Назва: {pharmacy.Name}, \nLat: {pharmacy.Latitude}, \nLong: {pharmacy.Longitude}, \nІнформація: {pharmacy.Information}";
                pharmaciesInfo.Range.Font.Bold = 0;
                pharmaciesInfo.Range.InsertAfter(pharmacyInfo);
                pharmaciesInfo.Range.InsertParagraphAfter();
            }
        }

        private static string SaveDocument(Document doc)
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            string fileName = "OrderReceipt";
            string fileExtension = ".docx";
            int count = 1;

            while (File.Exists(Path.Combine(projectDirectory, fileName + "_" + count + fileExtension)))
            {
                count++;
            }

            string finalFileName = Path.Combine(projectDirectory, fileName + "_" + count + fileExtension);
            doc.SaveAs2(finalFileName);
            return finalFileName;
        }

        public static List<string> GetExistingOrderReceiptFiles(string directoryPath)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(directoryPath);
                FileInfo[] files = directory.GetFiles("OrderReceipt*.docx");
                List<string> existingFiles = files.Select(file => file.Name).ToList();
                return existingFiles;
            }
            catch (Exception ex)
            {
                throw new Exception($"Помилка при отриманні списку файлів: {ex.Message}");
            }
        }

        public static void OpenReceiptFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("Файл не знайдено", filePath);
                }

                var wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = true;
                var doc = wordApp.Documents.Open(filePath);

                wordApp.DocumentBeforeClose += (Document doc, ref bool cancel) =>
                {
                    doc.Close();
                    wordApp.Quit();
                };
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при відкритті файлу: {ex.Message}");
            }
        }
    }
}
