namespace MessageClient.Helpers
{
    public interface IAppSettings
    {
        string GetHostName();

        string GetUsername();

        string GetPassword();

        string GetSentMessageKey();

        string GetResponseMessageKey();
    }
}