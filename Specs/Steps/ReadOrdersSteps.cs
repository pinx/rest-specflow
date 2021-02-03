using Data;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using scheduling;
using System.Collections.Generic;
using System.Net.Http;
using TechTalk.SpecFlow;

namespace Specs.Features
{
    [Binding]
    public class ReadOrdersSteps : WebApplicationFactory<Startup>
    {
        public string ApiBaseUrl = "http://localhost/";

        IEnumerable<Order> orders;

        [When(@"i request orders")]
        public void WhenIRequestOrders()
        {
            using (var client = CreateClient())
            {
                var response = client.GetAsync($"{ApiBaseUrl}orders").Result;
                response.Content.Should().NotBeNull();
                var json = response.Content.ReadAsStringAsync().Result;
                orders = JsonConvert.DeserializeObject<IEnumerable<Order>>(json);
            }
        }

        [Then(@"the result should be a list of orders")]
        public void ThenTheResultShouldBeAListOfOrders()
        {
            orders.Should().HaveCountGreaterOrEqualTo(1);
        }
    }
}
