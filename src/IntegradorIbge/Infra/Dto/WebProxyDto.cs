namespace IntegradorIbge.Infra.Dto
{
    public class WebProxyDto
    {
        public WebProxyDto(bool autentica = false, string host = null, string port = null, string user = null, string pass = null)
        {
            Autentica = autentica;
            Host = host;
            Port = port;
            User = user;
            Pass = pass;
        }

        public bool Autentica { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }
}