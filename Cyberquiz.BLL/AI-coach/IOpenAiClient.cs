namespace Cyberquiz.UI.Services
{
    public interface IOpenAiClient
    {
        Task<string> GetFeedback(string prompt);
    }
}
