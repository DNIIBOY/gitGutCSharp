using System;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Text;
using RestSharp;

namespace Tests{
    class Program{
        private static readonly HttpClient Client = new HttpClient();

        static void GetFactors(string number){
            var url = $"http://factordb.com/api?query={number}";
            var request = WebRequest.Create(url);
            request.Method = "GET";

            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            Console.WriteLine(data);

        }

        static void Main(string[] args){
            GetFactors("783340156742833416191");
        }
    }
}