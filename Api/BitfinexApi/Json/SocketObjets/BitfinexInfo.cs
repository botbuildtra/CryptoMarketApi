﻿using Newtonsoft.Json;

namespace Bitfinex.Json.SocketObjets
{
    public class BitfinexInfo
    {
        public string Event { get; set; }
        public int Version { get; set; }
        public int Code { get; set; }
        [JsonProperty("msg")]
        public string Message { get; set; }
    }
}
