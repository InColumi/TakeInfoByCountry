using System;
using System.Net;
using System.Windows.Forms;

namespace Search
{
    class Searcher
    {
        private string _address;
        private string _webPage;
        public string[] SearchResalt { get; private set; }

        public Searcher(string name, string address)
        {
            _address = $"http://restcountries.eu/rest/v2/name/{name}";
            _webPage = "";
            SearchResalt = new string[6];
        }

        public void GetInfoAboutCountry()
        {
            using(WebClient webClient = new WebClient())
            {
                _webPage = TryGetStringFromWebClient(webClient);
                if(_webPage != "")
                {
                    string[] patterns = MakePatternsForSearch();

                    GetSearchResalt(patterns);
                }
            }
        }

        private string TryGetStringFromWebClient(WebClient webClient)
        {
            try
            {
                return webClient.DownloadString(_address);
            }
            catch(Exception)
            {
                MessageBox.Show("Такой страны нет");
                return "";
            }
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

        private void GetSearchResalt(string[] patterns)
        {
            SearchResalt[0] = patterns[0];
            SearchResalt[1] = patterns[1];
            SearchResalt[2] = patterns[2];
            SearchResalt[3] = patterns[3];
            SearchResalt[4] = patterns[4];
            SearchResalt[5] = patterns[5];
        }
    }
}
