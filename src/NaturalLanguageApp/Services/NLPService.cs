namespace NaturalLanguageApp.Services;

public abstract class NLPService
{

    public string CredentialFile { get; set; }

    public abstract void Confugure(string credential);
    public abstract Task<NLPResponse> AnalyzeSentimentAsync(string plainText);
    
    
    
    
}