using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace test_api_call_2.TO
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExecutionReportStatus
    {
        SUCCESS,
        FAILURE,
        PROCESSED_WITH_ERRORS,
        TIMEOUT
    }
}
