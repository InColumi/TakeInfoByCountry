using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SearchByCountry
{
    public class Search
    {
        private string _address;
        private string _webPage;
        public string[] Resalt { get; private set; }

        public Search(string nameCountry)
        {
            _address = MakeAPILink(nameCountry);
            _webPage = "";
            Resalt = new string[6];
        }

        private string MakeAPILink(string nameCountry)
        {
            return $"http://restcountries.eu/rest/v2/name/{nameCountry}";
        }

        public void SetResaltByPatterns()
        {
            using(WebClient webClient = new WebClient())
            {
                _webPage = TryGetStringFromWebClient(webClient);
                if(_webPage != "")
                {
                    string[] patterns = MakePatternsForSearch();
                    SetResalt(patterns);
                }
            }
        }

        private string TryGetStringFromWebClient(WebClient webClient)
        {
            try
            {
                return webClient.DownloadString(_address);
            }
            catch(WebException exception)
            {
                if("Удаленный сервер возвратил ошибку: (404) Не найден." == exception.Message)
                {
                    MessageBox.Show("Такой Страны нет.");
                }
                else
                {
                    MessageBox.Show(exception.Message);
                }
                
            }

            return "";
        }

        private string[] MakePatternsForSearch()
        {
            string[] patterns = { "\"name\":\"(.*?)\",",
                "\"alpha2Code\":\"(.*?)\",",
                "\"capital\":\"(.*?)\",",
                "\"area\":(.*?),\"",
                "\"population\":(.*?),\"",
                "\"region\":\"(.*?)\","
            };
            return patterns;
        }

        private void SetResalt(string[] patterns)
        {
            Resalt[0] = GetInfoByPattern(patterns[0]);
            Resalt[1] = GetInfoByPattern(patterns[1]);
            Resalt[2] = GetInfoByPattern(patterns[2]);
            Resalt[3] = GetInfoByPattern(patterns[3]);
            Resalt[4] = GetInfoByPattern(patterns[4]);
            Resalt[5] = GetInfoByPattern(patterns[5]);
        }

        private string GetInfoByPattern(string pattern)
        {
            Match match = Regex.Match(_webPage, pattern);
            return match.Groups[1].Value;
        }
    }
}
