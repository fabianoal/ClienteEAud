using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Globalization;

namespace eAudStuffCSharp.Util
{
    public class BooleanConverter : JsonConverter<bool?>
    {
        private static CultureInfo cultureInfo = new CultureInfo("pt-BR", false);
        public override bool? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(bool?));
            return reader.TokenType switch
            {
                JsonTokenType.Null => new Nullable<bool>(),
                JsonTokenType.String => !(reader.GetString() == "False"),
                JsonTokenType.Number => reader.GetInt32() != 0,
                _ => new Nullable<bool>()
            };
        }

        public override void Write(Utf8JsonWriter writer, bool? value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Value.ToString() ?? null);
        }
    }
}