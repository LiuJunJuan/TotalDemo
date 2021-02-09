using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebSocketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
            {
               var s = Read().Result;
            });
            Console.ReadKey();
        }

        public static async Task<object> Read()
        {
            var webSocket = new ClientWebSocket();
            await webSocket.ConnectAsync(new Uri("ws://localhost:59456/values/delete?brand=ROS"), CancellationToken.None);
            var bsend = System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new
            {
                User = "ROS",
                Action = "Sku",
                QueryParameter =JsonConvert.SerializeObject(new
                {
                    Style = "sddddddddd",
                    Brand ="ROS"
                })
            }));
            await webSocket.SendAsync(new ArraySegment<byte>(bsend), WebSocketMessageType.Binary, true, CancellationToken.None);
            while (true)
            {
                ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[2048]);

                WebSocketReceiveResult result = await webSocket.ReceiveAsync(buffer, new CancellationToken());//接受数据

                var str = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                Console.WriteLine(str);
            }
        }
    }
}
