using RestSharp;
using System.Net;

namespace GitHubApiTests
{
    public class ApiTests
    {
   

        [Test]
        public void Test_GetSingleIssue()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("/repos/krismikov/postman/issues/1", Method.Get);
            var response = client.Execute(request); 
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));  
        }
    }
}