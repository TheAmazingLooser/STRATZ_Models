// <auto-generated> This file has been auto generated. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;
#if!GRAPHQL_GENERATOR_DISABLE_NEWTONSOFT_JSON
using Newtonsoft.Json;
#endif

namespace STRATZ
{
    public partial class PlusDraftPlayerHeroObjectType
    {
        public short? HeroId { get; set; }
        public decimal? PickValue { get; set; }
        public IList<object> WinValues { get; set; }
        public decimal? Score { get; set; }
        public PlusLetterType? Letter { get; set; }
    }
}
