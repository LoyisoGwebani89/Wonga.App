using MessageClient.Helpers;
using Xunit;

namespace Wonga.Tests.Helpers
{
    public class AppSettingsTests
    {
        [Fact]
        public void CanGetValuesFromWebConfig()
        {
            //arrange
            var appSettings = new AppSettings();

            //assert
            Assert.Equal("localhost", appSettings.GetHostName());
            Assert.Equal("guest", appSettings.GetUsername());
            Assert.Equal("guest", appSettings.GetPassword());
            Assert.Equal("sentMessageKey", appSettings.GetSentMessageKey());
            Assert.Equal("responseMessageKey", appSettings.GetResponseMessageKey());
        }
    }
}
