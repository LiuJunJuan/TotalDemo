using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDeadLock
{
    public class SyncTest
    {
        public async Task<string> GetString()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            var http = new HttpClient();
            var result = await http.GetStringAsync("http://www.imzjy.com");
            var first50 = result.Substring(0, 50);
            Console.WriteLine(Thread.CurrentThread.Name);
            return first50;
        }
    }
}
