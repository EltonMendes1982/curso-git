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
    public class ConexaoHttpClientProxy
    {
        private WebProxy CriarWebProxy(WebProxyDto proxy)
        {
            var uri = new Uri(string.Format("{0}:{1}", proxy.Host, proxy.Port), UriKind.RelativeOrAbsolute);

            var wp = new WebProxy()
            {
                Address = uri,
                BypassProxyOnLocal = false,
                UseDefaultCredentials = false,

                /* Credenciais enviadas ao servidor de proxy, não ao servidor da web*/
                Credentials = new NetworkCredential(
                    userName: proxy.User,
                    password: proxy.Pass)
            };

            return wp;
        }

        public HttpClientHandler CriarProxy(WebProxyDto proxy)
        {
            var httpClientHandler = new HttpClientHandler()
            {
                Proxy = CriarWebProxy(proxy)
            };

            if (proxy.Autentica)
            {
                httpClientHandler.PreAuthenticate = true;
                httpClientHandler.UseDefaultCredentials = false;

                /* Credenciais dadas ao servidor da Web e não ao servidor de proxy */
                httpClientHandler.Credentials = new NetworkCredential(userName: proxy.User, password: proxy.Pass);
            }

            return httpClientHandler;
        }
    }
}