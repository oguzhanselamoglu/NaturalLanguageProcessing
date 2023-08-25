namespace NaturalLanguageApp.Services;

public abstract class NLPService
{

    

    protected abstract void Confugure();
    protected abstract Task<NLPResponse> AnalyzeSentimentAsync(string plainText);

    public Task<NLPResponse> RunSentimentAnalyzeAsync(string text)
    {
        Confugure();
        return AnalyzeSentimentAsync(text);
    }
    
    
    
    
}