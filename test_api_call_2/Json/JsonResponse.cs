using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using test_api_call_2.TO;

namespace test_api_call_2.Json
{
    [JsonObject(MemberSerialization.OptIn)]
    public class JsonResponse<T>
    {
        [JsonProperty(PropertyName = "jsonrpc", NullValueHandling = NullValueHandling.Ignore)]
        public string JsonRpc { get; set; }

        [JsonProperty(PropertyName = "result", NullValueHandling = NullValueHandling.Ignore)]
        public T Result { get; set; }

        [JsonProperty(PropertyName = "error", NullValueHandling = NullValueHandling.Ignore)]
        public test_api_call_2.TO.Exception Error { get; set; }

        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        [JsonIgnore]
        public bool HasError
        {
            get { return Error != null; }
        }
    }
}
