namespace NaturalLanguageApp.Services.Processing;

public class MicrosoftNLPService: NLPService
{
    public override void Confugure(string credential)
    {
        throw new NotImplementedException();
    }

    public override async Task<NLPResponse> AnalyzeSentimentAsync(string plainText)
    {
        var response = new NLPResponse();
        return response;
    }
}