using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Weather_Data
{
    public class APIData
    {
        public string AccessToken { get; private set; }
        public string StationName { get; set; }
        public string Country { get; set; }
        private Dictionary<string, string> data;

        public APIData(string token, string weatherStationName, string countryCode = "pl")
        {
            AccessToken = token;
            StationName = weatherStationName;
            Country = countryCode;

            data = DownloadData();
        }
        private Dictionary<string, string> DownloadData()
        {
            string url = "https://api.synopticdata.com/v2/stations/latest?&" +
                $"token={AccessToken}&" +
                $"stid={StationName}&" +
                $"country={Country}&" +
                "obtimezone=local&" +
                "timeformat=%d.%m.%Yr.&" +
                "units=speed|kph";

            HttpClient client = new HttpClient();
            Dictionary<string, string> observationsDict = new Dictionary<string, string>();

            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;

                JObject json = JObject.Parse(responseBody);
                JObject station = (JObject)json["STATION"][0];
                JObject observations = (JObject)station["OBSERVATIONS"];

                foreach (var observation in observations)
                {
                    JObject observationValue = (JObject)observation.Value;
                    string value = observationValue["value"].ToString();
                    observationsDict.Add(observation.Key, value);
                }
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"Wystąpił wyjątek: {e.InnerException.Message}");
            }

            return observationsDict;
        }
        public void Refresh()
        {
            data = DownloadData();
        }
        public string GetData(string index)
        {
            string output = "--";

            try
            {
                output = data[index];
            }
            catch (KeyNotFoundException) { }

            return output;
        }
    }
}
