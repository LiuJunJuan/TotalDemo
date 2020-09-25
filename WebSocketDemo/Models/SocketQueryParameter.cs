using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSocketDemo.Models
{
    public class SocketQueryParameter
    {
        public string User { get; set; }
        public string Action { get; set; }
        public string QueryParameter { get; set; }
    }

    public class Sku
    {
        public string Style { get; set; }
        public string Brand { get; set; }
    }
}