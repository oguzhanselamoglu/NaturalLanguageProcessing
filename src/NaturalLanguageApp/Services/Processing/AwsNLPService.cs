namespace NaturalLanguageApp.Services.Processing;

public class AwsNLPService: NLPService
{
    protected override void Confugure()
    {
        throw new NotImplementedException();
    }

    protected override async Task<NLPResponse> AnalyzeSentimentAsync(string plainText)
    {
        var response = new NLPResponse();
        return response;
    }
}