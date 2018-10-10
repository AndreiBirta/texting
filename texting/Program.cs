using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.XPath;
using texting.languageServiceReference;
using Excel = Microsoft.Office.Interop.Excel;


namespace texting
{
    class Program
    {
        static void Main(string[] args)
        {
            ExtractExcelText();
        }

        private static void ExtractExcelText()
        {
            string path = @"C:\Users\andrei.birta\Downloads\eldrador_original.xml";
            Excel.Application excelApplication = new Excel.Application();
            Excel.Workbook workBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet workSheet = workBook.Worksheets["Sheet1"];
            Excel.Range range = workSheet.Columns[1];//Range of Column A
            Excel.Range findRange;
            string strToFind = "AA3";
            string valueInColumnJ;
            string valueInColumnK;
            findRange = range.Value;

        }

        private static Dictionary<string, string> GetXmlText()
        {

            string path = @"C:\Users\andrei.birta\Downloads\eldrador_FaraDiactritice.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XPathNavigator navigator = doc.CreateNavigator();
            XmlNamespaceManager manager = new XmlNamespaceManager(navigator.NameTable);
            manager.AddNamespace("ss", "urn:schemas-microsoft-com:office:spreadsheet");

            var y = doc.SelectNodes("//ss:Row[@ss:StyleID='s25']/ss:Cell[position()=4 or position()=5]", manager);
            Dictionary<string, string>text = new Dictionary<string, string>();
            int i = 0;
            string tempText = null;
            foreach (XmlNode node in y)
            {
                i++;
                try
                {
                    if (i % 2 == 0)
                        text.Add(tempText, node.InnerText);
                    else
                    {
                        tempText = node.InnerText;
                    }
                }
                catch (ArgumentException e)
                {

                }

                /*XmlNode cellNode = node;
                XmlNode dataNode = node.FirstChild;
                dataNode.InnerText = "asdf";
                cellNode.AppendChild(dataNode);
                
                node.ParentNode.AppendChild(cellNode);*/
            }

            doc.Save(@"C:\Users\andrei.birta\Downloads\test.xml");
            File.WriteAllLines(@"C:\Users\andrei.birta\Downloads\testsssssss.xml", text.Select(x => "EN: " + x.Key + " RO: " + x.Value).ToArray());
            Console.WriteLine("XML text extracted! ");

            return text;
        }

        public static string TranslateText(string input)
        {
            string output;
            LanguageServiceClient client = new LanguageServiceClient();
            output = client.Translate("00ecbb11-7165-41ca-ac9c-7ec957b8cfd7", input, "en", "ro");

            return output;
        }
    }
}
