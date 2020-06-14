using IntegradorIbge.Infra.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorIbge.Infra
{
    public class ConexaoHttpClient
    {
        private  HttpClient _client { get; set; }
        private HttpClientHandler handler = new HttpClientHandler()
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
        };

        public ConexaoHttpClient()
        {
            _client = new HttpClient(handler);
        }

        public HttpResponseMessage GetResponse(string uri)
        {
            try
            {
                return _client.GetAsync(uri).Result;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao conectar com IBGE: " + e.Message);
            }
        }
    }
}