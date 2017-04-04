using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PHDS.core.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PHDS.core.Entities
{
    public class ChinaDateTimeConverter : DateTimeConverterBase
    {
        private static IsoDateTimeConverter dtConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" };

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return dtConverter.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            dtConverter.WriteJson(writer, value, serializer);
        }
    }

    public class ClockResultTimeConverter : DateTimeConverterBase
    {
        private static IsoDateTimeConverter dtConverter = new IsoDateTimeConverter { DateTimeFormat = "HH:mm" };

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return dtConverter.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            dtConverter.WriteJson(writer, value, serializer);
        }
    }

    public class ComputedClockResult
    {
        public int RangeId { get; set; }

        public string RangeName { get; set; }

        public string RangeString { get; set; }

        [JsonConverter(typeof(ClockResultTimeConverter))]
        public DateTime? ClockInTime { get; set; }

        [JsonConverter(typeof(ClockResultTimeConverter))]
        public DateTime? ClockOutTime { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ClockResultEnum ClockInResult { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ClockResultEnum ClockOutResult { get; set; }
    }

    public enum ClockResultEnum
    {
        无记录,
        正常,
        迟到,
        早退,
    }
}
