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


        
        [Fact]
       public void Test2()
        {
            var prop = FoPropertyBuilder.Start()
                .SetName("volume");

            var build = FoComponentBuilder.Start()
                .SetName("Box")
                .AddProperty<string>("label")
                .AddProperty<int>("tag", 100)
                .AddProperty<double>("width")
                .AddProperty<double>("depth")
                .AddProperty<double>("height")
                
                .AddProperty(prop.Build<double>())
                .AddProperty(prop.SetName("title").Build<string>());

            var result1 = build.Build();
            Console.WriteLine($"{result1.AsJson()}");
            Assert.Equal(result1, result1);
        }
    }
}
