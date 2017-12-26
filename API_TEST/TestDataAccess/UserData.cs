using System;

namespace API_TEST.TestDataAccess
{
    // Class describes data for testing
    class UserData
    {
        public int id { get; set; }
        public string name { get; set; }

        /// <summary>
        /// Method mapps data from file to UserData object
        /// </summary>
        /// <param name="csvLine">file line</param>
        /// <returns>UserData object</returns>
        public static UserData FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            UserData userData = new UserData();
            userData.id = Convert.ToInt32(values[0]);
            userData.name = Convert.ToString(values[1]);
            return userData;
        }
    }
}
