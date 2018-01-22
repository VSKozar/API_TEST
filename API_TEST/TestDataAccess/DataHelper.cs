using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace API_TEST.TestDataAccess
{
    public class DataHelper
    {
        /// <summary>
        /// Method reads data from file and converts them to object
        /// </summary>
        /// <typeparam name="T">Type of expected object</typeparam>
        /// <param name="fileName">Name of file</param>
        /// <returns>Proper object</returns>
        public static T ReadObjectFromFile<T>(string fileName)
        {
            string FilePath = ConfigurationManager.AppSettings.Get("DataPath") + "\\" + fileName;

            T fileObject = JsonConvert.DeserializeObject<T>(File.ReadAllText(@FilePath));

            return fileObject;
        }

        /// <summary>
        /// Method reads data from file and returns List of objects
        /// </summary>
        /// <typeparam name="T">Type of expected objects</typeparam>
        /// <param name="fileName">Name of file</param>
        /// <returns></returns>
        public static List<T> ReadListObjectsFromFile<T>(string fileName)
        {
            string FilePath = ConfigurationManager.AppSettings.Get("DataPath") + "\\" + fileName;

            List<T> fileObject = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(@FilePath));

            return fileObject;
        }
    }
}
