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
    public partial class CaptainJackIdentityPrivateProfileType
    {
        public object CaptainJackIdentityId { get; set; }
        public string Name { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Twitch { get; set; }
        public string YouTube { get; set; }
        public long? PremiumEndDate { get; set; }
        public bool? IsAdmin { get; set; }
        public byte? FeedLevel { get; set; }
        public byte? EmailLevel { get; set; }
        public bool? DailyEmail { get; set; }
        public bool? WeeklyEmail { get; set; }
        public bool? MonthlyEmail { get; set; }
        public byte? ProCircuitFeedLevel { get; set; }
        public byte? ProCircuitEmailLevel { get; set; }
        public byte? ThemeType { get; set; }
        public byte? LanguageId { get; set; }
        public string EmailValidationCode { get; set; }
        public bool? IsEmailValidated { get; set; }
        public byte? EmailHour { get; set; }
        public long? LastReadFeedTime { get; set; }
        public long? LastDailyEmail { get; set; }
        public long? LastWeeklyEmail { get; set; }
        public long? LastMonthlyEmail { get; set; }
        public long? LastLeagueDailyEmail { get; set; }
        public long? LastTeamDailyEmail { get; set; }
        public long? LastProCircuitDailyEmail { get; set; }
        public string UnsubscribeCode { get; set; }
        public long? LastSeen { get; set; }
    }
}
