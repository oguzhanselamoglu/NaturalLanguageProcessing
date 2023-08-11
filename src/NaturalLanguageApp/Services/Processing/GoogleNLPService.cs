using Google.Apis.Auth.OAuth2;
using Google.Cloud.Language.V1;

namespace NaturalLanguageApp.Services.Processing;

public class GoogleNLPService : NLPService
{
    
    private LanguageServiceClient _client;
    
    public override void Confugure(string credential)
    {
        var _credential = GoogleCredential.FromJson(credential);
        LanguageServiceClientBuilder builder = new LanguageServiceClientBuilder
        {
  
            GoogleCredential = _credential
        };

        _client = builder.Build();
    }

    public override async Task<NLPResponse> AnalyzeSentimentAsync(string plainText)
    {
        
        // string file = ".\\key.json";
        // Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", file);
        //
        // LanguageServiceClient client = LanguageServiceClient.Create();
        // Document document = Document.FromPlainText(text);
        // AnalyzeSentimentResponse response = client.AnalyzeSentiment(document);
        
        var response = new NLPResponse();
        
        var serviceResponse = await _client.AnalyzeSentimentAsync(Document.FromPlainText(plainText));
        var sentiment = serviceResponse.DocumentSentiment;
        response.Magnitude = sentiment.Magnitude;
        response.Score = sentiment.Score;
        return response;
    }
    
    
}