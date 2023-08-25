using Google.Apis.Auth.OAuth2;
using Google.Cloud.Language.V1;

namespace NaturalLanguageApp.Services.Processing;

public class GoogleNLPService : NLPService
{
    
    private LanguageServiceClient _client;
    
    protected override void Confugure()
    {
        string file = @"key.json";
        var json = File.ReadAllText(file);
        var _credential = GoogleCredential.FromJson(json);
        LanguageServiceClientBuilder builder = new LanguageServiceClientBuilder
        {
  
            GoogleCredential = _credential
        };

        _client = builder.Build();
    }

    protected override async Task<NLPResponse> AnalyzeSentimentAsync(string plainText)
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
        foreach (var sentence in serviceResponse.Sentences)
        {
           Console.WriteLine(sentence);
        }
        response.Magnitude = sentiment.Magnitude;
        response.Score = sentiment.Score;
        return response;
    }
    
    
}