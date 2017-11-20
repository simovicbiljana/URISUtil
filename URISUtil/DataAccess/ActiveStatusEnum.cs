using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URISUtil.DataAccess
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActiveStatusEnum
    {
        All,
        Active,
        Inactive
    }
}
