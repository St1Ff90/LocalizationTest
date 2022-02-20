using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LocalizationTest
{
    public partial class MainForm : Form
    {
        static HttpClient httpClient = new HttpClient();
        static string url = "https://libretranslate.de/translate";
        string CurrentLocalization = "en";

        public class TranslatedText
        {
            [JsonPropertyName("translatedText")]
            public string Text { get; set; }

            public TranslatedText(string text)
            {
                Text = text;
            }
        }

        public class TranslationQuery
        {
            [JsonPropertyName("q")]
            public string Text { get; set; }

            [JsonPropertyName("source")]
            public string Source { get; set; }

            [JsonPropertyName("target")]
            public string Target { get; set; }

            [JsonPropertyName("format")]
            public string Format { get; private set; }

            public TranslationQuery(string text, string currentLocalization, string targetLocalization)
            {
                Text = text;
                Source = currentLocalization;
                Target = targetLocalization;
                Format = "text";
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public async void Translate(string translateFrom, string translateTo)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name != "btnEN" && control.Name != "btnUA" && control.Name != "btnRU")
                {
                    TranslationQuery translationQuery = new TranslationQuery(control.Text, translateFrom, translateTo);
                    var data = new StringContent(JsonSerializer.Serialize<TranslationQuery>(translationQuery), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = (await httpClient.PostAsync(url, data)).EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    TranslatedText result = JsonSerializer.Deserialize<TranslatedText>(responseBody);
                    control.Text = result.Text;
                }
            }
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            if (CurrentLocalization != "en")
            {
                Translate(CurrentLocalization, "en");
                CurrentLocalization = "en";
            }
        }

        private void btnUA_Click(object sender, EventArgs e)
        {
            if (CurrentLocalization != "uk")
            {
                Translate(CurrentLocalization, "uk");
                CurrentLocalization = "uk";
            }
        }

        private void btnRU_Click(object sender, EventArgs e)
        {
            if (CurrentLocalization != "ru")
            {
                Translate(CurrentLocalization, "ru");
                CurrentLocalization = "ru";
            }
        }
    }
}
