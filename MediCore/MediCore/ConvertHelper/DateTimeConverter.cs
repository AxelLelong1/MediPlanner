using System.Text.Json;
using System.Text.Json.Serialization;

namespace MediCore.ConvertHelper
{
    /// <summary>
    /// Needed because of the fucking winter/summer time change in France....
    /// </summary>
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            // Formater la date au format 'YYYY-MM-DDTHH:MM:SS'
            writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ss"));
        }
    }

}
