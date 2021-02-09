using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Path.Combine(Directory.GetParent(typeof(Program).Assembly.Location).ToString(), "ProductUploadTemplate.csv");
            FileStream fileStream = new FileStream(dir,FileMode.Open);
            MemoryStream ms = new MemoryStream();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = CodePagesEncodingProvider.Instance.GetEncoding("big5");
            fileStream.CopyTo(ms);
            string content = encoding.GetString(ms.ToArray());
            StringReader reader = new StringReader(content); 
            CsvHelper.CsvReader csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            {
                string value = csv.GetField<string>("DESCRIPTION");
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
