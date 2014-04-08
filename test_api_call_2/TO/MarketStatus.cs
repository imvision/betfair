using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace test_api_call_2.TO
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketStatus
    {
        INACTIVE, OPEN, SUSPENDED, CLOSED
    }
}
