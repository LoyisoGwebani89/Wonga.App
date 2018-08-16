using Moq;
using MessageClient.Services;
using Microsoft.Extensions.Logging;


namespace Wonga.Tests.BaseTests
{
    public class BaseTests
    {
        protected IErrorLogger MockErrorLogger { get; set; }
        public BaseTests()
        {
            MockErrorLogger = new Mock<IErrorLogger>().Object;
        }
    }
}