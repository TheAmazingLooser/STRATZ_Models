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
    public partial class MatchPlayerStatsFarmDistributionReportType
    {
        public IList<MatchPlayerStatsFarmDistributionObjectType> CreepType { get; set; }
        public IList<MatchPlayerStatsFarmDistributionObjectType> CreepLocation { get; set; }
        public IList<MatchPlayerStatsFarmDistributionObjectType> NeutralLocation { get; set; }
        public IList<MatchPlayerStatsFarmDistributionObjectType> AncientLocation { get; set; }
        public IList<MatchPlayerStatsFarmDistributionObjectType> Buildings { get; set; }
        public int? BuyBackGold { get; set; }
        public int? AbandonGold { get; set; }
        public MatchPlayerStatsFarmDistributionObjectType BountyGold { get; set; }
        public IList<MatchPlayerStatsFarmDistributionObjectType> Other { get; set; }
    }
}
