using System;
using Xunit;

namespace HelloWorldSpring19test
{
    public class ProgramTests
    {
        [Fact]
        public void Hello_world_Test()
        {
            Assert.Equal("Hello", "Hello");
        }
    }
}
