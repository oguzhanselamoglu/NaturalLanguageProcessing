using Azure;
using Azure.AI.TextAnalytics;

namespace NaturalLanguageApp.Services.Processing;

public class MicrosoftNLPService: NLPService
{
    private TextAnalyticsClient _client;
    protected override void Confugure()
    {
        string micAppKey = "appKey";
        Uri endpoint = new("-----url----");
        AzureKeyCredential cr = new(micAppKey);
        _client = new(endpoint, cr);
        
    }

    protected override async Task<NLPResponse> AnalyzeSentimentAsync(string plainText)
    {
        var response = new NLPResponse();
        try
        {
            Response<DocumentSentiment> serviceResponse = _client.AnalyzeSentiment(plainText);
            DocumentSentiment docSentiment = serviceResponse.Value;

            foreach (var VARIABLE in docSentiment.Sentences)
            {
                
            }
            Console.WriteLine($"Document sentiment is {docSentiment.Sentiment} with: ");
            Console.WriteLine($"  Positive confidence score: {docSentiment.ConfidenceScores.Positive}");
            Console.WriteLine($"  Neutral confidence score: {docSentiment.ConfidenceScores.Neutral}");
            Console.WriteLine($"  Negative confidence score: {docSentiment.ConfidenceScores.Negative}");
            response.Score = (float)docSentiment.ConfidenceScores.Positive;

        }
        catch (RequestFailedException exception)
        {
            Console.WriteLine($"Error Code: {exception.ErrorCode}");
            Console.WriteLine($"Message: {exception.Message}");
        }
        return response;
    }
}