using System;
using Xunit;
using PrimeService;

namespace PrimeService.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            var actual = Utilities.Sum(1, 0);
            Assert.Equal(1, actual);
        }
    }
}
