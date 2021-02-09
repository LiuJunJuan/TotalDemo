using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.WebSockets;
using Newtonsoft.Json;
using WebSocketApi.Models;

namespace WebSocketApi.Controllers
{
    [RoutePrefix("values")]
    public class ValuesController : ApiController
    {
        public static Dictionary<string, WebSocket> ConnectPool =
            new Dictionary<string, WebSocket>(); //用户连接池

        [Route("delete")]
        [HttpGet]
        public HttpResponseMessage Delete()
        {
            if (HttpContext.Current.IsWebSocketRequest)
            {
                HttpContext.Current.AcceptWebSocketRequest(ProcessChat);
                return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);// 构造同意切换至Web Socket的Response.
            }
            return null;
        }

        private async Task ProcessChat(AspNetWebSocketContext context)
        {
            WebSocket socket = context.WebSocket;
            string user = context.QueryString["brand"];
            try
            {
                if (!ConnectPool.ContainsKey(user))
                {
                    ConnectPool.Add(user, socket);
                }
                else
                {
                    WebSocket existSocket = ConnectPool[user];
                    if (existSocket != socket)
                    {
                        ConnectPool[user] = socket;
                    }
                }
                while (true)
                {
                    if (socket.State == WebSocketState.Open)
                    {
                        ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[2048]);
                        WebSocketReceiveResult result = await socket.ReceiveAsync(buffer, CancellationToken.None);

                        try
                        {
                            #region 关闭Socket处理，删除连接池

                            if (socket.State != WebSocketState.Open) 
                            {
                                if (ConnectPool.ContainsKey(user)) 
                                    ConnectPool.Remove(user); 
                                break;
                            }

                            string userMsg = Encoding.UTF8.GetString(buffer.Array, 0, result.Count); //发送过来的消息
                            SocketQueryParameter parameter = JsonConvert.DeserializeObject<SocketQueryParameter>(userMsg);
                            if (parameter != null)
                            {
                                buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(parameter.QueryParameter));

                                if (ConnectPool.ContainsKey(user)) //判断客户端是否在线
                                {
                                    WebSocket destSocket = ConnectPool[user]; //目的客户端
                                    if (destSocket != null && destSocket.State == WebSocketState.Open)
                                        await destSocket.SendAsync(buffer, WebSocketMessageType.Text, true,
                                            CancellationToken.None);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            await ConnectPool["ROS"].SendAsync(buffer, WebSocketMessageType.Text, true,
                                CancellationToken.None);
                            //消息转发异常处理，本次消息忽略 继续监听接下来的消息
                        }

                        #endregion
                    }
                    else
                    {
                        break;
                    }
                } //while end
            }
            catch (Exception ex)
            {
                //整体异常处理
                if (ConnectPool.ContainsKey(user)) ConnectPool.Remove(user);
            }
        }
    }
}
