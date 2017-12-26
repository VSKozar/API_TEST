using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace API_TEST.TestDataAccess
{
    class ExcelDataAccess
    {
        // path to file
        const string FileName = "..\\..\\TestData\\Users_Names.csv";

        // list of test data
        public static List<UserData> itemList = new List<UserData>();

        /// <summary>
        /// Method reads records from csv file and setup list of testing data.
        /// </summary>
        public static void ReadFromFile()
        {
            itemList = File.ReadAllLines(FileName).Skip(1).Select(v => UserData.FromCsv(v)).ToList();
        }
    }
}