using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vspheresdk.Authentication
{
    public class LoginResponseType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

}
