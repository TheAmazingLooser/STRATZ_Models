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
    public partial class HeroStatsQuery
    {
        public IList<HeroPositionTimeDetailAverageType> Stats { get; set; }
        public IList<HeroPositionDetailType> Position { get; set; }
        public IList<HeroDryadType> MatchUp { get; set; }
        public HeroPurchasePatternType PurchasePattern { get; set; }
        public HeroItemPurchaseType ItemFullPurchase { get; set; }
        public HeroItemStartingPurchaseType ItemStartingPurchase { get; set; }
        public HeroItemBootPurchaseType ItemBootPurchase { get; set; }
        public HeroHighPerformanceType HighPerformance { get; set; }
        public HeroMatchupType HeroVsHeroMatchup { get; set; }
        public IList<HeroAbilityTalentType> Talent { get; set; }
        public HeroRatingType Ratings { get; set; }
        public IList<HeroMetaTrendType> MetaTrend { get; set; }
        public IList<HeroWinHourType> WinHour { get; set; }
        public IList<HeroWinDayType> WinDay { get; set; }
        public IList<HeroWinWeekType> WinWeek { get; set; }
        public IList<HeroWinMonthType> WinMonth { get; set; }
        public IList<HeroWinGameVersionType> WinGameVersion { get; set; }
        public IList<HeroGuideListType> Guide { get; set; }
    }
}
