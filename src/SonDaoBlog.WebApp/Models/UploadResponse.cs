using System.Text.Json.Serialization;

namespace SonDaoBlog.WebApp.Models
{
    public class UploadResponse
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }
    }
}
