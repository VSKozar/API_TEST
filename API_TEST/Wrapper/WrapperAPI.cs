using RestSharp;
using System.Configuration;

namespace API_TEST.Wrapper
{
    public class WrapperAPI
    {
        string ApiUrl = ConfigurationManager.AppSettings.Get("URL");

        /// <summary>
        /// Method implements GET request
        /// </summary>
        /// <param name="resource">Resource requested</param>
        /// <returns>IRestResponse Type</returns>
        public IRestResponse GetRequest(string resource)
        {
            // create client
            var client = new RestClient(ApiUrl);
            
            // create GET request
            var request = new RestRequest(resource, Method.DELETE);

            // execute the request
            return client.Execute(request);
        }
    }
}
