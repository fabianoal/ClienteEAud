using System;
using System.IO;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;
using eAudStuffCSharp.EAudTypes.Query.ClassesAuxiliares;
using System.Text.RegularExpressions;

namespace eAudStuffCSharp.Util
{
    public class TabelaConverter : JsonConverter<ValorTabela>
    {

        private static CharacterHtml[] characteresHtml = null;
        private static CharacterHtml[] CharacteresHtml {
            get {
                if (characteresHtml == null)
                {
                    using FileStream fs = new FileStream(Util.Constantes.DIR_DADOS + "/caracteres_html.csv", FileMode.Open);
                    characteresHtml = ServiceStack.Text.CsvSerializer.DeserializeFromStream<CharacterHtml[]>(fs);
                }
                return characteresHtml;
            }
        }
        private static CultureInfo cultureInfo = new CultureInfo("pt-BR", false);
        public override ValorTabela Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(ValorTabela));
            //foreach (CharacterHtml ch in CharacteresHtml)
            //    val = val.Replace(ch.NumericCode, ch.Char);

            string valProc = Regex.Unescape(reader.GetString()).Replace("&#34;", "\"");

            return reader.TokenType switch {
                JsonTokenType.String => JsonSerializer.Deserialize<ValorTabela>(valProc.Substring(1, valProc.Length - 2)),
                _ => new ValorTabela()
            };
        }

        public override void Write(Utf8JsonWriter writer, ValorTabela value, JsonSerializerOptions options)
        {
            string val = "\"" + Regex.Escape(JsonSerializer.Serialize(value)).Replace("\"", "&#34;") + "\"";
            writer.WriteStringValue(val);
        }
    }
}