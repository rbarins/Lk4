using Lk4.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using static Lk4.Models.Aluno;

namespace Lk4.Uteis
{
    public class WebService
    {
        HttpClient client = new HttpClient();

        public Aluno MeusDados(string token)
        {
            Aluno aluno = new Aluno();

            var client = new RestClient("http://www.siefor.net.br/api/aluno/meus-dados/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-AUTH-TOKEN", token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject dados = JObject.Parse(response.Content);

                aluno = JsonConvert.DeserializeObject<Aluno>(dados["response"]["data"].ToString());
            }
            return aluno;
        }

        public Aluno MeusDocumentos(string token)
        {
            Aluno aluno = new Aluno();

            var client = new RestClient("http://www.siefor.net.br/api/aluno/meus-documentos/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-AUTH-TOKEN", token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject dados = JObject.Parse(response.Content);

                aluno = JsonConvert.DeserializeObject<Aluno>(dados["response"]["data"].ToString());
            }
            return aluno;
        }

        public Aluno MinhasCobrancas(string token)
        {
            Aluno aluno = new Aluno();

            var client = new RestClient("http://www.siefor.net.br/api/aluno/minhas-cobrancas/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-AUTH-TOKEN", token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject dados = JObject.Parse(response.Content);

                aluno = JsonConvert.DeserializeObject<Aluno>(dados["response"]["data"].ToString());
            }
            return aluno;
        }

        public Aluno MeuPlanoPagamento(string token)
        {
            Aluno aluno = new Aluno();

            var client = new RestClient("http://www.siefor.net.br/api/aluno/meu-plano-de-pagamento/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("X-AUTH-TOKEN", token);

            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JObject dados = JObject.Parse(response.Content);

                aluno = JsonConvert.DeserializeObject<Aluno>(dados["response"]["data"].ToString());
            }
            return aluno;
        }
    }
}