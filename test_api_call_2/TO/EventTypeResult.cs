using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test_api_call_2.TO
{
    public class EventTypeResult
    {
        [JsonProperty(PropertyName = "eventType")]
        public EventType EventType { get; set; }

        [JsonProperty(PropertyName = "marketCount")]
        public int MarketCount { get; set; }

        public override string ToString()
        {
            return new StringBuilder().AppendFormat("{0}", "EventTypeResult")
                        .AppendFormat(" : {0}", EventType)
                        .AppendFormat(" : MarketCount={0}", MarketCount)
                        .ToString();
        }
    }
}
