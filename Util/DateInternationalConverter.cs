using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Globalization;

namespace eAudStuffCSharp.Util
{
    public class DateInternationalConverter : JsonConverter<DateTime?>
    {
        //private static CultureInfo cultureInfo = new CultureInfo("pt-BR", false);
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(DateTime?));
            string val = reader.GetString();
            return !(String.IsNullOrEmpty(val) || val.Equals("null") )
                ? DateTime.Parse(reader.GetString())
                : new DateTime?();
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value.ToString("yyyy-MM-dd") ?? null);
        }
    }
}