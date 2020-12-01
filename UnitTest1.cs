using FoundryCore;
using System;
using Xunit;

namespace FoundryCoreXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var prop2a = new FoProperty<double>("cost", 100);
            prop2a.toJson();

            Assert.Equal(100, prop2a.Value);
        }
    }
}
