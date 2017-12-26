using RestSharp;

namespace API_TEST.API
{
    class JSONPlaceholderAPI
    {
        // Setting URL
        const string BaseUrl = "https://jsonplaceholder.typicode.com/users";

        /// <summary>
        /// Execution method. Returns JSON as a string in positive scenario and Error message in negative scenario.
        /// </summary>
        public string Execute(RestRequest request)
        {
            var client = new RestClient();
            client.BaseUrl = new System.Uri(BaseUrl);

            // Getting JSON file with list of Users
            var response = client.Execute(request);

            // Checking that request executed successfully
            if (response.ErrorException != null)
            {
                // Returns error message if  execution fails.
                return "Error retrieving response.";
            }

            // Returns JSON as a string.
            return response.Content.ToString();
        }

    }
}
