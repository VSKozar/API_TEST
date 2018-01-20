using Newtonsoft.Json;
using System.Configuration;
using System.IO;

namespace API_TEST.TestDataAccess
{
    public class DataHelper
    {
        public static T ReadObjectFromFile<T>(string fileName)
        {
            string FilePath = ConfigurationManager.AppSettings.Get("DataPath") + "\\" + fileName;

            T fileObject = JsonConvert.DeserializeObject<T>(File.ReadAllText(@FilePath));

            return fileObject;
        }
    }
}
