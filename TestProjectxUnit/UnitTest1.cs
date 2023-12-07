using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using ServicesLayer;

namespace TestProjectxUnit
{
    public class UnitTest1
    {
        private readonly IConsole_x _Console;

        public UnitTest1()
        {
            _Console = new Consoles();
        }

        [Fact]
        public void Test1()
        {
            var result = _Console.ShowConsoles();

            Assert.IsType<List<Console_>>(result);
        }

        [Fact]
        public void Test2()
        {
            var result = _Console.ShowConsoles();

            Assert.True(result.Count == 5);
        }
    }
}