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
            var request = new RestRequest(resource, Method.GET);

            // execute the request
            return client.Execute(request);
        }

        /// <summary>
        /// Method implements POST request
        /// </summary>
        /// <param name="resource">Resource requested</param>
        /// <param name="objectToPost">Post object</param>
        /// <returns>IRestResponse Type</returns>
        public IRestResponse PostRequest(string resource, object objectToPost)
        {
            // create client
            var client = new RestClient(ApiUrl);

            // create POST request
            var request = new RestRequest(resource, Method.POST);
            request.AddHeader("Content-type", "application/json");

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(objectToPost);

            // execute the request
            return client.Execute(request);
        }

        /// <summary>
        /// Method implements DELETE request
        /// </summary>
        /// <param name="resource">Resource requested</param>
        /// <returns>IRestResponse Type</returns>
        public IRestResponse DeleteRequest(string resource)
        {
            // create client
            var client = new RestClient(ApiUrl);

            // create DELETE request
            var request = new RestRequest(resource, Method.DELETE);

            // execute the request
            return client.Execute(request);
        }
    }
}
