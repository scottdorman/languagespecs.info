using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageSpecs.Web.Models
{
    public class LanguageSpecData
    {
        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("icon")]
        public string Icon { get; private set; }

        [JsonProperty("logo")]
        public string Logo { get; private set; }

        [JsonProperty("specUrl")]
        public string SpecUrl { get; private set; }
    }
}
