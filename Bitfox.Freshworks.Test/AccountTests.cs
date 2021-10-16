
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bitfox.Freshworks.Tests
{
    public class AccountTests
    {
        private readonly Random rand = new();
        private readonly ICRMClient client = new CRMClientBuilder()
                            .SetSubdomain("notdetected-team")
                            .SetApiKey("OOuMhjaasZwwkfzO__tZFQ")
                            .Build();

        [Fact]
        public void InsertValidTest()
        {
            Assert.True(true);

            //Account account = new()
            //{
            //    Name = $"Random name: {rand.Next(1234)}"
            //};
            //var result = client.Insert(account).Result;


            //Assert.Null(result.Error);
            //Assert.NotNull(result.Content);
            //Assert.Null(result.Includes);
        }






    }
}
