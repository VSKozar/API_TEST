using API_TEST.Core;
using API_TEST.TestDataAccess;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace API_TEST.TestCases
{
    [TestFixture]
    public class UserTests
    {
        /// <summary>
        /// Test verifies that name of second user will be 'Ervin Howell'
        /// </summary>
        [Test]
        //[Ignore("Ignore a test")]
        public void GetUserTest()
        {
            User testUser = UserActions.GetUser(2);
            Assert.AreEqual("Ervin Howell", testUser.Name);
        }

        /// <summary>
        /// Test validates that 10 users was returned
        /// </summary>
        [Test]
        //[Ignore("Ignore a test")]
        public void GetListUsersTest()
        {
            List<User> listOfUsers = UserActions.GetListUsers();
            Assert.AreEqual(10, listOfUsers.Count);
        }

        /// <summary>
        /// Test verifies adding User functionality
        /// </summary>
        [Test]
        //[Ignore("Ignore a test")]
        public void CreateUserTest()
        {
            User testUser = DataHelper.ReadObjectFromFile<User>("user_test_data.json");
            Assert.IsTrue(UserActions.CreateUser(testUser));
        }

        /// <summary>
        /// Test verifies deleting User functionality
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            Assert.IsTrue(UserActions.DeleteUser(3));
        }
    }
}
