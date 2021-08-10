using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dreamlab.Core.Logs;
using Dreamlab.Core.Rest;
using IHUBVASdk;
using Newtonsoft.Json;

namespace TiaxinBankTest
{
    class Program
    {

        static void Main(string[] args)
        {
            string data = "194199CF4C4B0B16AFE52A92F15643EDCFD4695B5889821C9EFFADDDF902350D";
            string encKey = "6E8F2EAF4148ED788C23F36FBF4C078DAF987922D5EB3E1ECBF42D5045B6720EEEFF7388AE004D163F2353C6F52CCC4C5E987C2CD84959267246489D9A72DAF9E7D3C1D863A762224A32C461BE25C9103A409B31DFCE90152AC7ED67EB2667D3A89130DBFDAE4A29DEA30A6C56C2884372F331E4B5B227FD80125B30CE635624AD2D4893F53259863640BC303E9DE3C382BD4D717C2ACD79035E59F087F199B958152C098C6018BCCE8C2E32CB107225D8819377B8DE64BEE55C20C4CF268AF557905DD786A68B42F3C7DE3FD215B3805EAE77E5A0E1568F23EE2C42E9A8340A3A6213F07FD7EE50F7F50C74EBD6106DDB5577188B1D253D3DC9D2B9F6CAB2EF";
            using (IHubTokenClient tokenClient = new IHubTokenClient("27924218001", new ConsoleMessageLog()))
            {
#if DEBUG
                var token = new RequestResult<string>
                {
                    ReturnValue = "test"
                };
#else
                var token = Task.Run(() => tokenClient.GetToken(data, encKey)).Result;
                if (token.HasError)
                {
                    Console.WriteLine("getToken：" + token.ErrorMessage);
                }
#endif
                using (IHubClient client = new IHubClient("27924218001", new ConsoleMessageLog(), token.ReturnValue))
                {
                    var res = Task.Run(() => client.AddVirtualAccount(new VirtualAccountAddReq
                    {
                        entCode = "96645",
                        virtualAccountNo = "96645123456789",
                        amountAvailable = "100",
                    }, "18")).Result;
                    Console.WriteLine(JsonConvert.SerializeObject(res));
                }
            }


            Console.ReadKey();
        }
    }

    public class ConsoleMessageLog : IMessageLog
    {
        public void WriteLog(LogEntry entry)
        {
            Console.WriteLine(entry.Message);
        }

        public void WriteExceptionLog(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        public void WriteSimpleMessage(string title, string message, object parameter = null)
        {
            try
            {
                string dir = Path.Combine(Directory.GetParent(typeof(Program).Assembly.Location).ToString(), "Log");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string text = title + "**********" + message;
                string path = Path.Combine(dir, $"{DateTime.Now:yyyyMM}.txt");
                if (File.Exists(path))
                {
                    File.AppendAllText(path, text);
                }
                else
                {
                    File.WriteAllText(path, text);
                }
                Console.WriteLine("title :" + title);
                Console.WriteLine("message :" + message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e.Message);
            }
        }

        public void SaveAll()
        {

        }
    }
}
