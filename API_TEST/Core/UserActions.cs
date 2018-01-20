using API_TEST.Wrapper;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace API_TEST.Core
{
    public static class UserActions
    {
        /// <summary>
        /// Method gets user by ID
        /// </summary>
        /// <param name="UserId">User ID</param>
        /// <returns>Object User</returns>
        public static User GetUser(int UserId)
        {
            User resUser = new User();

            WrapperAPI request = new WrapperAPI();
            IRestResponse response = request.GetRequest("users/" + UserId.ToString());
            resUser = JsonConvert.DeserializeObject<User>(response.Content);

            return resUser;
        }

        /// <summary>
        /// Method gets list of Users
        /// </summary>
        /// <returns>List Users</returns>
        public static List<User> GetListUsers()
        {
            WrapperAPI request = new WrapperAPI();
            IRestResponse response = request.GetRequest("users");
            List<User> listUsers = JsonConvert.DeserializeObject<List<User>>(response.Content);

            return listUsers;
        }

        /// <summary>
        /// Method adds new User
        /// </summary>
        /// <param name="user">User object</param>
        /// <returns>True if user added successfully and False if not</returns>
        public static bool CreateUser(User user)
        {
            WrapperAPI request = new WrapperAPI();
            IRestResponse response = request.PostRequest("users", user);
            if (response.StatusCode.ToString() == "Created")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method deletes User
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>True if user deleted successfully and False if not</returns>
        public static bool DeleteUser(int userId)
        {
            WrapperAPI request = new WrapperAPI();
            IRestResponse response = request.GetRequest("users/" + userId.ToString());
            if (response.StatusCode.ToString() == "OK")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
