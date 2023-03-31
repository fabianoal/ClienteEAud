using System.Text.Json;
using System.Text.Json.Serialization;

namespace eAudStuffCSharp {
    public static class Confs {
        public static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions() {
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
    }
}