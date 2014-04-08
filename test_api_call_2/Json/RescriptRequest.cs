using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace test_api_call_2.Json
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RescriptRequest
    {

        [JsonProperty(PropertyName = "")]
        public IDictionary<string, object> args { get; set; }

        public RescriptRequest(IDictionary<string, object> args)
        {
            this.args = args;
        }
    }
}
