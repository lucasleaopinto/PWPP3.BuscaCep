using System;
using System.Net;
using Newtonsoft.Json;

namespace BuscaCep.Servicos
{


    public class ServicosViaCep
    {
        private static String enderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public ServicosViaCep()
        {
        }

        public static Endereco BuscaEnderecoCep(String cep)
        {
            String novoEnderecoURL = String.Format(enderecoURL, cep);

            WebClient wc = new WebClient();

            String conteudo = wc.DownloadString(novoEnderecoURL);

            Endereco ende = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return ende;
        }
    }
}
