using Newtonsoft.Json;

namespace GenericHttpClient.HttoClientModel
{
    public class TokenResponse
    {
        [JsonProperty(propertyName: "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(propertyName: "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(propertyName: "expires_in")]
        public long ExpiresIn { get; set; }

        [JsonProperty(propertyName: "refresh_token")]
        public string RefreshToken { get; set; }
    }
}
